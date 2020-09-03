/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Originally developped for Ordisoftware Core Library.
/// Copyright 2004-2020 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2007-05 </created>
/// <edited> 2020-08 </edited>
using System;
using System.IO;

namespace Ordisoftware.HebrewCommon
{

  static public partial class DebugManager
  {

    static DebugManager()
    {
      TraceForm = new TraceForm("TraceFormLocation", "TraceFormSize");
    }

    static public readonly TraceForm TraceForm;

    private const int MarginSize = 4;
    private const int EnterCountSkip = 2;

    static private int StackSkip = 1;
    static private int EnterCount = 0;
    static private int CurrentMargin = 0;

    static private string Separator = new string('-', 120);

    static private void TraceFileChanged(Listener sender, string filename)
    {
      TraceForm.Text = Path.GetFileNameWithoutExtension(filename);
      TraceForm.AppendText(File.ReadAllText(filename));
    }

    static public void Enter()
    {
      if ( !_Enabled ) return;
      EnterCount++;
      Trace(TraceEvent.Enter, ExceptionInfo.GetCallerName(EnterCountSkip));
    }

    static public void Leave()
    {
      if ( !_Enabled || EnterCount == 0 ) return;
      EnterCount--;
      Trace(TraceEvent.Leave, ExceptionInfo.GetCallerName(EnterCountSkip));
    }

    static private void LeaveInternal()
    {
      if ( !_Enabled || EnterCount == 0 ) return;
      Trace(TraceEvent.Leave, ExceptionInfo.GetCallerName(EnterCountSkip + StackSkip));
      EnterCount--;
      StackSkip = 1;
    }

    static public void Trace(TraceEvent logevent, string text = "")
    {
      if ( !Enabled ) return;
      SystemManager.TryCatch(() =>
      {
        string message = "";
        if ( logevent != TraceEvent.System )
        {
          string str = logevent.ToString().ToUpper();
          if ( str.Length < 9 ) str += new string(' ', 9 - str.Length);
          message += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ " + str + " ] ";
        }
        if ( logevent == TraceEvent.Leave ) CurrentMargin -= MarginSize;
        message += text.Indent(0, CurrentMargin + message.Length) + Globals.NL;
        SystemManager.TryCatch(() => TraceForm.AppendText(message));
        System.Diagnostics.Trace.Write(message);
        if ( logevent == TraceEvent.Enter ) CurrentMargin += MarginSize;
      });
    }

    static private void WriteHeader()
    {
      if ( !_Enabled ) return;
      Trace(TraceEvent.System, Separator);
      Trace(TraceEvent.System, "# " + "START  : " + DateTime.Now.ToString());
      Trace(TraceEvent.System, "# " + "APP    : " + Globals.AssemblyTitle);
      Trace(TraceEvent.System, "# " + "PATH   : " + Globals.RootFolderPath);
      string platformStr = SystemStatistics.Instance.Platform;
      var platformLines = platformStr.SplitNoEmptyLines();
      Trace(TraceEvent.System, "# " + "SYSTEM : " + platformLines.Join(" | "));
      Trace(TraceEvent.System, Separator);
      Trace(TraceEvent.System);
    }

    static private void WriteFooter()
    {
      if ( !_Enabled ) return;
      Trace(TraceEvent.System);
      Trace(TraceEvent.System, Separator);
      Trace(TraceEvent.System, "# " + "UNLEFT : " + EnterCount.ToString());
      Trace(TraceEvent.System, "# " + "APP    : " + Globals.AssemblyTitle);
      Trace(TraceEvent.System, "# " + "STOP   : " + DateTime.Now.ToString());
      Trace(TraceEvent.System, Separator);
      Trace(TraceEvent.System);
    }

    public static void ClearTraces(bool norestart = false)
    {
      if ( !_Enabled ) return;
      try
      {
        string path = TraceListener.Path;
        string code = TraceListener.Code;
        string extension = TraceListener.Extension;
        Stop();
        foreach ( string filename in Directory.GetFiles(path, code + "*" + extension) )
        {
          string date = Path.GetFileNameWithoutExtension(filename).Replace(code, "").Trim();
          SystemManager.TryCatch(() => File.Delete(filename));
        }
        TraceForm.TextBox.Clear();
      }
      finally
      {
        if ( !norestart )
        {
          Start();
          Trace(TraceEvent.Message, nameof(ClearTraces));
        }
      }
    }

  }

}