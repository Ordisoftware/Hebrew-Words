namespace Ordisoftware.HebrewWords
{
  partial class ImportVerseForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionAnalyse = new System.Windows.Forms.Button();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.SplitContainer();
      this.EditSource = new System.Windows.Forms.TextBox();
      this.PanelResult = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
      this.PanelMain.Panel1.SuspendLayout();
      this.PanelMain.Panel2.SuspendLayout();
      this.PanelMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionAnalyse);
      this.panel1.Controls.Add(this.ActionOK);
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(10, 628);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(972, 28);
      this.panel1.TabIndex = 37;
      // 
      // ActionAnalyse
      // 
      this.ActionAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.ActionAnalyse.Enabled = false;
      this.ActionAnalyse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionAnalyse.Location = new System.Drawing.Point(3, 2);
      this.ActionAnalyse.Name = "ActionAnalyse";
      this.ActionAnalyse.Size = new System.Drawing.Size(75, 24);
      this.ActionAnalyse.TabIndex = 0;
      this.ActionAnalyse.Text = "Analyse";
      this.ActionAnalyse.Click += new System.EventHandler(this.ActionAnalyse_Click);
      // 
      // ActionOK
      // 
      this.ActionOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Enabled = false;
      this.ActionOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionOK.Location = new System.Drawing.Point(813, 2);
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.Size = new System.Drawing.Size(75, 24);
      this.ActionOK.TabIndex = 0;
      this.ActionOK.Text = "OK";
      this.ActionOK.Click += new System.EventHandler(this.ActionOK_Click);
      // 
      // ActionCancel
      // 
      this.ActionCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionCancel.Location = new System.Drawing.Point(894, 2);
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.Size = new System.Drawing.Size(75, 24);
      this.ActionCancel.TabIndex = 0;
      this.ActionCancel.Text = "Cancel";
      // 
      // PanelMain
      // 
      this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelMain.Location = new System.Drawing.Point(10, 10);
      this.PanelMain.Name = "PanelMain";
      this.PanelMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // PanelMain.Panel1
      // 
      this.PanelMain.Panel1.Controls.Add(this.EditSource);
      this.PanelMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
      // 
      // PanelMain.Panel2
      // 
      this.PanelMain.Panel2.Controls.Add(this.PanelResult);
      this.PanelMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
      this.PanelMain.Size = new System.Drawing.Size(972, 618);
      this.PanelMain.SplitterDistance = 300;
      this.PanelMain.TabIndex = 38;
      // 
      // EditSource
      // 
      this.EditSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EditSource.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditSource.Location = new System.Drawing.Point(10, 10);
      this.EditSource.Multiline = true;
      this.EditSource.Name = "EditSource";
      this.EditSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.EditSource.Size = new System.Drawing.Size(952, 280);
      this.EditSource.TabIndex = 0;
      this.EditSource.WordWrap = false;
      this.EditSource.TextChanged += new System.EventHandler(this.EditSource_TextChanged);
      // 
      // PanelResult
      // 
      this.PanelResult.AutoScroll = true;
      this.PanelResult.BackColor = System.Drawing.SystemColors.Control;
      this.PanelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelResult.Location = new System.Drawing.Point(10, 10);
      this.PanelResult.Name = "PanelResult";
      this.PanelResult.Padding = new System.Windows.Forms.Padding(10);
      this.PanelResult.Size = new System.Drawing.Size(952, 294);
      this.PanelResult.TabIndex = 23;
      // 
      // ImportVerseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.ClientSize = new System.Drawing.Size(992, 666);
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "ImportVerseForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Import console";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportVerseForm_FormClosed);
      this.panel1.ResumeLayout(false);
      this.PanelMain.Panel1.ResumeLayout(false);
      this.PanelMain.Panel1.PerformLayout();
      this.PanelMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
      this.PanelMain.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer PanelMain;
    private System.Windows.Forms.Button ActionOK;
    private System.Windows.Forms.Button ActionCancel;
    private System.Windows.Forms.TextBox EditSource;
    internal System.Windows.Forms.Panel PanelResult;
    private System.Windows.Forms.Button ActionAnalyse;
  }
}