namespace ProgressIndicator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.rbSpinBox = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrackBar);
            this.groupBox1.Controls.Add(this.rbProgressBar);
            this.groupBox1.Controls.Add(this.rbSpinBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indicators";
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Location = new System.Drawing.Point(11, 116);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rbTrackBar.TabIndex = 2;
            this.rbTrackBar.TabStop = true;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Location = new System.Drawing.Point(11, 73);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rbProgressBar.TabIndex = 1;
            this.rbProgressBar.TabStop = true;
            this.rbProgressBar.Text = "Progress Bar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbSpinBox
            // 
            this.rbSpinBox.AutoSize = true;
            this.rbSpinBox.Location = new System.Drawing.Point(11, 35);
            this.rbSpinBox.Name = "rbSpinBox";
            this.rbSpinBox.Size = new System.Drawing.Size(67, 17);
            this.rbSpinBox.TabIndex = 0;
            this.rbSpinBox.TabStop = true;
            this.rbSpinBox.Text = "Spin Box";
            this.rbSpinBox.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(232, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(332, 22);
            this.progressBar1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(232, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(232, 133);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(332, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 192);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress Indicator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbSpinBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

