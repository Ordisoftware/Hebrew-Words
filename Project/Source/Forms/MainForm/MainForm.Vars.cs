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
/// <created> 2019-01 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    /// <summary>
    /// Indicate last showned tooltip.
    /// </summary>
    private ToolTip LastToolTip = new ToolTip();

    /// <summary>
    /// Indicate previous seach paging position.
    /// </summary>
    private int PreviousSeachPagingPosition = -1;

    /// <summary>
    /// Indicate current bible reference.
    /// </summary>
    public ReferenceItem CurrentReference { get; set; }

    /// <summary>
    /// Indicate combobox mutex.
    /// </summary>
    public bool ComboBoxMutex { get; private set; }

    /// <summary>
    /// Indicate if the application is ready for the user.
    /// </summary>
    public bool IsReady { get; private set; }

    /// <summary>
    /// Indicate if windows session is ending.
    /// </summary>
    private bool IsSessionEnding;

    /// <summary>
    /// Indicate if is in loading data stage.
    /// </summary>
    public bool IsLoadingData { get; private set; }

    /// <summary>
    /// Indicate if render view is in progress.
    /// </summary>
    public bool RenderInProcess { get; private set; }

    /// <summary>
    /// Indicate if GoTo is running.
    /// </summary>
    private bool IsGoToRunning;

    /// <summary>
    /// Indicate if current processing must be cancelled.
    /// </summary>
    private bool CancelRequired;

  }

}
