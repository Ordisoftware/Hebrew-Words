using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NHunspellExtender
{

  public partial class MyDialog
  {
    public MyDialog()
    {
      InitializeComponent();
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Yes;
      Close();
    }

    private void lblText_Resize(object sender, EventArgs e)
    {
      // We need to resize the form to match
      if ( lblText.Width + 25 > 290 )
      {
        Width = lblText.Width + 25;
      }
      else
      {
        Width = 290;
      }

      if ( lblText.Height + 100 > 110 )
      {
        Height = lblText.Height + 100;
      }
      else
      {
        Height = 110;
      }
    }

    public static DialogResult Show(string Text, string Caption = "")
    {
      var newDialog = new MyDialog();
      newDialog.Text = Caption;
      newDialog.lblText.Text = Text;

      var myStackTrace = new StackTrace();

      newDialog.ShowDialog();

      DialogResult disable;

      if ( newDialog.chkDisable.Checked )
      {
        disable = DialogResult.Ignore;
      }
      else
      {
        disable = DialogResult.None;
      }

      return (DialogResult)( (int)newDialog.DialogResult + (int)disable );
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.No;
      Close();
    }

    public bool DisableFuturePrompts
    {
      get
      {
        return chkDisable.Checked;
      }
    }
  }
}