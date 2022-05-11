﻿using System;
using System.Diagnostics;

namespace NHunspellExtender
{
  [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
  public partial class MyDialog : System.Windows.Forms.Form
  {

    // Form overrides dispose to clean up the component list.
    [DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if ( disposing && components is not null )
        {
          components.Dispose();
        }
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
      TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      cmdCancel = new System.Windows.Forms.Button();
      cmdCancel.Click += new EventHandler(cmdCancel_Click);
      cmdOK = new System.Windows.Forms.Button();
      cmdOK.Click += new EventHandler(OK_Button_Click);
      chkDisable = new System.Windows.Forms.CheckBox();
      lblText = new System.Windows.Forms.Label();
      lblText.Resize += new EventHandler(lblText_Resize);
      TableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanel1
      // 
      TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
      TableLayoutPanel1.ColumnCount = 2;
      TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
      TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
      TableLayoutPanel1.Controls.Add(cmdCancel, 0, 0);
      TableLayoutPanel1.Controls.Add(cmdOK, 0, 0);
      TableLayoutPanel1.Location = new System.Drawing.Point(119, 37);
      TableLayoutPanel1.Name = "TableLayoutPanel1";
      TableLayoutPanel1.RowCount = 1;
      TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
      TableLayoutPanel1.Size = new System.Drawing.Size(145, 29);
      TableLayoutPanel1.TabIndex = 0;
      // 
      // cmdCancel
      // 
      cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
      cmdCancel.Location = new System.Drawing.Point(75, 3);
      cmdCancel.Name = "cmdCancel";
      cmdCancel.Size = new System.Drawing.Size(66, 23);
      cmdCancel.TabIndex = 1;
      cmdCancel.Text = "No";
      // 
      // cmdOK
      // 
      cmdOK.Anchor = System.Windows.Forms.AnchorStyles.None;
      cmdOK.Location = new System.Drawing.Point(3, 3);
      cmdOK.Name = "cmdOK";
      cmdOK.Size = new System.Drawing.Size(66, 23);
      cmdOK.TabIndex = 0;
      cmdOK.Text = "Yes";
      // 
      // chkDisable
      // 
      chkDisable.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
      chkDisable.AutoSize = true;
      chkDisable.Location = new System.Drawing.Point(12, 44);
      chkDisable.Name = "chkDisable";
      chkDisable.Size = new System.Drawing.Size(97, 17);
      chkDisable.TabIndex = 1;
      chkDisable.Text = "Disable Prompt";
      chkDisable.UseVisualStyleBackColor = true;
      // 
      // lblText
      // 
      lblText.AutoSize = true;
      lblText.Location = new System.Drawing.Point(9, 9);
      lblText.Name = "lblText";
      lblText.Size = new System.Drawing.Size(402, 13);
      lblText.TabIndex = 2;
      lblText.Text = "This is a test to see if the dialog will automatically resize the form when it ge" + "ts too big";
      // 
      // MyDialog
      // 
      AcceptButton = cmdOK;
      AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(276, 78);
      Controls.Add(lblText);
      Controls.Add(chkDisable);
      Controls.Add(TableLayoutPanel1);
      FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "MyDialog";
      ShowInTaskbar = false;
      StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      Text = "MyDialog";
      TableLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();

    }
    internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    internal System.Windows.Forms.Button cmdOK;
    internal System.Windows.Forms.CheckBox chkDisable;
    internal System.Windows.Forms.Label lblText;
    internal System.Windows.Forms.Button cmdCancel;

  }
}