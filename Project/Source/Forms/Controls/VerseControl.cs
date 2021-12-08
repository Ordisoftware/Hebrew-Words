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

  static private readonly Properties.Settings Settings = Program.Settings;

  static internal bool ResetTextHeight = true;
  static int CommentaryTextHeight;
  static int CommentaryHeight;
  static int NumberWidth;

  public readonly WordControl[] WordControls;

  public readonly ReferenceItem Reference;

  public VerseControl()
  {
    InitializeComponent();
  }

  public VerseControl(Panel container, ReferenceItem reference)
  {
    InitializeComponent();
    Dock = DockStyle.Top;
    Reference = reference;
    WordControlsPerLine = container.ClientSize.Width / Settings.WordControlWidth;
    NumberOfLines = reference.Verse.Words.Count / WordControlsPerLine;
    if ( reference.Verse.Words.Count % WordControlsPerLine > 0 ) NumberOfLines++;
    if ( Reference != null )
      WordControls = new WordControl[Reference.Verse.Words.Count];
    container.Controls.Add(this);
    BringToFront();
  }

  private int WordControlsPerLine;
  private int NumberOfLines;

  private void VerseControl_Load(object sender, EventArgs e)
  {
    if ( LabelVerseNumber.Font.Size != Settings.FontSizeHebrew - 2 )
      LabelVerseNumber.Font = new Font(LabelVerseNumber.Font.FontFamily, Settings.FontSizeHebrew - 2, FontStyle.Bold);
    if ( EditCommentary.Font.Size != Settings.FontSizeCommentary )
      EditCommentary.Font = new Font(EditCommentary.Font.FontFamily, Settings.FontSizeCommentary);
    LabelVerseNumber.Text = Reference.Verse.Number.ToString();
    LabelVerseNumber.Tag = Reference.Verse.Number;
    LabelVerseNumber.ContextMenuStrip = MainForm.Instance.ContextMenuStripVerse;
    int count = Reference.Verse.Words.Count;
    int wordControlWidth = Program.Settings.WordControlWidth;
    WordControl wordcontrol = null;
    for ( int indexWord = 0; indexWord < count; indexWord++ )
    {
      wordcontrol = new WordControl(new ReferenceItem(Reference, Reference.Verse.Words[indexWord]));
      wordcontrol.LabelHebrew.ContextMenuStrip = MainForm.Instance.ContextMenuStripWord;
      wordcontrol.Width = wordControlWidth;
      WordControls[indexWord] = wordcontrol;
    }
    PanelWords.Controls.AddRange(WordControls);
    if ( ResetTextHeight || Settings.VerseCommentaryLinesCount > 1 )
    {
      if ( ResetTextHeight )
      {
        using var graphicsCommentary = EditCommentary.CreateGraphics();
        CommentaryTextHeight = TextRenderer.MeasureText(graphicsCommentary, "A", EditCommentary.Font).Height;
        CommentaryHeight = CommentaryTextHeight * ( Settings.VerseCommentaryLinesCount + 1 ) - 5;
        using var graphicsNumber = LabelVerseNumber.CreateGraphics();
        NumberWidth = TextRenderer.MeasureText(graphicsNumber, "000", LabelVerseNumber.Font).Width + 10;
        ResetTextHeight = false;
      }
      if ( Settings.VerseCommentaryLinesCount > 1 )
      {
        EditCommentary.Multiline = true;
        EditCommentary.WordWrap = true;
        EditCommentary.ScrollBars = ScrollBars.Vertical;
        PanelComment.Height = CommentaryHeight;
      }
    }
    LabelVerseNumber.Width = NumberWidth;
    EditCommentary.Text = Reference.Verse.Comment;
    EditCommentary.DataBindings.Add("Text", Reference.Verse, "Comment", false, DataSourceUpdateMode.OnPropertyChanged);
    PanelCommentLeft.Width = WordControls.Min(c => c.Left) + Padding.Left;
    if ( wordcontrol != null )
      Height = Padding.Top + Padding.Left + Padding.Bottom
             + wordcontrol.Height * NumberOfLines
             + EditCommentary.Height;
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
    EditCommentary.BackColor = Color.AliceBlue;
    if ( MainForm.Instance.IsComboBoxChanging ) return;

    // TODO create an event assigned by mainform
    MainForm.Instance.CurrentReference = Reference;
    MainForm.Instance.MoveVerseBindingSourceAndAddCurrentToHistory();
  }

  private void EditComment_Leave(object sender, EventArgs e)
  {
    EditCommentary.BackColor = Color.Honeydew;
  }

}
