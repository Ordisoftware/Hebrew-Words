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
/// <created> 2019-01 </created>
/// <edited> 2020-04 </edited>
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide SQLite helper methods.
  /// </summary>
  static public class SQLiteHelper
  {

    /// <summary>
    ///  Vacuum the database.
    /// </summary>
    static public void CheckIntegrity(this OdbcConnection connection)
    {
      try
      {
        using ( var sql = connection.CreateCommand() )
        {
          sql.CommandText = "SELECT integrity_check FROM pragma_integrity_check()";
          var errors = new List<string>();
          using ( var reader = sql.ExecuteReader() )
            while ( reader.Read() )
            {
              string str = reader.GetString(0);
              if ( str != "ok" ) errors.Add(str);
            }
          if ( errors.Count > 0 )
            DisplayManager.ShowError("SQLite Database has errors:" + Environment.NewLine + Environment.NewLine +
                                     string.Join(Environment.NewLine, errors));
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    ///  Vacuum the database.
    /// </summary>
    static public void Vacuum(this OdbcConnection connection)
    {
      try
      {
        using ( var sql = connection.CreateCommand() )
        {
          sql.CommandText = "VACUUM;";
          sql.ExecuteNonQuery();
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Get a date like "Year.Month.Day".
    /// </summary>
    /// <param name="date">The date.</param>
    static public string GetDate(DateTime date)
    {
      return $"{date.Year.ToString("0000")}-{date.Month.ToString("00")}-{date.Day.ToString("00")}";
    }

    /// <summary>
    /// Get a date like "Year.Month.Day".
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="month">The month.</param>
    /// <param name="day">The day.</param>
    static public string GetDate(int year, int month, int day)
    {
      return $"{year.ToString("0000")}-{month.ToString("00")}-{day.ToString("00")}";
    }

    /// <summary>
    /// Get a date from a string like "Year.Month.Day".
    /// </summary>
    /// <param name="date">The date.</param>
    static public DateTime GetDate(string date)
    {
      string[] items = date.Split('-');
      return new DateTime(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]), Convert.ToInt32(items[2]));
    }

    /// <summary>
    /// Get a time like "18:00".
    /// </summary>
    /// <param name="time">The time.</param>
    /// <returns>An empty string if time is null</returns>
    static public string FormatTime(TimeSpan? time)
    {
      return time.HasValue ? $"{time.Value.Hours.ToString("00")}:{time.Value.Minutes.ToString("00")}" : "";
    }

  }

}
