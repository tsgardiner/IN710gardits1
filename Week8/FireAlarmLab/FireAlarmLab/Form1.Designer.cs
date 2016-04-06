namespace FireAlarmLab
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
            this.rbFireAlarm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInferno = new System.Windows.Forms.RadioButton();
            this.rbSerious = new System.Windows.Forms.RadioButton();
            this.rbMinor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbFireAlarm
            // 
            this.rbFireAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFireAlarm.Location = new System.Drawing.Point(12, 273);
            this.rbFireAlarm.Name = "rbFireAlarm";
            this.rbFireAlarm.Size = new System.Drawing.Size(241, 70);
            this.rbFireAlarm.TabIndex = 0;
            this.rbFireAlarm.Text = "Fire Alarm";
            this.rbFireAlarm.UseVisualStyleBackColor = true;
            this.rbFireAlarm.Click += new System.EventHandler(this.rbFireAlarm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInferno);
            this.groupBox1.Controls.Add(this.rbSerious);
            this.groupBox1.Controls.Add(this.rbMinor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // rbInferno
            // 
            this.rbInferno.AutoSize = true;
            this.rbInferno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInferno.Location = new System.Drawing.Point(60, 187);
            this.rbInferno.Name = "rbInferno";
            this.rbInferno.Size = new System.Drawing.Size(105, 33);
            this.rbInferno.TabIndex = 2;
            this.rbInferno.TabStop = true;
            this.rbInferno.Text = "Inferno";
            this.rbInferno.UseVisualStyleBackColor = true;
            // 
            // rbSerious
            // 
            this.rbSerious.AutoSize = true;
            this.rbSerious.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSerious.Location = new System.Drawing.Point(60, 114);
            this.rbSerious.Name = "rbSerious";
            this.rbSerious.Size = new System.Drawing.Size(114, 33);
            this.rbSerious.TabIndex = 1;
            this.rbSerious.TabStop = true;
            this.rbSerious.Text = "Serious";
            this.rbSerious.UseVisualStyleBackColor = true;
            // 
            // rbMinor
            // 
            this.rbMinor.AutoSize = true;
            this.rbMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinor.Location = new System.Drawing.Point(60, 43);
            this.rbMinor.Name = "rbMinor";
            this.rbMinor.Size = new System.Drawing.Size(92, 33);
            this.rbMinor.TabIndex = 0;
            this.rbMinor.TabStop = true;
            this.rbMinor.Text = "Minor";
            this.rbMinor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbFireAlarm);
            this.Name = "Form1";
            this.Text = "Fire Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rbFireAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInferno;
        private System.Windows.Forms.RadioButton rbSerious;
        private System.Windows.Forms.RadioButton rbMinor;
    }
}

