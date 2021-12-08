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
/// <created> 2012-10 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class WordControl : UserControl
{

  static private readonly Properties.Settings Settings = Program.Settings;

  static internal bool ResetTextHeight = true;
  static private int TranslationTextHeight;
  static private int TranslationEditHeight;
  static private int HebrewTextHeight;
  static private int TotalHeight;

  public ReferenceItem Reference { get; private set; }

  public WordControl()
  {
    InitializeComponent();
    if ( Globals.IsVisualStudioDesigner ) return;
    if ( LabelHebrew.Font.Size != Settings.FontSizeHebrew )
      LabelHebrew.Font = new Font(LabelHebrew.Font.FontFamily, Settings.FontSizeHebrew);
    if ( EditTranslation.Font.Size != Settings.FontSizeTranslation )
      EditTranslation.Font = new Font(EditTranslation.Font.FontFamily, Settings.FontSizeTranslation);
  }

  public WordControl(ReferenceItem reference) : this()
  {
    Reference = reference;
    LabelHebrew.DataBindings.Add("Text", reference.Word, "Hebrew", false, DataSourceUpdateMode.OnPropertyChanged);
    EditTranslation.DataBindings.Add("Text", reference.Word, "Translation", false, DataSourceUpdateMode.OnPropertyChanged);
  }

  private void WordControl_Load(object sender, EventArgs e)
  {
    if ( ResetTextHeight || Settings.VerseWordTranslationLinesCount > 1 )
    {
      if ( ResetTextHeight )
      {
        using Graphics graphicsHebrew = LabelHebrew.CreateGraphics();
        HebrewTextHeight = TextRenderer.MeasureText(graphicsHebrew, "lq", LabelHebrew.Font).Height;
        using Graphics graphicsTranslation = EditTranslation.CreateGraphics();
        TranslationTextHeight = TextRenderer.MeasureText(graphicsTranslation, "A", EditTranslation.Font).Height;
        TranslationEditHeight = TranslationTextHeight * ( Settings.VerseWordTranslationLinesCount + 1 ) - 5;
        TotalHeight = HebrewTextHeight + TranslationEditHeight + 5;
        if ( Settings.VerseWordTranslationLinesCount > 1 )
          TotalHeight += 6;
        ResetTextHeight = false;
      }
      if ( Settings.VerseWordTranslationLinesCount > 1 )
      {
        EditTranslation.Multiline = Settings.VerseWordTranslationLinesCount > 1;
        EditTranslation.ScrollBars = ScrollBars.Vertical;
        EditTranslation.WordWrap = true;
      }
    }
    EditTranslation.Height = TranslationEditHeight;
    LabelHebrew.Height = HebrewTextHeight;
    Height = TotalHeight;
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
    EditTranslation.BackColor = Color.AliceBlue;
    EditTranslation.SelectionStart = 0;

    // TODO instance var here instead accessing mainform ?
    if ( MainForm.Instance.IsComboBoxChanging ) return;

    // TODO create an event in versecontrol assigned by mainform and call it using parent
    MainForm.Instance.CurrentReference = Reference;
    MainForm.Instance.MoveVerseBindingSourceAndAddCurrentToHistory();
  }

  private void EditTranslation_Leave(object sender, EventArgs e)
  {
    EditTranslation.BackColor = SystemColors.Window;
  }

  private void LabelHebrew_MouseEnter(object sender, EventArgs e)
  {
    LabelHebrew.Cursor = Cursors.Hand;
    LabelHebrew.ForeColor = Color.DarkRed;
  }

  private void LabelHebrew_MouseLeave(object sender, EventArgs e)
  {
    LabelHebrew.Cursor = Cursors.Default;
    LabelHebrew.ForeColor = SystemColors.ControlText;
  }

  private void LabelHebrew_MouseClick(object sender, MouseEventArgs e)
  {
    EditTranslation.Focus();
    if ( e.Button != MouseButtons.Left ) return;
    if ( ModifierKeys == ( Keys.Shift | Keys.Control ) )
      process(Settings.HebrewWordShiftCtrlClickAction);
    else
    if ( ModifierKeys == Keys.Control )
      process(Settings.HebrewWordCtrlClickAction);
    else
    if ( ModifierKeys == Keys.Shift )
      process(Settings.HebrewWordShiftClickAction);
    else
      process(Settings.HebrewWordClickAction);
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
          // TODO create an event assigned by main form ?
          MainForm.Instance.ActionSearchTranslated.PerformClick();
          break;
        case HebrewWordClickAction.HebrewLetters:
          HebrewTools.OpenHebrewLetters(LabelHebrew.Text, Settings.HebrewLettersExe);
          break;
        case HebrewWordClickAction.Nothing:
          break;
        default:
          throw new AdvancedNotImplementedException(value);
      }
    }
  }

}
