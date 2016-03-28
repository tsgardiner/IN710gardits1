namespace WeatherPatternsObserver
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbTemperature = new System.Windows.Forms.RichTextBox();
            this.rtbAvgReadings = new System.Windows.Forms.RichTextBox();
            this.rtbForecast = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 91);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(74, 119);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(113, 22);
            this.tbTemperature.TabIndex = 1;
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(74, 296);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(113, 22);
            this.tbPressure.TabIndex = 2;
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(74, 201);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(113, 22);
            this.tbHumidity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperature (C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Humidity (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pressure (Bar)";
            // 
            // rtbTemperature
            // 
            this.rtbTemperature.Location = new System.Drawing.Point(348, 50);
            this.rtbTemperature.Name = "rtbTemperature";
            this.rtbTemperature.Size = new System.Drawing.Size(430, 127);
            this.rtbTemperature.TabIndex = 7;
            this.rtbTemperature.Text = "";
            // 
            // rtbAvgReadings
            // 
            this.rtbAvgReadings.Location = new System.Drawing.Point(348, 237);
            this.rtbAvgReadings.Name = "rtbAvgReadings";
            this.rtbAvgReadings.Size = new System.Drawing.Size(430, 127);
            this.rtbAvgReadings.TabIndex = 8;
            this.rtbAvgReadings.Text = "";
            // 
            // rtbForecast
            // 
            this.rtbForecast.Location = new System.Drawing.Point(348, 422);
            this.rtbForecast.Name = "rtbForecast";
            this.rtbForecast.Size = new System.Drawing.Size(430, 127);
            this.rtbForecast.TabIndex = 9;
            this.rtbForecast.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temperature (C)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Readings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Forecast";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 607);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbForecast);
            this.Controls.Add(this.rtbAvgReadings);
            this.Controls.Add(this.rtbTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbTemperature;
        private System.Windows.Forms.RichTextBox rtbAvgReadings;
        private System.Windows.Forms.RichTextBox rtbForecast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

