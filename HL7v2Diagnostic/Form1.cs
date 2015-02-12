using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HL7v2;

namespace HL7v2Diagnostic
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      public string Message
      {
         get { return txtMessage.Text; }
         set { txtMessage.Text = value; }
      }

      private void txtMessage_TextChanged(object sender, EventArgs e)
      {
         Interpreter = new MshSegmentInterpreter(txtMessage.Text);
         txtField.Text = Interpreter.FieldSeparator.ToString();
         txtComponent.Text = Interpreter.ComponentSeparator.ToString();
         txtFieldRepeat.Text = Interpreter.FieldRepeat.ToString();
         txtEscape.Text = Interpreter.EscapeCharacter.ToString();
         txtSubComponent.Text = Interpreter.SubcomponentSeparator.ToString();
         chkValid.CheckState = Interpreter.IsValid ? CheckState.Checked : CheckState.Unchecked;
      }

      public MshSegmentInterpreter Interpreter { get; private set; }
   }
}
