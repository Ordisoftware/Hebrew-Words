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
/// <created> 2019-11 </created>
/// <edited> 2022-05 </edited>
namespace Ordisoftware.Hebrew.Words;

class History : ReferencesList
{

  [SuppressMessage("Performance", "U2U1203:Use foreach efficiently", Justification = "Collection is modified")]
  public override void Add(ReferenceItem reference)
  {
    if ( reference is null || Program.Settings.HistoryCount < 1 )
      return;
    foreach ( var item in Items.Where(item => item.Equals(reference)).ToList() )
      Items.Remove(item);
    Items.Insert(0, new ReferenceItem(reference));
    while ( Items.Count > Program.Settings.HistoryCount )
      Items.RemoveAt(Items.Count - 1);
    Save();
  }

  public History(string filePath) : base(filePath)
  {
  }

}
