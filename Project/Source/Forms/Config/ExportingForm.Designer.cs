﻿namespace Ordisoftware.Hebrew.Words
{
  partial class ExportingForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportingForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.Label = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.ProgressBar);
      this.panel1.Controls.Add(this.Label);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Name = "panel2";
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
      // 
      // ProgressBar
      // 
      resources.ApplyResources(this.ProgressBar, "ProgressBar");
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Step = 1;
      // 
      // Label
      // 
      resources.ApplyResources(this.Label, "Label");
      this.Label.Name = "Label";
      // 
      // ExportingForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ExportingForm";
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportForm_FormClosed);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label Label;
    public System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button ActionCancel;
  }
}