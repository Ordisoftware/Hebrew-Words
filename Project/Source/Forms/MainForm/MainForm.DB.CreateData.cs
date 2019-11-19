/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-01 </created>
/// <edited> 2019-09 </edited>
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm : Form
  {

    /// <summary>
    /// Create database content if not exists.
    /// </summary>
    public void CreateDataIfNotExists()
    {
      CreateBooks();
      CreateConcordances();
    }

    public void CreateConcordances()
    {
      int count = 0;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        var command = new OdbcCommand("select count(*) FROM StrongConcordances", connection);
        count = (int)command.ExecuteScalar();
        connection.Close();
      }
      if ( count != 0 )
        return;
      var lines = File.ReadAllLines(Program.AppDocumentsFolderPath + "CSV\\BHS-Strong-no\\" + "brief_info_StrongNo.csv").ToList();
      foreach ( string line in lines )
      {
        var items = line.Split('\t');
        var concordance = DataSet.StrongConcordances.NewStrongConcordancesRow();
        concordance.ID = items[0];
        concordance.Usage = items[1];
        concordance.Original = items[2];
        concordance.Hebrew = HebrewLetters.ConvertToHebrewFont(items[2].RemoveDiacritics());
        concordance.Transcription = items[3];
        concordance.Phonetic = items[4];
        concordance.Translation = items[5];
        concordance.Memo = "";
        DataSet.StrongConcordances.AddStrongConcordancesRow(concordance);
      }
      TableAdapterManager.UpdateAll(DataSet);
    }

    public void CreateBooks()
    {
      int count = 0;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        var command = new OdbcCommand("select count(*) FROM Books", connection);
        count = (int)command.ExecuteScalar();
        connection.Close();
      }
      if ( count != 0 )
      {
        BooksTableAdapter.Fill(DataSet.Books);
        foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        {
          Books enumBook = (Books)( book.Number - 1 );
          book.Hebrew = BooksNames.Hebrew[enumBook];
          book.Original = BooksNames.Original[enumBook];
          book.Name = Enum.GetName(typeof(Books), enumBook).Replace("_", " ");
        }
        TableAdapterManager.UpdateAll(DataSet);
      }
      else
      {
        bool inprogress = true;
        int index = 0;
        int delta = 1;
        var form = new LoadingForm();
        form.LabelOperation.Text = Translations.CreatingData.GetLang();
        form.ProgressBar.Maximum = 64;
        form.Show();
        try
        {
          var taskProgress = new Task(() =>
          {
            while ( inprogress )
            {
              Application.DoEvents();
              index += delta;
              if ( index == form.ProgressBar.Maximum ) delta = -1;
              if ( index == 0 ) delta = +1;
              form.ProgressBar.SyncUI(() => form.ProgressBar.Value = index);
              this.SyncUI(Refresh);
              form.SyncUI(form.Refresh);
              Thread.Sleep(200);
            }
          });
          taskProgress.Start();
          var taskLoad = new Task(() =>
          {
            FillFromFiles();
          });
          taskLoad.Start();
          while ( inprogress )
          {
            Application.DoEvents();
            if ( taskLoad.IsCompleted ) inprogress = false;
            Thread.Sleep(200);
          }
          form.ProgressBar.Value = form.ProgressBar.Maximum;
        }
        finally
        {
          inprogress = false;
          form.Close();
        }
      }
    }

  }

}
