namespace HL7v2Diagnostic
{
   partial class Form1
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
         if (disposing && (components != null))
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
         this.txtMessage = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtField = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtComponent = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtFieldRepeat = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtEscape = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtSubComponent = new System.Windows.Forms.TextBox();
         this.chkValid = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // txtMessage
         // 
         this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMessage.Location = new System.Drawing.Point(13, 13);
         this.txtMessage.Multiline = true;
         this.txtMessage.Name = "txtMessage";
         this.txtMessage.Size = new System.Drawing.Size(259, 97);
         this.txtMessage.TabIndex = 0;
         this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 136);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Field separator";
         // 
         // txtField
         // 
         this.txtField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtField.Location = new System.Drawing.Point(175, 133);
         this.txtField.Name = "txtField";
         this.txtField.ReadOnly = true;
         this.txtField.Size = new System.Drawing.Size(22, 20);
         this.txtField.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 161);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(108, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Component separator";
         // 
         // txtComponent
         // 
         this.txtComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtComponent.Location = new System.Drawing.Point(175, 158);
         this.txtComponent.Name = "txtComponent";
         this.txtComponent.ReadOnly = true;
         this.txtComponent.Size = new System.Drawing.Size(22, 20);
         this.txtComponent.TabIndex = 2;
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 187);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(109, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Field repeat separator";
         // 
         // txtFieldRepeat
         // 
         this.txtFieldRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtFieldRepeat.Location = new System.Drawing.Point(175, 184);
         this.txtFieldRepeat.Name = "txtFieldRepeat";
         this.txtFieldRepeat.ReadOnly = true;
         this.txtFieldRepeat.Size = new System.Drawing.Size(22, 20);
         this.txtFieldRepeat.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 210);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(91, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Escape character";
         // 
         // txtEscape
         // 
         this.txtEscape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtEscape.Location = new System.Drawing.Point(175, 207);
         this.txtEscape.Name = "txtEscape";
         this.txtEscape.ReadOnly = true;
         this.txtEscape.Size = new System.Drawing.Size(22, 20);
         this.txtEscape.TabIndex = 2;
         // 
         // label5
         // 
         this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 239);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(129, 13);
         this.label5.TabIndex = 1;
         this.label5.Text = "Sub-component separator";
         // 
         // txtSubComponent
         // 
         this.txtSubComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtSubComponent.Location = new System.Drawing.Point(175, 236);
         this.txtSubComponent.Name = "txtSubComponent";
         this.txtSubComponent.ReadOnly = true;
         this.txtSubComponent.Size = new System.Drawing.Size(22, 20);
         this.txtSubComponent.TabIndex = 2;
         // 
         // chkValid
         // 
         this.chkValid.AutoSize = true;
         this.chkValid.Enabled = false;
         this.chkValid.Location = new System.Drawing.Point(15, 116);
         this.chkValid.Name = "chkValid";
         this.chkValid.Size = new System.Drawing.Size(49, 17);
         this.chkValid.TabIndex = 3;
         this.chkValid.Text = "Valid";
         this.chkValid.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 264);
         this.Controls.Add(this.chkValid);
         this.Controls.Add(this.txtSubComponent);
         this.Controls.Add(this.txtEscape);
         this.Controls.Add(this.txtFieldRepeat);
         this.Controls.Add(this.txtComponent);
         this.Controls.Add(this.txtField);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtMessage);
         this.Name = "Form1";
         this.Text = "Hl7V2 Diagnostics";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.TextBox txtMessage;
      private System.Windows.Forms.Label label1;
      public System.Windows.Forms.TextBox txtField;
      private System.Windows.Forms.Label label2;
      public System.Windows.Forms.TextBox txtComponent;
      private System.Windows.Forms.Label label3;
      public System.Windows.Forms.TextBox txtFieldRepeat;
      private System.Windows.Forms.Label label4;
      public System.Windows.Forms.TextBox txtEscape;
      private System.Windows.Forms.Label label5;
      public System.Windows.Forms.TextBox txtSubComponent;
      public System.Windows.Forms.CheckBox chkValid;
   }
}

