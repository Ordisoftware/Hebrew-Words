﻿/// <license>
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

  private sealed class MetricsItem
  {
    public int DeltaHeight;
    public int ControlWidth;
    public int WordControlsPerLine;
    public int LabelVerseNumberWidth;
    public int EditCommentaryHeight;
    public int EditCommentaryMarginLeft;
    public Font LabelVerseNumberFont;
    public Font EditCommentaryFont;
  }

  static private readonly Properties.Settings Settings = Program.Settings;

  static private readonly Dictionary<Panel, MetricsItem> MetricsCollection = new();

  static internal bool ResetMetricsRequired { get; set; }

  public ReferenceItem Reference { get; init; }

  public WordControl[] WordControls { get; init; }

  public VerseControl()
  {
    InitializeComponent();
  }

  public VerseControl(Panel container, ReferenceItem reference) : this()
  {
    Reference = reference;
    if ( reference.Verse == null ) return;
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
      EditCommentary.Height = metrics.EditCommentaryHeight;
    }
    if ( metrics.WordControlsPerLine != 0 )
    {
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
      PanelComment.Height = metrics.EditCommentaryHeight;
      Height = metrics.DeltaHeight + CreateWordControls() * numberOfLines + PanelSeparator.Height + PanelComment.Height;
    }
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
    using var graphicsNumber = LabelVerseNumber.CreateGraphics();
    var metrics = MetricsCollection[container];
    int widthHScroll = new VScrollBar().Width;
    int width = container.ClientSize.Width - widthHScroll / 2 - container.Padding.Left - container.Padding.Right;
    metrics.LabelVerseNumberFont = new Font(LabelVerseNumber.Font.FontFamily, Settings.FontSizeHebrew - 2, FontStyle.Bold);
    metrics.LabelVerseNumberWidth = TextRenderer.MeasureText(graphicsNumber, "000", metrics.LabelVerseNumberFont).Width + 10;
    metrics.ControlWidth = width;
    metrics.WordControlsPerLine = ( width - Padding.Left - Padding.Right - metrics.LabelVerseNumberWidth ) / Settings.WordControlWidth;
    metrics.EditCommentaryFont = new Font(EditCommentary.Font.FontFamily, Settings.FontSizeCommentary);
    metrics.EditCommentaryHeight = metrics.EditCommentaryFont.Height * Settings.VerseCommentaryLinesCount + metrics.EditCommentaryFont.Height / 2;
    metrics.EditCommentaryMarginLeft = width - metrics.LabelVerseNumberWidth - Padding.Left - Settings.WordControlWidth * metrics.WordControlsPerLine;
    metrics.DeltaHeight = Padding.Top + PanelSeparator.Height + Padding.Bottom + 5;
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
    return control?.Height ?? 0;
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
    MainForm.Instance.CurrentReference = Reference;
    MainForm.Instance.MoveVerseBindingSourceAndAddCurrentToHistory();
  }

  private void EditComment_Leave(object sender, EventArgs e)
  {
    EditCommentary.BackColor = Color.Honeydew;
    EditCommentary.Text = CheckComment(EditCommentary.Text);
  }

  static public string CheckComment(string value)
  {
    if ( Program.Settings.CommentLinePrefix.Length == 0 ) return value;
    var lines = value.SplitKeepEmptyLines(Globals.NL);
    bool changed = false;
    if ( Program.Settings.CommentLineAddPrefix )
    {
      for ( int index = 0; index < lines.Length; index++ )
      {
        if ( lines[index].Length != 0 && !lines[index].StartsWith(Program.Settings.CommentLinePrefix) )
          lines[index] = Program.Settings.CommentLinePrefix + lines[index];
        changed = true;
      }
      if ( changed )
        value = string.Join(Globals.NL, lines);
    }
    else
    if ( Program.Settings.CommentLineRemovePrefix )
    {
      for ( int index = 0; index < lines.Length; index++ )
      {
        if ( lines[index].Length != 0 && lines[index].StartsWith(Program.Settings.CommentLinePrefix) )
          lines[index] = lines[index].Substring(Program.Settings.CommentLinePrefix.Length);
        changed = true;
      }
      if ( changed )
        value = string.Join(Globals.NL, lines);
    }
    return value;
  }

}
