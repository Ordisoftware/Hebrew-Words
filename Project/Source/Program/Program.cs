﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  static partial class Program
  {

    [STAThread]
    static void Main(string[] args)
    {
      if ( !CheckApplicationOnlyOneInstance() ) return;
      CheckSettingsUpgrade();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      CheckCommandLineArguments(args);
      ApplyCurrentLanguage();
      SetFormsIcon();
      Application.Run(MainForm.Instance);
    }

  }

}
