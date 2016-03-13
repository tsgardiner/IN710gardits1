namespace ClockApp
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
            this.components = new System.ComponentModel.Container();
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.lbDigitalDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.rbAnalog = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(82, 247);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(333, 333);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // lbDigitalDisplay
            // 
            this.lbDigitalDisplay.AutoSize = true;
            this.lbDigitalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDigitalDisplay.Location = new System.Drawing.Point(141, 390);
            this.lbDigitalDisplay.Name = "lbDigitalDisplay";
            this.lbDigitalDisplay.Size = new System.Drawing.Size(316, 53);
            this.lbDigitalDisplay.TabIndex = 1;
            this.lbDigitalDisplay.Text = "DigitalDisplay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDigital);
            this.groupBox1.Controls.Add(this.rbAnalog);
            this.groupBox1.Location = new System.Drawing.Point(48, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Types";
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(18, 92);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(84, 17);
            this.rbDigital.TabIndex = 1;
            this.rbDigital.Text = "Digital Clock";
            this.rbDigital.UseVisualStyleBackColor = true;
            // 
            // rbAnalog
            // 
            this.rbAnalog.AutoSize = true;
            this.rbAnalog.Checked = true;
            this.rbAnalog.Location = new System.Drawing.Point(18, 52);
            this.rbAnalog.Name = "rbAnalog";
            this.rbAnalog.Size = new System.Drawing.Size(88, 17);
            this.rbAnalog.TabIndex = 0;
            this.rbAnalog.TabStop = true;
            this.rbAnalog.Text = "Analog Clock";
            this.rbAnalog.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(253, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 51);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Clock";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(253, 159);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(204, 51);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Clock";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 612);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDigitalDisplay);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Digital / Analog Clocks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Label lbDigitalDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.RadioButton rbAnalog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

