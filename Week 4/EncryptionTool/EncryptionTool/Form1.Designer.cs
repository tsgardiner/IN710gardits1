namespace EncryptionTool
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.Encryptions = new System.Windows.Forms.GroupBox();
            this.rbReverse = new System.Windows.Forms.RadioButton();
            this.rbROT13 = new System.Windows.Forms.RadioButton();
            this.Encryptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(370, 104);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(72, 50);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(492, 104);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(80, 50);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(108, 246);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(432, 20);
            this.tbInput.TabIndex = 4;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(108, 336);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(432, 20);
            this.tbOutput.TabIndex = 5;
            // 
            // Encryptions
            // 
            this.Encryptions.Controls.Add(this.rbReverse);
            this.Encryptions.Controls.Add(this.rbROT13);
            this.Encryptions.Location = new System.Drawing.Point(50, 67);
            this.Encryptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Encryptions.Name = "Encryptions";
            this.Encryptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Encryptions.Size = new System.Drawing.Size(190, 111);
            this.Encryptions.TabIndex = 6;
            this.Encryptions.TabStop = false;
            this.Encryptions.Text = "Encryptions";
            // 
            // rbReverse
            // 
            this.rbReverse.AutoSize = true;
            this.rbReverse.Location = new System.Drawing.Point(46, 60);
            this.rbReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbReverse.Name = "rbReverse";
            this.rbReverse.Size = new System.Drawing.Size(95, 17);
            this.rbReverse.TabIndex = 1;
            this.rbReverse.TabStop = true;
            this.rbReverse.Text = "String Reverse";
            this.rbReverse.UseVisualStyleBackColor = true;
            // 
            // rbROT13
            // 
            this.rbROT13.AutoSize = true;
            this.rbROT13.Location = new System.Drawing.Point(46, 29);
            this.rbROT13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbROT13.Name = "rbROT13";
            this.rbROT13.Size = new System.Drawing.Size(60, 17);
            this.rbROT13.TabIndex = 0;
            this.rbROT13.TabStop = true;
            this.rbROT13.Text = "ROT13";
            this.rbROT13.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.Encryptions);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Code Machine";
            this.Encryptions.ResumeLayout(false);
            this.Encryptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.GroupBox Encryptions;
        private System.Windows.Forms.RadioButton rbReverse;
        private System.Windows.Forms.RadioButton rbROT13;
    }
}

