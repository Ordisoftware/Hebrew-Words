/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  [SuppressMessage("Design", "MA0051:Method is too long", Justification = "N/A")]
  private void RenderSearch(bool isGrouped = false)
  {
    if ( !isGrouped && !CanRender ) return;
    bool tempRendering = Globals.IsRendering;
    Globals.IsRendering = true;
    try
    {
      UpdateSearchButtons();
      PanelSearchResults.Visible = false;
      PanelSearchResults.AutoScrollPosition = new Point(0, 0);
      PanelSearchResults.DisposeAllControls();
      if ( SearchResults is null || SearchResultsCount == 0 )
        return;
      if ( Settings.FoundReferencesViewable > PagingCountDisableForm )
        SetFormDisabled(true);
      var results = SearchResults.Skip(( PagingCurrent - 1 ) * Settings.FoundReferencesViewable)
                                 .Take(Settings.FoundReferencesViewable)
                                 .ToList();
      const int referenceSize = 160;
      const int marginX = 10;
      const int marginY = 10;
      const int minX = marginX;
      int maxX = PanelSearchResults.ClientSize.Width - marginX;
      int xpos = 0;
      int ypos = 0;
      int xx;
      LinkLabel linklabel;
      int indexControl = 0;
      int capacity = results.Count * 2 + results.Sum(r => r.Verse.Words.Count);
      var controls = new Control[capacity];
      foreach ( var reference in results )
      {
        Application.DoEvents();
        if ( Globals.CancelRequired ) { Globals.CancelRequired = false; break; }
        xpos = maxX;
        ypos += marginY;
        linklabel = new()
        {
          AutoSize = true,
          Tag = reference,
          Font = LatinFont8,
          Text = reference.ToString(),
          Location = new Point(xpos -= referenceSize, ypos),
          ContextMenuStrip = ContextMenuStripVerse,
          LinkColor = Color.DarkBlue
        };
        linklabel.LinkClicked += (sender, e) =>
        {
          if ( e.Button == MouseButtons.Left )
          {
            SetView(ViewMode.ChapterVerses);
            GoToReference((ReferenceItem)( (Control)sender ).Tag);
          }
        };
        controls[indexControl++] = linklabel;
        xpos -= marginX;
        xx = xpos;
        Label label = null;
        foreach ( var word in reference.Verse.Words )
        {
          label = new();
          label.AutoSize = true;
          label.Font = HebrewFont12;
          label.Text = word.Hebrew.Trim();
          xpos -= label.PreferredSize.Width;
          if ( xpos < minX )
          {
            xpos = xx - label.PreferredWidth;
            ypos += label.PreferredHeight;
          }
          label.Location = new Point(xpos, ypos);
          label.Click += (sender, e) => PanelSearchResults.Focus();
          if ( CheckWord is not null )
            if ( CheckWord(word) )
            {
              label.Tag = new ReferenceItem(reference, word);
              label.ForeColor = Color.DarkRed;
              label.MouseEnter += LabelMouseEnter;
              label.MouseLeave += LabelMouseLeave;
              label.MouseClick += LabelMouseClick;
            }
            else
              label.ForeColor = SystemColors.ControlText;
          controls[indexControl++] = label;
        }
        ypos += label.PreferredHeight + marginY;
        if ( !reference.Verse.HasTranslation ) continue;
        label = new();
        label.AutoSize = true;
        label.MaximumSize = new Size(xx - marginX, label.MaximumSize.Height);
        label.Text = reference.Verse.Translation;
        label.Location = new Point(xx - label.PreferredSize.Width, ypos);
        label.Click += (sender, e) => PanelSearchResults.Focus();
        controls[indexControl++] = label;
        ypos += label.PreferredHeight + marginY;
      }
      PanelSearchResults.Controls.AddRange(controls);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      Globals.IsRendering = tempRendering;
      if ( Settings.FoundReferencesViewable > PagingCountDisableForm )
        SetFormDisabled(false);
      PanelSearchResults.Visible = true;
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

  private void LabelMouseClick(object sender, MouseEventArgs e)
  {
    SetView(ViewMode.ChapterVerses);
    var item = (ReferenceItem)( (Control)sender ).Tag;
    GoToReference(item);
  }

}
