﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-08 </edited>
using System;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide localization helper.
  /// </summary>
  static public partial class Localizer
  {

    static public readonly NullSafeDictionary<bool, NullSafeStringDictionary> HideRestore
      = new NullSafeDictionary<bool, NullSafeStringDictionary>()
      {
        {
          true, new NullSafeStringDictionary
          {
            { Languages.EN, "Hide" },
            { Languages.FR, "Cacher" }
          }
        },
        {
          false, new NullSafeStringDictionary
          {
            { Languages.EN, "Restore" },
            { Languages.FR, "Restaurer" }
          }
        }
      };

    static public readonly NullSafeStringDictionary AboutBoxTitle
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "About {0}" },
        { Languages.FR, "À propos de {0}" }
      };

    static public readonly NullSafeStringDictionary AboutBoxVersion
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Version {0}" },
        { Languages.FR, "Version {0}" }
      };

    static public readonly NullSafeStringDictionary GrammarGuideTitle
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Grammar guide" },
        { Languages.FR, "Guide de grammaire" }
      };

    static public readonly NullSafeStringDictionary MethodNoticeTitle
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Lettriq analysis method notice" },
        { Languages.FR, "Notice de la méthode d'analyse lettrique" }
      };

    static public readonly NullSafeStringDictionary NotYetAvailable
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Not yet available." },
        { Languages.FR, "Pas encore disponible." }
      };

    static public readonly NullSafeStringDictionary WebCheckUpdate
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Checking update..." },
        { Languages.FR, "Vérification de la la mise à jour..." }
      };

    static public readonly NullSafeStringDictionary Initializing
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Initializing..." },
        { Languages.FR, "Initialisation..." }
      };

    static public readonly NullSafeStringDictionary Processing
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Processing..." },
        { Languages.FR, "Traitement..." }
      };

    static public readonly NullSafeStringDictionary ProgressCreatingData
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Creating data..." },
        { Languages.FR, "Création des données..." }
      };

    static public readonly NullSafeStringDictionary AskToContinue
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Do you want to continue?" },
        { Languages.FR, "Voulez-vous continuer ?" }
      };

    static public readonly NullSafeStringDictionary AskToDownload
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Do you want to download it?" },
        { Languages.FR, "Voulez-vous le télécharger ?" }
      };

    static public readonly NullSafeStringDictionary AskToExitApplication
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Exit application?" },
        { Languages.FR, "Quitter l'application ?" }
      };

    static public readonly NullSafeStringDictionary AskToShutdownComputer
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Shutdown the computer?" },
        { Languages.FR, "Arrêter l'ordinateur ?" }
      };

    static public readonly NullSafeStringDictionary LockSessionError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Lock session error:{Globals.NL2}{{0}}" },
        { Languages.FR, $"Erreur de vérouillage de la session :{Globals.NL2}{{0}}" }
      };

    static public readonly NullSafeStringDictionary UpgradeResetRequired
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "An upgrade of the settings is required." + Globals.NL + 
                        "They will be reseted to default values."
        },
        { Languages.FR, "Une mise à jour des paramètres est requise." + Globals.NL + 
                        "Ils vont être réinialisés à leurs valeurs par défaut."
        }
      };

    static public readonly NullSafeStringDictionary NoNewVersionAvailable
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "There is no new version available." },
        { Languages.FR, "Il n'y a pas de nouvelle version de disponible." }
      };

    static public readonly NullSafeStringDictionary NewVersionAvailable
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "A newer version is available : {0}" },
        { Languages.FR, "Une nouvelle version est disponible : {0}" }
      };

    static public readonly NullSafeStringDictionary DownloadingNewVersion
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Downloading new version..." },
        { Languages.FR, "Téléchargement de la nouvelle version..." }
      };

    static public readonly NullSafeStringDictionary DatabaseIntegrityError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Database integrity error:{Globals.NL2}{{0}}" },
        { Languages.FR, $"Erreur d'intégrité de la base de données :{Globals.NL2}{{0}}" }
      };

    static public readonly NullSafeStringDictionary DatabaseVacuumError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Database vacuum failed." },
        { Languages.FR, "Echec du vacuum de la base de données." }
      };

    static public readonly NullSafeStringDictionary AskToCheckParametersAfterDatabaseUpgraded
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Database upgraded." + Globals.NL2 +
                        "Do you want check the parameters?"
        },
        { Languages.FR, "La base de données a été mise à jour." + Globals.NL2 +
                        "Voulez-vous vérifier les paramètres ?"
        }
      };

    static public readonly NullSafeStringDictionary AskToOptimizeDatabase
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Optimization process will close and reopen the database." + Globals.NL2 +
                         AskToContinue[Languages.EN]
        },
        { Languages.FR, "Le processus d'optimisation va fermer et rouvrir la base de données." + Globals.NL2 +
                         AskToContinue[Languages.FR]
        },
      };

    static public readonly NullSafeStringDictionary AskToRestoreWindowPosition
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "This action will restore the window position." + Globals.NL2 +
                         AskToContinue[Languages.EN]
        },
        { Languages.FR, "Cette action va restaurer la position de la fenêtre." + Globals.NL2 +
                         AskToContinue[Languages.FR]
        },
      };

    static public readonly NullSafeStringDictionary ResetPreferences
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Preferences will be reseted to their default values." },
        { Languages.FR, "Les préférences vont être réinitialisées à leurs valeurs par défaut." }
      };


    static public readonly NullSafeStringDictionary AskToResetPreferences
      = new NullSafeStringDictionary()
      {
        { Languages.EN, ResetPreferences[Languages.EN] + Globals.NL2 + AskToContinue[Languages.EN]
        },
        { Languages.FR, ResetPreferences[Languages.FR] + Globals.NL2 + AskToContinue[Languages.FR]
        },
      };

    static public readonly NullSafeStringDictionary AskToLoadInstalledData
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "This action will load the data installed with the application." + Globals.NL2 +
                        "All modifications will be lost." + Globals.NL2 +
                        AskToContinue[Languages.EN]
        },
        { Languages.FR, "Cette action va charger les données installées avec l'application."  + Globals.NL2 +
                        "Toutes les modifications seront perdues." + Globals.NL2 +
                        AskToContinue[Languages.FR]
        },
      };

    static public readonly NullSafeStringDictionary RunShellError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Error on launching :{Globals.NL2}{{0}}{Globals.NL2}{{1}}" },
        { Languages.FR, $"Erreur de lancement :{Globals.NL2}{{0}}{Globals.NL2}{{1}}" },
      };

    static public readonly NullSafeStringDictionary FileNotFound
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"File not found:{Globals.NL2}{{0}}" },
        { Languages.FR, $"Fichier non trouvé :{Globals.NL2}{{0}}" }
      };

    static public readonly NullSafeStringDictionary LoadFileError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Error while loading:{Globals.NL2}{{0}}{Globals.NL2}{{1}}" },
        { Languages.FR, $"Erreur de chargement :{Globals.NL2}{{0}}{Globals.NL2}{{1}}" },
      };

    static public readonly NullSafeStringDictionary ErrorInFile
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Error in {{0}}{Globals.NL2}Line n° {{1}}{Globals.NL2}{{2}}" },
        { Languages.FR, $"Erreur dans {{0}}{Globals.NL2}Ligne n° {{1}}{Globals.NL2}{{2}}" }
      };

    static public readonly NullSafeStringDictionary CreateDBTableError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Error on create table:{Globals.NL2}{{0}}" },
        { Languages.FR, $"Error à la création de la table:{Globals.NL2}{{0}}" },
      };

    static public readonly NullSafeStringDictionary CreateDBColumnError
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Error on create column:{Globals.NL2}{{0}}" },
        { Languages.FR, $"Error à la création de la colonne:{Globals.NL2}{{0}}" },
      };

    static public readonly NullSafeStringDictionary TermNotFound
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Term \"{0}\" not found." },
        { Languages.FR, "Terme \"{0}\" non trouvé." }
      };

    static public readonly NullSafeStringDictionary AskToOpenAllLinks
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Do you want to open all \"{0}\" links?" },
        { Languages.FR, "Voulez-vous ouvrir tous les liens de \"{0}\" ?" }
      };

    static public readonly NullSafeStringDictionary AskToCheckPreferences
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Check preferences." },
        { Languages.FR, "Vérifiez les préférences."  }
      };

    static public readonly NullSafeStringDictionary AskToDownloadHebrewLetters
      = new NullSafeStringDictionary()
      {
        { Languages.EN, $"Hebrew Letters not found." + Globals.NL +
                        AskToCheckPreferences[Languages.EN] + Globals.NL2 +
                        AskToDownload[Languages.EN]
        },
        { Languages.FR, $"Hebrew Letters n'a pas été trouvé." + Globals.NL +
                        AskToCheckPreferences[Languages.FR] + Globals.NL2 +
                        AskToDownload[Languages.FR]
        }
      };

    static public readonly NullSafeStringDictionary AskToDownloadHebrewWords
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Hebrew Words not found." + Globals.NL +
                        AskToCheckPreferences[Languages.EN] + Globals.NL2 +
                        AskToDownload[Languages.EN] },
        { Languages.FR, "Hebrew Words n'a pas été trouvé." + Globals.NL +
                        AskToCheckPreferences[Languages.FR] + Globals.NL2 +
                        AskToDownload[Languages.FR] }
      };

    static public readonly NullSafeStringDictionary ConfigureProviders
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Configure providers" },
        { Languages.FR, "Configurer les fournisseurs" }
      };

    static public readonly NullSafeStringDictionary AskToEmptyHistory
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Empty history?" },
        { Languages.FR, "Vider l'historique ?" }
      };

    static public readonly NullSafeStringDictionary AskToEmptyBookmarks
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Empty bookmarks?" },
        { Languages.FR, "Vider les signets?" }
      };

    static public readonly NullSafeStringDictionary AskToDeleteBookmark
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "Remove the bookmark?" },
        { Languages.FR, "Effacer le signet ?" }
      };

    static public readonly NullSafeStringDictionary AskToReplaceBookmark
      = new NullSafeStringDictionary
      {
        { Languages.EN, "Replace bookmark?" },
        { Languages.FR, "Remplacer le signet ?" }
      };

    static public readonly NullSafeStringDictionary GitHubIssueComment
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "> Describe here what you did, what you expected and what happened." },
        { Languages.FR, "> Décrivez ici ce que vous avez fait, ce que vous attendiez et ce qui c'est passé." }
      };

    static public readonly NullSafeStringDictionary NullSlot
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "(null)" },
        { Languages.FR, "(nulll)" }
      };

    static public readonly NullSafeStringDictionary EmptySlot
      = new NullSafeStringDictionary()
      {
        { Languages.EN, "(not defined)" },
        { Languages.FR, "(non définit)" }
      };

  }

}
