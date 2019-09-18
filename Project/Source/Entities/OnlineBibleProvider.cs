/// <license>
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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public class OnlineBibleProvider
  {
    public string Name { get; set; }
    public string URL { get; set; }
    public ToolStripMenuItem CreateMenuItem(EventHandler action, Image image = null)
    {
      var result = new ToolStripMenuItem(Name, image);
      result.Tag = URL;
      result.Click += action;
      return result;
    }
  }

  static public class OnlineBibleProviders
  {

    static public List<OnlineBibleProvider> Items
    {
      get;
      private set;
    }

    static OnlineBibleProviders()
    {
      Items = new List<OnlineBibleProvider>();
      var item = new OnlineBibleProvider();
      item.Name = "StudyBible.org";
      item.URL = "https://studybible.info/IHOT/%BOOKSB% %CHAPTERNUM%:%VERSENUM%";
      Items.Add(item);
      item = new OnlineBibleProvider();
      item.Name = "Mechon-Mamre.org";
      switch ( Localizer.Language )
      {
        case "fr":
          item.URL = "https://www.mechon-mamre.org/f/ft/ft%BOOKNUM#2%%CHAPTERNUM#2%.htm#%VERSENUM#2%";
          break;
        default:
          item.URL = "https://www.mechon-mamre.org/p/pt/pt%BOOKNUM#2%CHAPTERNUM#2%.htm#%VERSENUM#2%";
          break;
      }
      Items.Add(item);
    }

  }

}
