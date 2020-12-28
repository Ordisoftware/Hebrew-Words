/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2020-03 </edited>
using System;
using System.Linq;
using Ordisoftware.Hebrew.Words.Data;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide book reference item
  /// </summary>
  public class BookItem
  {

    public DataSet.BooksRow Book { get; set; }

    public override string ToString()
    {
      if ( Book == null ) return "";
      int nb = MainForm.Instance.DataSet.Books.Count();
      string str = "";
      if ( nb >= 100 ) str = Book.Number.ToString("000");
      else
      if ( nb >= 10 ) str = Book.Number.ToString("00");
      else
        str = Book.Number.ToString();
      str += ". " + Book.Name;
      if ( Book.CommonName != "" ) str += $" ({Book.CommonName})";
      if ( Book.Translation != "" ) str += $" - {Book.Translation}";
      return str;
    }

    public BookItem(DataSet.BooksRow book)
    {
      Book = book;
    }

  }

}
