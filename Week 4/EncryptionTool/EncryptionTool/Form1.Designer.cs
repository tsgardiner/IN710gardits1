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
            this.rbROT13 = new System.Windows.Forms.RadioButton();
            this.rbReverse = new System.Windows.Forms.RadioButton();
            this.Encryptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(493, 128);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(96, 61);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(656, 128);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 61);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(144, 303);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(574, 22);
            this.tbInput.TabIndex = 4;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(144, 413);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(574, 22);
            this.tbOutput.TabIndex = 5;
            // 
            // Encryptions
            // 
            this.Encryptions.Controls.Add(this.rbReverse);
            this.Encryptions.Controls.Add(this.rbROT13);
            this.Encryptions.Location = new System.Drawing.Point(67, 83);
            this.Encryptions.Name = "Encryptions";
            this.Encryptions.Size = new System.Drawing.Size(254, 137);
            this.Encryptions.TabIndex = 6;
            this.Encryptions.TabStop = false;
            this.Encryptions.Text = "Encryptions";
            // 
            // rbROT13
            // 
            this.rbROT13.AutoSize = true;
            this.rbROT13.Location = new System.Drawing.Point(61, 36);
            this.rbROT13.Name = "rbROT13";
            this.rbROT13.Size = new System.Drawing.Size(75, 21);
            this.rbROT13.TabIndex = 0;
            this.rbROT13.TabStop = true;
            this.rbROT13.Text = "ROT13";
            this.rbROT13.UseVisualStyleBackColor = true;
            // 
            // rbReverse
            // 
            this.rbReverse.AutoSize = true;
            this.rbReverse.Location = new System.Drawing.Point(61, 74);
            this.rbReverse.Name = "rbReverse";
            this.rbReverse.Size = new System.Drawing.Size(123, 21);
            this.rbReverse.TabIndex = 1;
            this.rbReverse.TabStop = true;
            this.rbReverse.Text = "String Reverse";
            this.rbReverse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.Encryptions);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
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

