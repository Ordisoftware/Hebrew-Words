/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2021-02 </edited>
using System;
using System.Data;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  partial class MainForm : Form
  {

    /// <summary>
    /// Create database content if not exists.
    /// </summary>
    public void CreateDataIfNotExists()
    {
      //CreateConcordances();
      CreateBooks();
    }

    private void CreateBooks()
    {
      // TODO refactor and get count for each table and if only one is 0 show message query to recreate
      int countBooks = LockFileConnection.GetRowsCount(DataSet.Books.TableName);
      int countChapters = LockFileConnection.GetRowsCount(DataSet.Chapters.TableName);
      int countVerses = LockFileConnection.GetRowsCount(DataSet.Verses.TableName);
      int countWords = LockFileConnection.GetRowsCount(DataSet.Words.TableName);
      if ( countBooks != 0 )
      {
        BooksTableAdapter.Fill(DataSet.Books);
        if ( Globals.DatabaseUpgraded )
          foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
          {
            Books enumBook = (Books)( book.Number - 1 );
            book.Name = Enum.GetName(typeof(Books), enumBook).Replace("_", " ");
            book.Hebrew = BooksNames.Hebrew[enumBook];
            if ( book.Original == "" )
              book.Original = BooksNames.Original[enumBook];
            if ( book.CommonName == "" )
              book.CommonName = BooksNames.Common.GetLang(enumBook);
          }
        TableAdapterManager.UpdateAll(DataSet);
      }
      if ( ( countBooks == 0 && countChapters == 0 && countVerses == 0 && countWords == 0 )
        || ( CheckIfOneIsTrueAndSomeOthersNot(countBooks == 0, countChapters == 0, countVerses == 0, countWords == 0)
          && DisplayManager.QueryYesNoAbort("Database corrupted. Reset?", // TODO translation
                                          onAbort: () => Environment.Exit(-1)) == DialogResult.Yes ) )
        try
        {
          FillFromFiles();
        }
        finally
        {
          LoadingForm.Instance.Hide();
        }
    }

    static bool CheckIfOneIsTrueAndSomeOthersNot(params bool[] values)
    {
      bool firstIsTrue = values[0];
      bool result = firstIsTrue ^ values[1];
      if ( values.Length > 2 )
        for ( int index = 2; index < values.Length; index++ )
          result = result || ( firstIsTrue ^ values[index] );
      return result;
    }

  }

}
