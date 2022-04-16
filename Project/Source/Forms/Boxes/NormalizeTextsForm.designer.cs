using System;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class NormalizeTextsForm : Form
  {

    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <seealso cref="M:System.Windows.Forms.Form.Dispose(bool)"/>
    /// ### <param name="disposing">true si les ressources managées doivent être supprimées ; sinon,
    /// false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas le contenu de cette
    /// méthode avec list'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalizeTextsForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.checkBox6 = new System.Windows.Forms.CheckBox();
      this.checkBox7 = new System.Windows.Forms.CheckBox();
      this.checkBox8 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ActionOK
      // 
      resources.ApplyResources(this.ActionOK, "ActionOK");
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.UseVisualStyleBackColor = true;
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // checkBox1
      // 
      resources.ApplyResources(this.checkBox1, "checkBox1");
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      resources.ApplyResources(this.checkBox2, "checkBox2");
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      resources.ApplyResources(this.checkBox3, "checkBox3");
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      resources.ApplyResources(this.checkBox4, "checkBox4");
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      resources.ApplyResources(this.checkBox5, "checkBox5");
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // checkBox6
      // 
      resources.ApplyResources(this.checkBox6, "checkBox6");
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.UseVisualStyleBackColor = true;
      // 
      // checkBox7
      // 
      resources.ApplyResources(this.checkBox7, "checkBox7");
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.UseVisualStyleBackColor = true;
      // 
      // checkBox8
      // 
      resources.ApplyResources(this.checkBox8, "checkBox8");
      this.checkBox8.Name = "checkBox8";
      this.checkBox8.UseVisualStyleBackColor = true;
      // 
      // NormalizeTextsForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.checkBox5);
      this.Controls.Add(this.checkBox6);
      this.Controls.Add(this.checkBox7);
      this.Controls.Add(this.checkBox8);
      this.Controls.Add(this.checkBox4);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NormalizeTextsForm";
      this.ShowInTaskbar = false;
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    /// <summary>
    /// The button ok control.
    /// </summary>
    private System.Windows.Forms.Button ActionOK;

    /// <summary>
    /// The button cancel control.
    /// </summary>
    private System.Windows.Forms.Button ActionCancel;

    /// <summary>
    /// The first panel.
    /// </summary>
    private System.Windows.Forms.Panel panel1;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private CheckBox checkBox5;
    private CheckBox checkBox6;
    private CheckBox checkBox7;
    private CheckBox checkBox8;
  }

}