/// <license>
/// This file is part of Ordisoftware Tweets Inspector.
/// Copyright 2021-2023 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2022-08 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

static class ControlHelper
{

  static internal Color FocusedGeneralTextBoxColor => ControlPaint.LightLight(Program.Settings.ThemeNavigatorItems);

  static internal Color FocusedControlCurrentColor { get; private set; }

  static internal Color FocusedControlOriginalColor { get; private set; }

  static internal void ChangeControlColor(this Control control, Color color)
  {
    FocusedControlOriginalColor = control.BackColor;
    FocusedControlCurrentColor = color;
    control.BackColor = color;
  }

  static internal void RestoreControlColor(this Control control)
  {
    control.BackColor = FocusedControlOriginalColor;
    FocusedControlCurrentColor = FocusedControlOriginalColor;
  }

}
