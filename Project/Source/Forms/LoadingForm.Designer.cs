﻿namespace Ordisoftware.HebrewWords
{
  partial class LoadingForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.ProgressBar);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ProgressBar
      // 
      resources.ApplyResources(this.ProgressBar, "ProgressBar");
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Step = 1;
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // LoadingForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LoadingForm";
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    internal System.Windows.Forms.ProgressBar ProgressBar;
  }
}