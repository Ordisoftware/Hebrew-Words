﻿/// <license>
/// This file is part of Ordisoftware Core Library.
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
/// <created> 2016-04 </created>
/// <edited> 2020-09 </edited>
using System;

namespace Ordisoftware.Core
{

  /// <summary>
  /// Provide localization helper.
  /// </summary>
  static public partial class SysTranslations
  {

    static public readonly TranslationsDictionary AboutBoxTitle
      = new TranslationsDictionary
      {
        [Language.EN] = "About {0}",
        [Language.FR] = "À propos de {0}"
      };

    static public readonly TranslationsDictionary AboutBoxVersion
      = new TranslationsDictionary
      {
        [Language.EN] = "Version {0}",
        [Language.FR] = "Version {0}"
      };

    static public readonly TranslationsDictionary PrivacyNoticeNoData
      = new TranslationsDictionary
      {
        [Language.EN] = "This software doesn't collect any personal information about you, your computer and your network, unless it is specified by its features.",
        [Language.FR] = "Ce logiciel ne collecte aucune information personnelle concernant vous-même, votre ordinateur et votre réseau, à moins que cela ne soit indiqué par ses fonctionnalités."
      };

    static public readonly TranslationsDictionary ApplicationMustExit
      = new TranslationsDictionary
      {
        [Language.EN] = "The application must exit.",
        [Language.FR] = "L'application doit se fermer."
      };

    static public readonly TranslationsDictionary AskToExitApplication
      = new TranslationsDictionary
      {
        [Language.EN] = "Exit application?",
        [Language.FR] = "Quitter l'application ?"
      };

    static public readonly TranslationsDictionary AskToShutdownComputer
      = new TranslationsDictionary
      {
        [Language.EN] = "Shutdown the computer?",
        [Language.FR] = "Arrêter l'ordinateur ?"
      };

    static public readonly TranslationsDictionary AskToContinueOrTerminate
      = new TranslationsDictionary
      {
        [Language.EN] = "You can choose Yes to continue or No to terminate.",
        [Language.FR] = "Vous pouvez choisir Oui pour continuer ou Non pour terminer."
      };

    static public readonly NullSafeDictionary<bool, TranslationsDictionary> HideRestoreCaption
      = new NullSafeDictionary<bool, TranslationsDictionary>()
      {
        [true] = new TranslationsDictionary
        {
          [Language.EN] = "Hide",
          [Language.FR] = "Cacher"
        },
        [false] = new TranslationsDictionary
        {
          [Language.EN] = "Restore",
          [Language.FR] = "Restaurer"
        }
      };

  }

}