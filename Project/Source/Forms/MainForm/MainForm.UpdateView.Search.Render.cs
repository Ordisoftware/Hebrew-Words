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
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void RenderSearchResults()
    {
      if ( RenderSearchResultsInProcess ) return;
      RenderSearchResultsInProcess = true;
      try
      {
        PanelSearchResults.SuspendLayout();
        PanelSearchResults.Controls.Clear();
        PanelSearchResults.AutoScrollPosition = new Point(0, 0);
        PanelSearchResults.Refresh();
        GC.Collect();
        UpdateSearchButtons();
        if ( SearchResults == null || SearchResultsCount == 0 )
          return;
        if ( Program.Settings.FoundReferencesViewable > PagingCountDisableForm )
          SetFormDisabled(true);
        var results = SearchResults.ToList()
                      .Skip(( PagingCurrent - 1 ) * Program.Settings.FoundReferencesViewable)
                      .Take(Program.Settings.FoundReferencesViewable);
        int referenceSize = 160;
        int marginX = 10;
        int marginY = 10;
        int minX = marginX;
        int maxX = PanelSearchResults.ClientSize.Width - marginX;
        int x = 0;
        int y = 0;
        int xx;
        foreach ( var reference in results )
        {
          Application.DoEvents();
          if ( CancelRequired ) { CancelRequired = false; break; }
          x = maxX;
          y += marginY;
          var linklabel = new LinkLabel();
          linklabel.AutoSize = true;
          linklabel.Tag = reference;
          linklabel.Text = reference.ToString();
          linklabel.Font = LatinFont8;
          linklabel.LinkColor = Color.DarkBlue;
          linklabel.LinkClicked += (sender, e) =>
          {
            SetView(ViewModeType.Verses);
            GoTo((ReferenceItem)( (Control)sender ).Tag);
          };
          linklabel.Location = new Point(x = x - referenceSize, y);
          PanelSearchResults.Controls.Add(linklabel);
          x -= marginX;
          xx = x;
          Label label = null;
          foreach ( DataSet.WordsRow word in reference.Verse.GetWordsRows() )
          {
            label = new Label();
            label.Text = word.Hebrew.Trim();
            label.AutoSize = true;
            label.Font = HebrewFont12;
            if ( CheckWord != null )
              if ( CheckWord(word) )
              {
                label.Tag = new WordReferencedItem(reference, word);
                label.ForeColor = Color.DarkRed;
                label.MouseEnter += (sender, e) =>
                {
                  ( (Control)sender ).Cursor = Cursors.Hand;
                };
                label.MouseLeave += (sender, e) =>
                {
                  ( (Control)sender ).Cursor = Cursors.Default;
                };
                label.MouseClick += (sender, e) =>
                {
                  SetView(ViewModeType.Verses);
                  var item = (WordReferencedItem)( (Control)sender ).Tag;
                  GoTo(item);
                  foreach ( Control control in PanelViewVerses.Controls )
                    if ( control is WordControl )
                      if ( ( (WordControl)control ).Word == item.Word )
                        control.Focus();
                };
              }
              else
                label.ForeColor = SystemColors.ControlText;
            x -= label.PreferredSize.Width;
            if ( x < minX )
            {
              x = xx - label.PreferredWidth;
              y += label.PreferredHeight;
            }
            label.Location = new Point(x, y);
            label.Click += (sender, e) => PanelSearchResults.Focus();
            PanelSearchResults.Controls.Add(label);
          }
          y += label.PreferredHeight + marginY;
          if ( reference.Verse.IsTranslated() )
          {
            label = new Label();
            label.AutoSize = true;
            label.MaximumSize = new Size(xx - marginX, label.MaximumSize.Height);
            label.Text = reference.Verse.GetTranslation();
            label.Location = new Point(xx - label.PreferredSize.Width, y);
            label.Click += (sender, e) => PanelSearchResults.Focus();
            PanelSearchResults.Controls.Add(label);
            y += label.PreferredHeight + marginY;
          }
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        RenderSearchResultsInProcess = false;
        if ( Program.Settings.FoundReferencesViewable > PagingCountDisableForm )
          SetFormDisabled(false);
        PanelSearchResults.ResumeLayout();
        PanelSearchResults.Focus();
      }
    }

  }

}
