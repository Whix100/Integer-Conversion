namespace Integer_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.BiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OctTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DecTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary";
            // 
            // BiTextBox
            // 
            this.BiTextBox.Location = new System.Drawing.Point(106, 12);
            this.BiTextBox.Name = "BiTextBox";
            this.BiTextBox.Size = new System.Drawing.Size(329, 22);
            this.BiTextBox.TabIndex = 1;
            this.BiTextBox.Text = "0";
            this.BiTextBox.TextChanged += new System.EventHandler(this.BiTextBox_TextChanged);
            this.BiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BiTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Octal";
            // 
            // OctTextBox
            // 
            this.OctTextBox.Location = new System.Drawing.Point(106, 40);
            this.OctTextBox.Name = "OctTextBox";
            this.OctTextBox.Size = new System.Drawing.Size(329, 22);
            this.OctTextBox.TabIndex = 1;
            this.OctTextBox.Text = "0";
            this.OctTextBox.TextChanged += new System.EventHandler(this.OctTextBox_TextChanged);
            this.OctTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OctTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decimal";
            // 
            // DecTextBox
            // 
            this.DecTextBox.Location = new System.Drawing.Point(106, 68);
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(329, 22);
            this.DecTextBox.TabIndex = 1;
            this.DecTextBox.Text = "0";
            this.DecTextBox.TextChanged += new System.EventHandler(this.DecTextBox_TextChanged);
            this.DecTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hexadecimal";
            // 
            // HexTextBox
            // 
            this.HexTextBox.Location = new System.Drawing.Point(106, 96);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.Size = new System.Drawing.Size(329, 22);
            this.HexTextBox.TabIndex = 1;
            this.HexTextBox.Text = "0";
            this.HexTextBox.TextChanged += new System.EventHandler(this.HexTextBox_TextChanged);
            this.HexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 130);
            this.Controls.Add(this.HexTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OctTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BiTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Integer Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OctTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DecTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HexTextBox;
    }
}

