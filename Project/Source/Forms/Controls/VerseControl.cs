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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class VerseControl : UserControl
{

  static int TextHeight;
  static int CommentHeight;

  public readonly WordControl[] WordControls;

  public readonly ReferenceItem Reference;

  public VerseControl()
  {
    InitializeComponent();
  }

  public VerseControl(ReferenceItem reference,
                      int wordControlWidth,
                      int commentLinesCount,
                      ContextMenuStrip menuVerse,
                      ContextMenuStrip menuWord)
  {
    InitializeComponent();
    Dock = DockStyle.Top;
    Reference = reference;
    LabelVerseNumber.Text = reference.Verse.Number.ToString();
    LabelVerseNumber.Tag = reference.Verse.Number;
    LabelVerseNumber.ContextMenuStrip = menuVerse;
    WordControls = new WordControl[reference.Verse.Words.Count];
    int count = reference.Verse.Words.Count;
    for ( int indexWord = 0; indexWord < count; indexWord++ )
    {
      var wordcontrol = new WordControl(new ReferenceItem(reference, reference.Verse.Words[indexWord]));
      wordcontrol.LabelHebrew.ContextMenuStrip = menuWord;
      wordcontrol.Width = wordControlWidth;
      WordControls[indexWord] = wordcontrol;
    }
    PanelWords.Controls.AddRange(WordControls);
    if ( commentLinesCount > 1 )
    {
      if ( TextHeight == 0 )
      {
        using var graphics = EditComment.CreateGraphics();
        TextHeight = TextRenderer.MeasureText(graphics, "A", EditComment.Font).Height;
        CommentHeight = TextHeight * ( commentLinesCount + 1 ) - 3; ;
      }
      EditComment.Multiline = true;
      EditComment.WordWrap = true;
      EditComment.ScrollBars = ScrollBars.Vertical;
      PanelComment.Height = CommentHeight;
    }
    EditComment.Text = reference.Verse.Comment;
    EditComment.DataBindings.Add("Text", reference.Verse, "Comment", false, DataSourceUpdateMode.OnPropertyChanged);
  }

  private void LabelVerseNumber_MouseEnter(object sender, EventArgs e)
  {
    LabelVerseNumber.Cursor = Cursors.Hand;
    LabelVerseNumber.ForeColor = Color.SteelBlue;
  }

  private void LabelVerseNumber_MouseLeave(object sender, EventArgs e)
  {
    LabelVerseNumber.Cursor = Cursors.Default;
    LabelVerseNumber.ForeColor = Color.DarkBlue;
  }

  private void LabelVerseNumber_MouseDown(object sender, MouseEventArgs e)
  {
    if ( WordControls.Length > 0 && !WordControls.Any(c => c.EditTranslation.Focused) )
      WordControls[0].Focus();
  }

  private void LabelVerseNumber_MouseClick(object sender, MouseEventArgs e)
  {
    if ( e.Button != MouseButtons.Left ) return;
    switch ( Program.Settings.VerseLabelClickAction )
    {
      case VerseLabelClickAction.ContextMenu:
        LabelVerseNumber.ContextMenuStrip?.Show(LabelVerseNumber, e.Location);
        break;
      case VerseLabelClickAction.OnlineRead:
        HebrewTools.OpenBibleProvider(Program.Settings.OpenVerseOnlineURL,
                                      Reference.Book.Number,
                                      Reference.Chapter.Number,
                                      Reference.Verse.Number);
        break;
      case VerseLabelClickAction.Select:
      case VerseLabelClickAction.Nothing:
        break;
      default:
        throw new AdvancedNotImplementedException(Program.Settings.VerseLabelClickAction);
    }
  }

  private void EditComment_Enter(object sender, EventArgs e)
  {
    EditComment.BackColor = Color.AliceBlue;
    if ( MainForm.Instance.IsComboBoxChanging ) return;

    // TODO create an event assigned by mainform
    MainForm.Instance.CurrentReference = Reference;
    MainForm.Instance.MoveVerseBindingSourceAndAddCurrentToHistory();
  }

  private void EditComment_Leave(object sender, EventArgs e)
  {
    EditComment.BackColor = Color.Honeydew;
  }

}
