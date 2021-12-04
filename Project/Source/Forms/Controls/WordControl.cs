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

partial class WordControl : UserControl
{

  public ReferenceItem Reference { get; private set; }

  public WordControl()
  {
    InitializeComponent();
  }

  public WordControl(ReferenceItem reference) : this()
  {
    Reference = reference;
    LabelHebrew.DataBindings.Add("Text", reference.Word, "Hebrew", false, DataSourceUpdateMode.OnPropertyChanged);
    EditTranslation.DataBindings.Add("Text", reference.Word, "Translation", false, DataSourceUpdateMode.OnPropertyChanged);
  }

  public new bool Focus()
  {
    if ( MainForm.Instance.IsRendering ) return false;
    EditTranslation.Focus();
    return true;
  }

  private void WordControl_Click(object sender, EventArgs e)
  {
    EditTranslation.Focus();
  }

  private void EditTranslation_Enter(object sender, EventArgs e)
  {
    if ( MainForm.Instance.IsRendering ) return;
    EditTranslation.BackColor = Color.AliceBlue;
    EditTranslation.SelectionStart = 0;
    if ( MainForm.Instance.IsComboBoxChanging ) return;
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
      process(Program.Settings.HebrewWordShiftCtrlClickAction);
    else
    if ( ModifierKeys == Keys.Control )
      process(Program.Settings.HebrewWordCtrlClickAction);
    else
    if ( ModifierKeys == Keys.Shift )
      process(Program.Settings.HebrewWordShiftClickAction);
    else
      process(Program.Settings.HebrewWordClickAction);
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
          HebrewTools.OpenWordProvider(Program.Settings.SearchOnlineURL, word);
          break;
        case HebrewWordClickAction.SearchTranslated:
          MainForm.Instance.ActionSearchTranslated.PerformClick();
          break;
        case HebrewWordClickAction.HebrewLetters:
          HebrewTools.OpenHebrewLetters(LabelHebrew.Text, Program.Settings.HebrewLettersExe);
          break;
        case HebrewWordClickAction.Nothing:
          break;
        default:
          throw new AdvancedNotImplementedException(value);
      }
    }
  }

}
