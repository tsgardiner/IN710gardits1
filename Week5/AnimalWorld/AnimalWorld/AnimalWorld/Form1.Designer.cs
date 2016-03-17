namespace AnimalWorld
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
            this.rtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnNorthAmerica = new System.Windows.Forms.Button();
            this.btnAus = new System.Windows.Forms.Button();
            this.btnAfrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtDisplay
            // 
            this.rtDisplay.Location = new System.Drawing.Point(476, 12);
            this.rtDisplay.Name = "rtDisplay";
            this.rtDisplay.Size = new System.Drawing.Size(552, 596);
            this.rtDisplay.TabIndex = 0;
            this.rtDisplay.Text = "";
            // 
            // btnNorthAmerica
            // 
            this.btnNorthAmerica.Location = new System.Drawing.Point(890, 657);
            this.btnNorthAmerica.Name = "btnNorthAmerica";
            this.btnNorthAmerica.Size = new System.Drawing.Size(138, 47);
            this.btnNorthAmerica.TabIndex = 1;
            this.btnNorthAmerica.Text = "North America";
            this.btnNorthAmerica.UseVisualStyleBackColor = true;
            this.btnNorthAmerica.Click += new System.EventHandler(this.btnNorthAmerica_Click);
            // 
            // btnAus
            // 
            this.btnAus.Location = new System.Drawing.Point(476, 657);
            this.btnAus.Name = "btnAus";
            this.btnAus.Size = new System.Drawing.Size(138, 47);
            this.btnAus.TabIndex = 2;
            this.btnAus.Text = "Austraila";
            this.btnAus.UseVisualStyleBackColor = true;
            this.btnAus.Click += new System.EventHandler(this.btnAus_Click);
            // 
            // btnAfrica
            // 
            this.btnAfrica.Location = new System.Drawing.Point(677, 657);
            this.btnAfrica.Name = "btnAfrica";
            this.btnAfrica.Size = new System.Drawing.Size(138, 47);
            this.btnAfrica.TabIndex = 3;
            this.btnAfrica.Text = "Africa";
            this.btnAfrica.UseVisualStyleBackColor = true;
            this.btnAfrica.Click += new System.EventHandler(this.btnAfrica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 746);
            this.Controls.Add(this.btnAfrica);
            this.Controls.Add(this.btnAus);
            this.Controls.Add(this.btnNorthAmerica);
            this.Controls.Add(this.rtDisplay);
            this.Name = "Form1";
            this.Text = "Animal World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDisplay;
        private System.Windows.Forms.Button btnNorthAmerica;
        private System.Windows.Forms.Button btnAus;
        private System.Windows.Forms.Button btnAfrica;
    }
}

