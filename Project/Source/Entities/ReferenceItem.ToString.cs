﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
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
/// <created> 2016-04 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides reference item
/// </summary>
public partial class ReferenceItem
{

  const string Null = "(null)";

  public override string ToString()
    => $"{Book?.Transcription ?? Null} {Chapter?.Number.ToString() ?? Null}.{Verse?.Number.ToString() ?? Null}";

  public string ToStringWordIncluded()
    => $"{ToString()}:{Word?.Number.ToString() ?? Null}";

  public string ToStringFull()
    => $"{Book?.Transcription ?? Null} ({Book?.CommonName ?? Null}) {Chapter?.Number.ToString() ?? Null}.{Verse?.Number.ToString() ?? Null}";

  public string ToStringBasedOnPrefs()
    => Program.Settings.BookNameHebrewWithCommonName
       ? ToStringFull()
       : ToString();

  public string ToStringFullWordIncluded()
    => $"{ToStringFull()}:{Word?.Number.ToString() ?? Null}";

  public string ToStringBasedOnPrefsWordIncluded()
    => $"{ToStringBasedOnPrefs()}:{Word?.Number.ToString() ?? Null}";

  public string ToStringOnlyNumbers()
    => $"{Book?.Number.ToString() ?? Null}.{Chapter?.Number.ToString() ?? Null}.{Verse?.Number.ToString() ?? Null}";

  public string ToStringOnlyNumbersWordIncluded()
    => $"{ToStringOnlyNumbers()}:{Word?.Number.ToString() ?? Null}";

  public string ToStringOnlyNumbersNoBook()
    => $"{Chapter?.Number.ToString() ?? Null}.{Verse?.Number.ToString() ?? Null}";

}
