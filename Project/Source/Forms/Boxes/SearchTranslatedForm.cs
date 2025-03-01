﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-09 </created>
/// <edited> 2022-05 </edited>
namespace Ordisoftware.Hebrew.Words;

sealed partial class SearchTranslatedForm : Form
{

  static public readonly List<SearchTranslatedForm> Forms = [];

  [SuppressMessage("Performance", "U2U1212:Capture intermediate results in lambda expressions", Justification = "N/A")]
  static public void Run(WordControl sender)
  {
    if ( sender is null || sender.Reference is null ) return;
    var form = Forms.Find(f => f.WordControl.Reference.EqualsWordIncluded(sender.Reference));
    if ( form is not null )
    {
      if ( form.WindowState == FormWindowState.Minimized )
        form.WindowState = FormWindowState.Normal;
      form.Show();
      form.BringToFront();
      return;
    }
    form = new SearchTranslatedForm(sender);
    form.Show();
    form.Location = new Point(Program.Settings.SearchTranslatedFormLocation.X,
                              Program.Settings.SearchTranslatedFormLocation.Y);
    if ( form.Location.X < 0 && form.Location.Y < 0 )
    {
      form.CenterToMainFormElseScreen();
      Program.Settings.SearchTranslatedFormLocation = new Point(form.Location.X, form.Location.Y);
      SystemManager.TryCatch(Program.Settings.Save);
    }
    MainForm.Instance.ActionCloseTranslatedWindows.Enabled = Forms.Count > 0;
  }

  private readonly WordControl WordControl;

  private bool Mutex;

  private SearchTranslatedForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    EditDistinct.Checked = Program.Settings.SearchTranslatedFormFilterDistinct;
  }

  private SearchTranslatedForm(WordControl sender)
  : this()
  {
    Forms.Add(this);
    WordControl = sender;
    LabelReference.Text = sender.Reference.ToString();
    Mutex = true;
    EditHebrew.Text = sender.LabelHebrew.Text;
    Mutex = false;
    Text = sender.Reference.ToStringWordIncluded();
    UpdateResult();
    ActiveControl = ListView;
    if ( ListView.Items.Count > 0 )
      ListView.Items[0].Selected = true;
  }

  private void SearchTranslatedForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    if ( EditReturn.Checked )
    {
      LabelReference_LinkClicked(null, null);
      WordControl.Focus();
    }
  }

  private void SearchTranslatedForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    Forms.Remove(this);
    MainForm.Instance.ActionCloseTranslatedWindows.Enabled = Forms.Count > 0;
    Program.Settings.SearchTranslatedFormLocation = new Point(Location.X, Location.Y);
    Program.Settings.SearchTranslatedFormFilterDistinct = EditDistinct.Checked;
    SystemManager.TryCatch(Program.Settings.Save);
  }

  private void ButtonClose_Click(object sender, EventArgs e)
  {
    Close();
  }

  private void ListView_Resize(object sender, EventArgs e)
  {
    ListView.Columns[1].Width = -2;
  }

  private void ListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
  {
    ListView.Columns[1].Width = -2;
    Program.Settings.FoundReferencesColumnRefWidth = ListView.Columns[0].Width;
  }

  private void ListView_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( ListView.SelectedItems.Count > 0 )
      LabelHebrewWordSource.Text = ( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Hebrew;
  }

  private bool KeyProcessed;

  private void EditHebrew_KeyPress(object sender, KeyPressEventArgs e)
  {
    if ( e.KeyChar == '\r' )
      UpdateResult();
    else
    if ( !HebrewAlphabet.KeyCodes.Contains(Convert.ToString(e.KeyChar)) )
      e.KeyChar = '\x0';
    else
      KeyProcessed = true;
  }

  private void EditHebrew_KeyUp(object sender, KeyEventArgs e)
  {
    if ( KeyProcessed )
    {
      KeyProcessed = false;
      if ( EditHebrew.SelectionStart != 0 )
        EditHebrew.SelectionStart--;
    }
  }

  private void LabelReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ReachReferencedWord(new ReferenceItem(WordControl.Reference));
  }

  private void ListView_DoubleClick(object sender, EventArgs e)
  {
    switch ( Program.Settings.TranslatedItemDoubleClickAction )
    {
      case TranslatedItemDoubleClickAction.Nothing:
        break;
      case TranslatedItemDoubleClickAction.UseTranslation:
        ActionUseTranslation.PerformClick();
        break;
      case TranslatedItemDoubleClickAction.AddTranslation:
        ActionAddTranslation.PerformClick();
        break;
      case TranslatedItemDoubleClickAction.ReachReference:
        ActionReachReference.PerformClick();
        break;
      default:
        throw new AdvNotImplementedException(Program.Settings.TranslatedItemDoubleClickAction.ToStringFull());
    }
  }

  private void ReachReferencedWord(ReferenceItem reference)
  {
    MainForm.Instance.GoToReference(reference);
  }

  private void ActionReachReference_Click(object sender, EventArgs e)
  {
    if ( ListView.SelectedItems.Count < 1 ) return;
    ReachReferencedWord((ReferenceItem)ListView.SelectedItems[0].Tag);
  }

  private string CleanTranslation(string str)
  {
    foreach ( var sign in new[] { ".", ",", ";", ":", "!", "?" } )
      str = str.Replace(sign, string.Empty);
    return str.Trim();
  }

  private void ActionCopyTranslation_Click(object sender, EventArgs e)
  {
    if ( ListView.SelectedItems.Count < 1 ) return;
    var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
    Clipboard.SetText(str);
  }

  private void ActionUseTranslation_Click(object sender, EventArgs e)
  {
    if ( ListView.SelectedItems.Count < 1 ) return;
    var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
    WordControl.Reference.Word.Translation = str;
    WordControl.EditTranslation.Text = str;
    Close();
  }

  private void ActionAddTranslation_Click(object sender, EventArgs e)
  {
    if ( ListView.SelectedItems.Count < 1 ) return;
    var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
    if ( WordControl.Reference.Word.Translation.Trim().Length == 0 )
    {
      WordControl.Reference.Word.Translation = str;
      WordControl.EditTranslation.Text = str;
    }
    else
    {
      WordControl.Reference.Word.Translation += " / " + str;
      WordControl.EditTranslation.Text = WordControl.Reference.Word.Translation;
    }
  }

  private void EditHebrew_TextChanged(object sender, EventArgs e)
  {
    if ( Mutex ) return;
    if ( EditWholeWord.Checked )
      EditWholeWord.Checked = false;
    else
      UpdateResult();
  }

  private void ActionDelLast_Click(object sender, EventArgs e)
  {
    if ( EditHebrew.Text.Length <= 2 ) return;
    EditHebrew.Text = EditHebrew.Text.Remove(0, 1);
    UpdateResult();
  }

  private void ActionDelFirst_Click(object sender, EventArgs e)
  {
    if ( EditHebrew.Text.Length <= 2 ) return;
    EditHebrew.Text = EditHebrew.Text.Remove(EditHebrew.Text.Length - 1, 1);
    UpdateResult();
  }

  private void ActionReset_Click(object sender, EventArgs e)
  {
    EditHebrew.Text = WordControl.Reference.Word.Hebrew;
    EditWholeWord.Checked = true;
    UpdateResult();
  }

  private void EditFilter_CheckedChanged(object sender, EventArgs e)
  {
    UpdateResult();
  }

  private void UpdateResult()
  {
    if ( Mutex ) return;
    Mutex = true;
    try
    {
      ListView.Items.Clear();
      string wordHebrew = EditHebrew.Text;
      if ( wordHebrew.Length < 2 ) return;
      bool checkWholeWord(string str) => str == wordHebrew;
      bool checkContains(string str) => str.Contains(wordHebrew);
      Func<string, bool> check = EditWholeWord.Checked ? checkWholeWord : checkContains;
      var references = from book in ApplicationDatabase.Instance.Books
                       from chapter in book.Chapters
                       from verse in chapter.Verses
                       from word in verse.Words
                       where check(word.Hebrew) && word.Translation.Length > 0
                       select new ReferenceItem(book, chapter, verse, word);
      if ( EditDistinct.Checked )
        references = references.Distinct(new ReferenceItem.WordTranslationComparer());
      foreach ( var item in references )
      {
        var itemList = new ListViewItem(item.ToString()) { Tag = item };
        itemList.SubItems.Add(item.Word.Translation);
        ListView.Items.Add(itemList);
      }
    }
    finally
    {
      Mutex = false;
    }
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    if ( keyData == ( Keys.Alt | Keys.F8 ) )
    {
      MainForm.Instance.ActionCloseTranslatedWindows.PerformClick();
      return true;
    }
    return base.ProcessCmdKey(ref msg, keyData);
  }

  private void ActionShowTranscriptionGuide_Click(object sender, EventArgs e)
  {
    Program.TranscriptionGuideForm.Popup();
  }

  private void ActionShowGrammarGuide_Click(object sender, EventArgs e)
  {
    Program.GrammarGuideForm.Popup();
  }

  private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenHebrewLetters(EditHebrew.Text);
  }

  private void ActionCloseAll_Click(object sender, EventArgs e)
  {
    Close();
    MainForm.Instance.ActionCloseTranslatedWindows.PerformClick();
  }

}
