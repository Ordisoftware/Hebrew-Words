/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
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
/// <edited> 2024-06 </edited>
namespace Ordisoftware.Hebrew.Words;

using System.IO.Pipes;

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  /// <summary>
  /// IPC requests.
  /// </summary>
  [SuppressMessage("CodeQuality", "IDE0079:Retirer la suppression inutile", Justification = "N/A")]
  [SuppressMessage("Vulnerability", "SEC0029:Insecure Deserialization", Justification = "N/A")]
  static void IPCRequests(IAsyncResult ar)
  {
    var server = ar.AsyncState as NamedPipeServerStream;
    try
    {
      server.EndWaitForConnection(ar);
      using var reader = new BinaryReader(server);
      string command = reader.ReadString();
      if ( command is null ) return;
      if ( !Globals.IsReady ) return;
      var lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(command.SplitKeepEmptyLines(" "), ref lang);
      var form = MainForm.Instance;
      var cmd = ApplicationCommandLine.Instance;
      if ( cmd is null ) return;
      Action action = null;
      if ( cmd.ShowMainForm ) action = () => form.Popup();
      if ( !cmd.ReferenceToGo.IsNullOrEmpty() ) action = () => form.GoToReference(cmd.ReferenceToGo, false, true);
      if ( !cmd.SearchWord.IsNullOrEmpty() ) action = () => form.SearchHebrewWord(cmd.SearchWord);
      if ( !cmd.SearchTranslated.IsNullOrEmpty() ) action = () => form.SearchTranslatedWord(cmd.SearchTranslated);
      if ( action is not null )
        SystemManager.TryCatch(() =>
        {
          form.ToolStrip.SyncUI(() => MainForm.Instance.Popup());
          form.ToolStrip.SyncUI(action);
        });
    }
    catch ( EndOfStreamException ex )
    {
      ex.Manage(ShowExceptionMode.None);
    }
    catch ( Exception ex ) when ( ex is ObjectDisposedException || ex is IOException )
    {
      ex.Manage();
    }
    finally
    {
      server.Close();
      SystemManager.CreateIPCServer(IPCRequests);
    }
  }

  /// <summary>
  /// Processes command line options.
  /// </summary>
  static private void ProcessCommandLineOptions()
  {
    try
    {
      if ( SystemManager.CommandLineOptions is null ) return;
      if ( SystemManager.CommandLineOptions.ResetSettings )
      {
        SystemManager.CleanAllLocalAppSettingsFolders();
        CheckSettingsReset(true);
      }
      else
      if ( !Settings.FirstLaunch && SystemManager.CommandLineOptions.HideMainForm )
        Globals.ForceStartupHide = true;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

}
