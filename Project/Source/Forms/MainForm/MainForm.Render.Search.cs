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

    private void RenderSearch()
    {
      if ( RenderInProcess ) return;
      RenderInProcess = true;
      try
      {
        UpdateSearchButtons();
        PanelSearchResults.SuspendLayout();
        PanelSearchResults.Visible = false;
        PanelSearchResults.AutoScrollPosition = new Point(0, 0);
        while ( PanelSearchResults.Controls.Count > 0 )
          PanelSearchResults.Controls[0].Dispose();
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
        LinkLabel linklabel;
        int indexControl = 0;
        int capacity = results.Count() * 2 + results.Select(r => r.Verse.GetWordsRows().Count()).Sum();
        Control[] controls = new Control[capacity];
        foreach ( var reference in results )
        {
          Application.DoEvents();
          if ( CancelRequired ) { CancelRequired = false; break; }
          x = maxX;
          y += marginY;
          linklabel = new LinkLabel();
          linklabel.AutoSize = true;
          linklabel.Tag = reference;
          linklabel.Font = LatinFont8;
          linklabel.Text = reference.ToString();
          linklabel.Location = new Point(x = x - referenceSize, y);
          linklabel.LinkColor = Color.DarkBlue;
          linklabel.LinkClicked += (sender, e) =>
          {
            SetView(ViewModeType.Verses);
            GoTo((ReferenceItem)( (Control)sender ).Tag);
          };
          controls[indexControl++] = linklabel;
          x -= marginX;
          xx = x;
          Label label = null;
          foreach ( DataSet.WordsRow word in reference.Verse.GetWordsRows() )
          {
            label = new Label();
            label.AutoSize = true;
            label.Font = HebrewFont12;
            label.Text = word.Hebrew.Trim();
            x -= label.PreferredSize.Width;
            if ( x < minX )
            {
              x = xx - label.PreferredWidth;
              y += label.PreferredHeight;
            }
            label.Location = new Point(x, y);
            label.Click += (sender, e) => PanelSearchResults.Focus();
            if ( CheckWord != null )
              if ( CheckWord(word) )
              {
                label.Tag = new WordReferencedItem(reference, word);
                label.ForeColor = Color.DarkRed;
                label.MouseEnter += LabelMouseEnter;
                label.MouseLeave += LabelMouseLeave;
                label.MouseClick += LabelMouseClick;
              }
              else
                label.ForeColor = SystemColors.ControlText;
            controls[indexControl++] = label;
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
            controls[indexControl++] = label;
            y += label.PreferredHeight + marginY;
          }
        }
        PanelSearchResults.Controls.AddRange(controls);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        RenderInProcess = false;
        if ( Program.Settings.FoundReferencesViewable > PagingCountDisableForm )
          SetFormDisabled(false);
        PanelSearchResults.Visible = true;
        PanelSearchResults.ResumeLayout();
        PanelSearchResults.Focus();
      }
    }

    private void LabelMouseEnter(object sender, EventArgs e)
    {
      ( (Control)sender ).Cursor = Cursors.Hand;
    }

    private void LabelMouseLeave(object sender, EventArgs e)
    {
      ( (Control)sender ).Cursor = Cursors.Default;
    }

    private void LabelMouseClick(object sender, EventArgs e)
    {
      SetView(ViewModeType.Verses);
      var item = (WordReferencedItem)( (Control)sender ).Tag;
      GoTo(item);
      foreach ( Control control in PanelViewVerses.Controls )
        if ( control is WordControl )
          if ( ( (WordControl)control ).Word == item.Word )
            control.Focus();
    }

  }

}
