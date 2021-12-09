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

  private class MetricsItem
  {
    public int ControlWidth;
    public int WordControlsPerLine;
    public int LabelVerseNumberWidth;
    public int EditCommentaryTextHeight;
    public int EditCommentaryHeight;
    public int EditCommentaryMarginLeft;
    public Font LabelVerseNumberFont;
    public Font EditCommentaryFont;
  }

  static private readonly Properties.Settings Settings = Program.Settings;

  static private readonly Dictionary<Panel, MetricsItem> MetricsCollection = new();

  static internal bool ResetMetricsRequired;

  public ReferenceItem Reference { get; init; }

  public WordControl[] WordControls { get; init; }

  public VerseControl()
  {
    InitializeComponent();
  }

  public VerseControl(Panel container, ReferenceItem reference) : this()
  {
    Reference = reference;
    WordControls = new WordControl[reference.Verse.Words.Count];
    MetricsItem metrics;
    if ( !MetricsCollection.ContainsKey(container) )
    {
      metrics = new MetricsItem();
      MetricsCollection.Add(container, metrics);
      ResetMetrics(container);
    }
    else
      metrics = MetricsCollection[container];
    if ( ResetMetricsRequired ) ResetMetrics();
    if ( Settings.VerseCommentaryLinesCount > 1 )
    {
      EditCommentary.Multiline = true;
      EditCommentary.WordWrap = true;
      EditCommentary.ScrollBars = ScrollBars.Vertical;
      PanelComment.Height = metrics.EditCommentaryHeight;
    }
    int numberOfLines = WordControls.Length / metrics.WordControlsPerLine;
    if ( WordControls.Length % metrics.WordControlsPerLine > 0 ) numberOfLines++;
    LabelVerseNumber.Font = metrics.LabelVerseNumberFont;
    LabelVerseNumber.Text = reference.Verse.Number.ToString();
    LabelVerseNumber.Width = metrics.LabelVerseNumberWidth;
    LabelVerseNumber.ContextMenuStrip = MainForm.Instance.ContextMenuStripVerse;
    EditCommentary.Font = metrics.EditCommentaryFont;
    EditCommentary.Text = reference.Verse.Comment;
    EditCommentary.DataBindings.Add("Text", reference.Verse, "Comment", false, DataSourceUpdateMode.OnPropertyChanged);
    PanelCommentLeft.Width = metrics.EditCommentaryMarginLeft;
    Height = Padding.Top + Padding.Left + Padding.Bottom + CreateWordControls() * numberOfLines + EditCommentary.Height;
    Width = metrics.ControlWidth;
  }

  public void ResetMetrics()
  {
    ResetMetricsRequired = false;
    foreach ( var container in MetricsCollection.Keys )
      ResetMetrics(container);
  }

  public void ResetMetrics(Panel container)
  {
    var metrics = MetricsCollection[container];
    using var graphicsNumber = LabelVerseNumber.CreateGraphics();
    using var graphicsCommentary = EditCommentary.CreateGraphics();
    metrics.LabelVerseNumberWidth = TextRenderer.MeasureText(graphicsNumber, "000", LabelVerseNumber.Font).Width + 10;
    int widthHScroll = new VScrollBar().Width;
    int delta = 5 + container.Padding.Left + container.Padding.Right;
    int width = container.ClientSize.Width
              - delta * 2
              - Padding.Left - Padding.Right
              - metrics.LabelVerseNumberWidth;
    metrics.ControlWidth = container.ClientSize.Width - widthHScroll - delta;
    metrics.WordControlsPerLine = width / Settings.WordControlWidth;
    metrics.EditCommentaryTextHeight = TextRenderer.MeasureText(graphicsCommentary, "A", EditCommentary.Font).Height;
    metrics.EditCommentaryHeight = metrics.EditCommentaryTextHeight * ( Settings.VerseCommentaryLinesCount + 1 ) - 5;
    metrics.EditCommentaryMarginLeft = width + Padding.Left - Settings.WordControlWidth * metrics.WordControlsPerLine;
    metrics.LabelVerseNumberFont = new Font(LabelVerseNumber.Font.FontFamily, Settings.FontSizeHebrew - 2, FontStyle.Bold);
    metrics.EditCommentaryFont = new Font(EditCommentary.Font.FontFamily, Settings.FontSizeCommentary);
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
