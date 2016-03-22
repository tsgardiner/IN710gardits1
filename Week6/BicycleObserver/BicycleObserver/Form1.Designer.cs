namespace BicycleObserver
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
            this.btnChangeSpeed = new System.Windows.Forms.Button();
            this.tbInputSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDisplayRPM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCalPerHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbKPH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeSpeed
            // 
            this.btnChangeSpeed.Location = new System.Drawing.Point(12, 27);
            this.btnChangeSpeed.Name = "btnChangeSpeed";
            this.btnChangeSpeed.Size = new System.Drawing.Size(145, 98);
            this.btnChangeSpeed.TabIndex = 0;
            this.btnChangeSpeed.Text = "Change Speed";
            this.btnChangeSpeed.UseVisualStyleBackColor = true;
            this.btnChangeSpeed.Click += new System.EventHandler(this.btnChangeSpeed_Click);
            // 
            // tbInputSpeed
            // 
            this.tbInputSpeed.Location = new System.Drawing.Point(210, 37);
            this.tbInputSpeed.Name = "tbInputSpeed";
            this.tbInputSpeed.Size = new System.Drawing.Size(145, 22);
            this.tbInputSpeed.TabIndex = 1;
            this.tbInputSpeed.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 271);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RPM";
            // 
            // lbDisplayRPM
            // 
            this.lbDisplayRPM.AutoSize = true;
            this.lbDisplayRPM.Location = new System.Drawing.Point(321, 271);
            this.lbDisplayRPM.Name = "lbDisplayRPM";
            this.lbDisplayRPM.Size = new System.Drawing.Size(28, 17);
            this.lbDisplayRPM.TabIndex = 3;
            this.lbDisplayRPM.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories Per Hour";
            // 
            // lbCalPerHour
            // 
            this.lbCalPerHour.AutoSize = true;
            this.lbCalPerHour.Location = new System.Drawing.Point(321, 425);
            this.lbCalPerHour.Name = "lbCalPerHour";
            this.lbCalPerHour.Size = new System.Drawing.Size(28, 17);
            this.lbCalPerHour.TabIndex = 5;
            this.lbCalPerHour.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kms Per Hour";
            // 
            // lbKPH
            // 
            this.lbKPH.AutoSize = true;
            this.lbKPH.Location = new System.Drawing.Point(321, 606);
            this.lbKPH.Name = "lbKPH";
            this.lbKPH.Size = new System.Drawing.Size(28, 17);
            this.lbKPH.TabIndex = 7;
            this.lbKPH.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 715);
            this.Controls.Add(this.lbKPH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCalPerHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDisplayRPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInputSpeed);
            this.Controls.Add(this.btnChangeSpeed);
            this.Name = "Form1";
            this.Text = "Bicyle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeSpeed;
        private System.Windows.Forms.TextBox tbInputSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDisplayRPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCalPerHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbKPH;
    }
}

