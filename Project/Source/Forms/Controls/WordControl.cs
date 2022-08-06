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
/// <created> 2012-10 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class WordControl : UserControl
{

  private sealed class MetricsItem
  {
    public int TotalHeight;
    public int EditTranslationHeight;
    public Font LabelHebrewFont;
    public Font EditTranslationFont;
  }

  static private readonly Properties.Settings Settings = Program.Settings;

  static private readonly MetricsItem Metrics = new();

  static internal bool ResetMetricsRequired { get; set; } = true;

  public ReferenceItem Reference { get; init; }

  public WordControl()
  {
    InitializeComponent();
  }

  public WordControl(ReferenceItem reference) : this()
  {
    Reference = reference;
    if ( ResetMetricsRequired ) ResetMetrics();
    if ( Settings.VerseWordTranslationLinesCount > 1 )
    {
      EditTranslation.Multiline = true;
      EditTranslation.WordWrap = true;
      EditTranslation.ScrollBars = ScrollBars.Vertical;
      EditTranslation.Height = Metrics.EditTranslationHeight;
    }
    Height = Metrics.TotalHeight;
    LabelHebrew.ForeColor = Settings.ThemeTranslationTextColor;
    LabelHebrew.Font = Metrics.LabelHebrewFont;
    EditTranslation.ForeColor = Settings.ThemeTranslationTextColor;
    EditTranslation.Font = Metrics.EditTranslationFont;
    EditTranslation.BackColor = Settings.ThemeTranslationBack;
    LabelHebrew.DataBindings.Add("Text", reference.Word, "Hebrew", false, DataSourceUpdateMode.OnPropertyChanged);
    EditTranslation.DataBindings.Add("Text", reference.Word, "Translation", false, DataSourceUpdateMode.OnPropertyChanged);
  }

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP007:Don't dispose injected", Justification = "N/A")]
  public void ResetMetrics()
  {
    ResetMetricsRequired = false;
    Metrics.LabelHebrewFont = new Font(LabelHebrew.Font.Name, Settings.FontSizeHebrew);
    Metrics.EditTranslationFont = new Font(EditTranslation.Font.Name, Settings.FontSizeTranslation);
    Metrics.EditTranslationHeight = Metrics.EditTranslationFont.Height * Settings.VerseWordTranslationLinesCount + Metrics.EditTranslationFont.Height / 2;
    Metrics.TotalHeight = Padding.Top + Metrics.LabelHebrewFont.Height - 3 + Metrics.EditTranslationHeight + Padding.Bottom + 10;
  }

  public new bool Focus()
  {
    if ( Globals.IsRendering ) return false;
    EditTranslation.Focus();
    return true;
  }

  private void WordControl_Click(object sender, EventArgs e)
  {
    EditTranslation.Focus();
  }

  private void EditTranslation_Enter(object sender, EventArgs e)
  {
    if ( Globals.IsRendering ) return;
    Program.ChangeControlColor(EditTranslation, Settings.ThemeCurrentControl);
    EditTranslation.SelectionStart = 0;
    if ( MainForm.Instance.IsComboBoxChanging ) return;
    if ( Settings.CurrentView == ViewMode.VerseFiltered ) return;
    MainForm.Instance.CurrentReference = Reference;
    MainForm.Instance.MoveVerseBindingSourceAndAddCurrentToHistory();
  }

  private void EditTranslation_Leave(object sender, EventArgs e)
  {
    Program.RestoreControlColor(EditTranslation);
    EditTranslation.Text = EditTranslation.Text.SanitizeAndTrimEmptyLinesAndSpaces();
    // TODO remove here and use that for the cleanup tool
    //if ( Reference.Word.Number == Reference.Verse.Words.Count
    //  && !EditTranslation.Text.EndsWith(".", StringComparison.Ordinal) )
    //  EditTranslation.Text += ".";
    if ( Settings.AutoSaveOnLeaveControl )
      MainForm.Instance.ActionSave.PerformClick();
  }

  private void LabelHebrew_MouseEnter(object sender, EventArgs e)
  {
    LabelHebrew.Cursor = Cursors.Hand;
    LabelHebrew.ForeColor = Settings.ThemeVerseHebrewColorHover;
  }

  private void LabelHebrew_MouseLeave(object sender, EventArgs e)
  {
    LabelHebrew.Cursor = Cursors.Default;
    LabelHebrew.ForeColor = Settings.ThemeVerseHebrewColor;
  }

  private void LabelHebrew_MouseClick(object sender, MouseEventArgs e)
  {
    EditTranslation.Focus();
    if ( e.Button != MouseButtons.Left ) return;
    switch ( ModifierKeys )
    {
      case Keys.Shift | Keys.Control:
        process(Settings.HebrewWordShiftCtrlClickAction);
        break;
      case Keys.Control:
        process(Settings.HebrewWordCtrlClickAction);
        break;
      case Keys.Shift:
        process(Settings.HebrewWordShiftClickAction);
        break;
      default:
        process(Settings.HebrewWordClickAction);
        break;
    }
    //
    void process(HebrewWordClickAction value)
    {
      switch ( value )
      {
        case HebrewWordClickAction.ContextMenu:
          LabelHebrew.ContextMenuStrip?.Show(LabelHebrew, new Point(0, LabelHebrew.Height));
          break;
        case HebrewWordClickAction.OnlineSearch:
          string word = Reference.Word.Hebrew;
          HebrewTools.OpenWordProvider(Settings.SearchOnlineURL, word);
          break;
        case HebrewWordClickAction.SearchTranslated:
          MainForm.Instance.ActionSearchTranslated.PerformClick();
          break;
        case HebrewWordClickAction.HebrewLetters:
          HebrewTools.OpenHebrewLetters(LabelHebrew.Text);
          break;
        case HebrewWordClickAction.Nothing:
          break;
        default:
          throw new AdvNotImplementedException(value);
      }
    }
  }

  private void LabelHebrew_MouseDown(object sender, MouseEventArgs e)
  {
    EditTranslation.Focus();
  }

}
