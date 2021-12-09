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

  static internal bool ResetMetricsRequired = true;
  static int EditCommentaryTextHeight;
  static int EditCommentaryHeight;
  static int LabelVerseNumberWidth;
  static int EditCommentaryMarginLeft;
  static int WordControlsPerLine;
  static Font LabelVerseNumberFont;
  static Font EditCommentaryFont;

  public WordControl[] WordControls { get; init; }

  public ReferenceItem Reference { get; init; }

  public VerseControl()
  {
    InitializeComponent();
  }

  public VerseControl(Panel container, ReferenceItem reference) : this()
  {
    Reference = reference;
    WordControls = new WordControl[reference.Verse.Words.Count];
    Width = container.ClientSize.Width;
    if ( ResetMetricsRequired ) ResetMetrics(container);   // TODO update ResetTextHeight after win resized & maximized
    if ( Settings.VerseCommentaryLinesCount > 1 )
    {
      EditCommentary.Multiline = true;
      EditCommentary.WordWrap = true;
      EditCommentary.ScrollBars = ScrollBars.Vertical;
      PanelComment.Height = EditCommentaryHeight;
    }
    int numberOfLines = WordControls.Length / WordControlsPerLine;
    if ( WordControls.Length % WordControlsPerLine > 0 ) numberOfLines++;
    LabelVerseNumber.Font = LabelVerseNumberFont;
    LabelVerseNumber.Text = reference.Verse.Number.ToString();
    LabelVerseNumber.Width = LabelVerseNumberWidth;
    LabelVerseNumber.ContextMenuStrip = MainForm.Instance.ContextMenuStripVerse;
    EditCommentary.Font = EditCommentaryFont;
    EditCommentary.Text = reference.Verse.Comment;
    EditCommentary.DataBindings.Add("Text", reference.Verse, "Comment", false, DataSourceUpdateMode.OnPropertyChanged);
    PanelCommentLeft.Width = EditCommentaryMarginLeft;
    Height = Padding.Top + Padding.Left + Padding.Bottom + CreateWordControls() * numberOfLines + EditCommentary.Height;
  }

  public void ResetMetrics(Panel container)
  {
    using var graphicsNumber = LabelVerseNumber.CreateGraphics();
    using var graphicsCommentary = EditCommentary.CreateGraphics();
    LabelVerseNumberWidth = TextRenderer.MeasureText(graphicsNumber, "000", LabelVerseNumber.Font).Width + 10;
    int width = container.ClientSize.Width + new VScrollBar().Width
              - container.Padding.Left - container.Padding.Right
              - Padding.Left - Padding.Right
              - LabelVerseNumberWidth;
    WordControlsPerLine = width / Settings.WordControlWidth;
    EditCommentaryTextHeight = TextRenderer.MeasureText(graphicsCommentary, "A", EditCommentary.Font).Height;
    EditCommentaryHeight = EditCommentaryTextHeight * ( Settings.VerseCommentaryLinesCount + 1 ) - 5;
    EditCommentaryMarginLeft = width + Padding.Left - Settings.WordControlWidth * WordControlsPerLine;
    LabelVerseNumberFont = new Font(LabelVerseNumber.Font.FontFamily, Settings.FontSizeHebrew - 2, FontStyle.Bold);
    EditCommentaryFont = new Font(EditCommentary.Font.FontFamily, Settings.FontSizeCommentary);
    ResetMetricsRequired = false;
  }

  private int CreateWordControls()
  {
    WordControl control = null;
    int width = Settings.WordControlWidth;
    int count = WordControls.Length;
    for ( int index = 0; index < count; index++ )
    {
      control = new WordControl(new ReferenceItem(Reference, Reference.Verse.Words[index]));
      control.LabelHebrew.ContextMenuStrip = MainForm.Instance.ContextMenuStripWord;
      control.Width = width;
      WordControls[index] = control;
    }
    PanelWords.Controls.AddRange(WordControls);
    return control.Height;
  }

  private void LabelVerseNumber_MouseEnter(object sender, EventArgs e)
  {
    LabelVerseNumber.Cursor = Cursors.Hand;
    LabelVerseNumber.ForeColor = Color.RoyalBlue;
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
