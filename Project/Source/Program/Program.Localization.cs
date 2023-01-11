/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2016-04 </created>
/// <edited> 2022-09 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  /// <summary>
  /// Updates localization strings to the whole application.
  /// </summary>
  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP004:Don't ignore created IDisposable", Justification = "<En attente>")]
  static public void UpdateLocalization()
  {
    Globals.ChronoTranslate.Restart();
    Task task = null;
    try
    {
      static void update(Form form)
      {
        new Infralution.Localization.CultureManager().ManagedControl = form;
        var resources = new ComponentResourceManager(form.GetType());
        resources.ApplyResources(form.Controls);
      }
      string lang = "en-US";
      if ( Settings.LanguageSelected == Language.FR ) lang = "fr-FR";
      var culture = new CultureInfo(lang);
      Thread.CurrentThread.CurrentCulture = culture;
      Thread.CurrentThread.CurrentUICulture = culture;
      task = new Task(HebrewGlobals.LoadProviders);
      task.Start();
      if ( Globals.IsReady )
      {
        MessageBoxEx.CloseAll();
        AboutBox.Instance.Hide();
        //StatisticsForm.Instance.Hide();
      }
      else
        update(MainForm.Instance);
      new Infralution.Localization.CultureManager().ManagedControl = StatisticsForm.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = TranscriptionGuideForm;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
      new Infralution.Localization.CultureManager().ManagedControl = BibleStatisticsForm.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = ParashotForm.Instance;
      Infralution.Localization.CultureManager.ApplicationUICulture = culture;
      var formsToSkip = new Form[] { DebugManager.TraceForm, AboutBox.Instance, GrammarGuideForm };
      foreach ( Form form in Application.OpenForms.GetAll().Except(formsToSkip) )
      {
        update(form);
        if ( form is ShowTextForm formShowText )
          formShowText.Relocalize();
      }
      // Various updates
      if ( Globals.IsReady )
      {
        TextBoxEx.Relocalize();
        LoadingForm.Instance.Relocalize();
        AboutBox.Instance.AboutBox_Shown(null, null);
        TranscriptionGuideForm.HTMLBrowserForm_Shown(null, null);
        GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
        MainForm.Instance.RenderChapterTranslation();
        MainForm.Instance.RenderChapterOriginal();
        MainForm.Instance.RenderChapterELS50();
        MainForm.Instance.SetView(Settings.CurrentView, true);
        MainForm.Instance.LabelTitle.Visible = true;
        MainForm.Instance.LabelTitleReferenceName.Visible = true;
        MainForm.Instance.LabelProgress.Visible = true;
        MainForm.Instance.UpdateTitle();
      }
      MainForm.Instance.EditSearchWord.CheckClipboardContentType();
      task?.Wait();
      MainForm.Instance.CreateSystemInformationMenu();
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      Globals.ChronoTranslate.Stop();
      Settings.BenchmarkTranslate = Globals.ChronoTranslate.ElapsedMilliseconds;
    }
  }

  /// <summary>
  /// Indicates spell checker for TextBoxEx.
  /// </summary>
  //static private NHunspellExtender.NHunspellTextBoxExtender SpellChecker;

  // https://www.nuget.org/packages/NHunspell.Patched/1.2.5554

  /// <summary>
  /// Creates or update the spell checker to display context menu items.
  /// </summary>
  static public void TextBox_Relocalized()
  {
    //if ( Globals.IsVisualStudioDesigner ) return;
    //if ( SpellChecker is not null )
    //{
    //  TextBoxEx.ContextMenuEdit.Opening -= SpellChecker.ContextMenu_Opening;
    //  TextBoxEx.ContextMenuEdit.Closed -= SpellChecker.ContextMenu_Closed;
    //  SpellChecker.controlEnabled.Clear();
    //}
    //SpellChecker = new();
    //TextBoxEx.ContextMenuEdit.Opening += SpellChecker.ContextMenu_Opening;
    //TextBoxEx.ContextMenuEdit.Closed += SpellChecker.ContextMenu_Closed;
  }

  /// <summary>
  /// Update the connection between the spell checker and a TextBoxEx.
  /// </summary>
  static public void TextBox_UpdateSpellChecker(object sender, EventArgs e)
  {
    //if ( SpellChecker is null ) return;
    //if ( sender is not TextBoxEx textbox ) return;
    //if ( !Globals.SpellCheckEnabled || !textbox.SpellCheckAllowed || textbox.ReadOnly )
    //  SpellChecker.SetSpellCheckEnabled(textbox, false);
    //else
    //if ( Globals.SpellCheckEnabled && textbox.SpellCheckAllowed )
    //{
    //  SpellChecker.SetSpellCheckEnabled(textbox, true);
    //  textbox.Disposed += (_, _) => SpellChecker.SetSpellCheckEnabled(textbox, false);
    //}
  }

}
