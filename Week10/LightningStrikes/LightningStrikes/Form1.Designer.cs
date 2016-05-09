namespace LightningStrikes
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
            this.btnThreeLargestFires = new System.Windows.Forms.Button();
            this.btnFireLightning = new System.Windows.Forms.Button();
            this.btnLatLongPicture = new System.Windows.Forms.Button();
            this.btnAvgAllStrikes = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnThreeLargestFires
            // 
            this.btnThreeLargestFires.Location = new System.Drawing.Point(48, 99);
            this.btnThreeLargestFires.Name = "btnThreeLargestFires";
            this.btnThreeLargestFires.Size = new System.Drawing.Size(154, 45);
            this.btnThreeLargestFires.TabIndex = 1;
            this.btnThreeLargestFires.Text = "Three Largest Fires";
            this.btnThreeLargestFires.UseVisualStyleBackColor = true;
            this.btnThreeLargestFires.Click += new System.EventHandler(this.btnThreeLargestFires_Click);
            // 
            // btnFireLightning
            // 
            this.btnFireLightning.Location = new System.Drawing.Point(48, 238);
            this.btnFireLightning.Name = "btnFireLightning";
            this.btnFireLightning.Size = new System.Drawing.Size(154, 45);
            this.btnFireLightning.TabIndex = 2;
            this.btnFireLightning.Text = "Fire cause by Lightning";
            this.btnFireLightning.UseVisualStyleBackColor = true;
            this.btnFireLightning.Click += new System.EventHandler(this.btnFireLightning_Click);
            // 
            // btnLatLongPicture
            // 
            this.btnLatLongPicture.Location = new System.Drawing.Point(48, 170);
            this.btnLatLongPicture.Name = "btnLatLongPicture";
            this.btnLatLongPicture.Size = new System.Drawing.Size(154, 45);
            this.btnLatLongPicture.TabIndex = 3;
            this.btnLatLongPicture.Text = "Latitude / Longitude for Pictures";
            this.btnLatLongPicture.UseVisualStyleBackColor = true;
            this.btnLatLongPicture.Click += new System.EventHandler(this.btnLatLongPicture_Click);
            // 
            // btnAvgAllStrikes
            // 
            this.btnAvgAllStrikes.Location = new System.Drawing.Point(48, 30);
            this.btnAvgAllStrikes.Name = "btnAvgAllStrikes";
            this.btnAvgAllStrikes.Size = new System.Drawing.Size(154, 45);
            this.btnAvgAllStrikes.TabIndex = 0;
            this.btnAvgAllStrikes.Text = "Average Intensity for All Strikes";
            this.btnAvgAllStrikes.UseVisualStyleBackColor = true;
            this.btnAvgAllStrikes.Click += new System.EventHandler(this.btnAvgAllStrikes_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(277, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 574);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 635);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLatLongPicture);
            this.Controls.Add(this.btnFireLightning);
            this.Controls.Add(this.btnThreeLargestFires);
            this.Controls.Add(this.btnAvgAllStrikes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThreeLargestFires;
        private System.Windows.Forms.Button btnFireLightning;
        private System.Windows.Forms.Button btnLatLongPicture;
        private System.Windows.Forms.Button btnAvgAllStrikes;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

