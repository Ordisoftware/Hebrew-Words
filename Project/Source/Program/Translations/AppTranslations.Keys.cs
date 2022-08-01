/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
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
/// <created> 2021-02 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Localization strings.
/// </summary>
static partial class AppTranslations
{

  static public readonly TranslationsDictionary NoticeKeyboardShortcutsTitle = new()
  {
    [Language.EN] = "Keyboard shortcuts notice",
    [Language.FR] = "Notice des raccourcis clavier"
  };

  static public readonly TranslationsDictionary NoticeKeyboardShortcuts = new()
  {
    [Language.EN] = "Ctrl + Tab : Next view" + Globals.NL +
                    "Shift + Ctrl + Tab : Previous view" + Globals.NL +
                    "F1 : Chapter verses view" + Globals.NL +
                    "F2 : Chapter translation view" + Globals.NL +
                    "F3 : Filter verses view" + Globals.NL +
                    "F4 or Alt + F : Search in database view" + Globals.NL +
                    "F5 : Original Hebrew text view" + Globals.NL +
                    "F6 : ELS50 verses view" + Globals.NL +
                    "F7 or Shift + Ctrl + F : Go to reference" + Globals.NL +
                    "F9 or Ctrl + R : Refresh" + Globals.NL +
                    "Ctrl + B : Books board" + Globals.NL +
                    "Ctrl + B : Parashot board" + Globals.NL +
                    "Ctrl + Alt + I : Import console" + Globals.NL +
                    "Ctrl + Alt + S : Tanak's statistics" + Globals.NL +
                    "Alt + C : Calculator" + Globals.NL +
                    "Ctrl + H : Open Hebrew Letters" + Globals.NL +
                    "Ctrl + G : Open grammar guide" + Globals.NL +
                    "Ctrl + O : Open verse context menu" + Globals.NL +
                    "Ctrl + W : Open word context menu" + Globals.NL +
                    "Ctrl + T : See already translated for the focused Hebrew word" + Globals.NL +
                    "Ctrl + K : Search in database for the focused Hebrew word" + Globals.NL +
                    "Ctrl + F : Find verse in current chapter" + Globals.NL +
                    "Ctrl + S : Save changes" + Globals.NL +
                    "Alt + Left : Previous verse" + Globals.NL +
                    "Alt + Right : Next verse" + Globals.NL +
                    "Shift + Alt + Left : First verse" + Globals.NL +
                    "Shift + Alt + Right : Last verse" + Globals.NL +
                    "Shift + Alt + Up : Last verse of previous chapter" + Globals.NL +
                    "Shift + Alt + Down : First verse of next chapter" + Globals.NL +
                    "Alt + Home : Reach the beginning of the view" + Globals.NL +
                    "Alt + End : Reach the ending of the view" + Globals.NL +
                    "Alt + PageUp : Scroll the view up" + Globals.NL +
                    "Alt + PageDown : Scroll the view down" + Globals.NL +
                    "Alt + Up : Fine scroll the view up" + Globals.NL +
                    "Alt + Down : Fine scroll the view down" + Globals.NL +
                    "Alt + B : Bookmarks menu" + Globals.NL +
                    "Alt + H : History menu" + Globals.NL +
                    "Alt + D : Database menu" + Globals.NL +
                    "Alt + T : Tools menu" + Globals.NL +
                    "Alt + L : Web links menu" + Globals.NL +
                    "Alt + S : Settings menu" + Globals.NL +
                    "Alt + I : Information menu" + Globals.NL +
                    "Alt + E : Export folder" + Globals.NL +
                    "F9 : Preferences" + Globals.NL +
                    "F10 : Log file window" + Globals.NL +
                    "F11 : Usage statistics window" + Globals.NL +
                    "F12 : About" + Globals.NL +
                    "Alt + F4 (or Escape) : Close window",

    [Language.FR] = "Ctrl + Tab : Vue suivante" + Globals.NL +
                    "Maj + Ctrl + Tab : Vue précédente" + Globals.NL +
                    "F1 : Vue des versets du chapitre" + Globals.NL +
                    "F2 : Vue de la traduction des chapitres" + Globals.NL +
                    "F3 : Vue du filtre des versets" + Globals.NL +
                    "F4 ou Alt + F : Vue de rechercher dans la base de données" + Globals.NL +
                    "F5 : Vue du texte original en hébreu" + Globals.NL +
                    "F6 : vue des versets ELS50" + Globals.NL +
                    "F7 ou Maj + Ctrl + F : Aller à la référence" + Globals.NL +
                    "F9 ou Ctrl + R : Rafraîchir" + Globals.NL +
                    "Ctrl + B : Tableau des livres" + Globals.NL +
                    "Ctrl + B : tableau des parashot" + Globals.NL +
                    "Ctrl + Alt + I : Console d'importation" + Globals.NL +
                    "Ctrl + Alt + S : Statistiques de Tanak" + Globals.NL +
                    "Alt + C : Calculatrice" + Globals.NL +
                    "Ctrl + H : Ouvrir Hebrew Letters" + Globals.NL +
                    "Ctrl + G : Ouvrir le guide de grammaire" + Globals.NL +
                    "Ctrl + O : Ouvrir le menu contextuel du verset" + Globals.NL +
                    "Ctrl + W : Ouvrir le menu contextuel du mot" + Globals.NL +
                    "Ctrl + T : Voir les déjà traduit pour le mot hébreu ciblé" + Globals.NL +
                    "Ctrl + K : Rechercher dans la base de données le mot hébreu ciblé" + Globals.NL +
                    "Ctrl + F : Rechercher le verset dans le chapitre en cours" + Globals.NL +
                    "Ctrl + S : Enregistrer les modifications" + Globals.NL +
                    "Alt + Gauche : Verset précédent" + Globals.NL +
                    "Alt + Droite : Verset suivant" + Globals.NL +
                    "Maj + Alt + Gauche : Premier verset" + Globals.NL +
                    "Maj + Alt + Droite : Dernier verset" + Globals.NL +
                    "Maj + Alt + Haut : Dernier couplet du chapitre précédent" + Globals.NL +
                    "Maj + Alt + Bas : Premier verset du chapitre suivant" + Globals.NL +
                    "Alt + Accueil : Atteindre le début de la vue" + Globals.NL +
                    "Alt + End : Atteindre la fin de la vue" + Globals.NL +
                    "Alt + PageUp : Faire défiler la vue vers le haut" + Globals.NL +
                    "Alt + PageDown : Faire défiler la vue vers le bas" + Globals.NL +
                    "Alt + Haut : Faire défiler la vue vers le haut (fin)" + Globals.NL +
                    "Alt + Bas : Faire défiler la vue vers le bas (fin)" + Globals.NL +
                    "Alt + B : Menu des signets" + Globals.NL +
                    "Alt + H : Menu de l'historique" + Globals.NL +
                    "Alt + D : Menu de la base de données" + Globals.NL +
                    "Alt + T : Menu des outils" + Globals.NL +
                    "Alt + L : Menu des liens web" + Globals.NL +
                    "Alt + I : Menu des informations" + Globals.NL +
                    "Alt + S : Menu des paramètres" + Globals.NL +
                    "Alt + E : Dossier d'exportation" + Globals.NL +
                    "F9 : Préférences" + Globals.NL +
                    "F10 : Fenêtre du fichier log" + Globals.NL +
                    "F11 : Fenêtre des statistiques d'utilisation" + Globals.NL +
                    "F12 : A propos" + Globals.NL +
                    "Alt + F4 (ou Échap) : Ferme la fenêtre",
  };

}
