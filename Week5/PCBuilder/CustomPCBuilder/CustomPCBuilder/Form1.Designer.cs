namespace CustomPCBuilder
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
            this.gbMachines = new System.Windows.Forms.GroupBox();
            this.rbGaming = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbMultimedia = new System.Windows.Forms.RadioButton();
            this.btnDisplaySpec = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.gbMachines.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMachines
            // 
            this.gbMachines.Controls.Add(this.rbMultimedia);
            this.gbMachines.Controls.Add(this.rbBusiness);
            this.gbMachines.Controls.Add(this.rbGaming);
            this.gbMachines.Location = new System.Drawing.Point(29, 50);
            this.gbMachines.Name = "gbMachines";
            this.gbMachines.Size = new System.Drawing.Size(223, 229);
            this.gbMachines.TabIndex = 0;
            this.gbMachines.TabStop = false;
            this.gbMachines.Text = "Machine Types";
            // 
            // rbGaming
            // 
            this.rbGaming.AutoSize = true;
            this.rbGaming.Location = new System.Drawing.Point(48, 68);
            this.rbGaming.Name = "rbGaming";
            this.rbGaming.Size = new System.Drawing.Size(78, 21);
            this.rbGaming.TabIndex = 0;
            this.rbGaming.TabStop = true;
            this.rbGaming.Text = "Gaming";
            this.rbGaming.UseVisualStyleBackColor = true;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Location = new System.Drawing.Point(48, 122);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(86, 21);
            this.rbBusiness.TabIndex = 1;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbMultimedia
            // 
            this.rbMultimedia.AutoSize = true;
            this.rbMultimedia.Location = new System.Drawing.Point(48, 172);
            this.rbMultimedia.Name = "rbMultimedia";
            this.rbMultimedia.Size = new System.Drawing.Size(96, 21);
            this.rbMultimedia.TabIndex = 2;
            this.rbMultimedia.TabStop = true;
            this.rbMultimedia.Text = "Multimedia";
            this.rbMultimedia.UseVisualStyleBackColor = true;
            // 
            // btnDisplaySpec
            // 
            this.btnDisplaySpec.Location = new System.Drawing.Point(29, 322);
            this.btnDisplaySpec.Name = "btnDisplaySpec";
            this.btnDisplaySpec.Size = new System.Drawing.Size(223, 65);
            this.btnDisplaySpec.TabIndex = 3;
            this.btnDisplaySpec.Text = "Display Specs";
            this.btnDisplaySpec.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(321, 50);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(488, 337);
            this.rtbDisplay.TabIndex = 4;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 423);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnDisplaySpec);
            this.Controls.Add(this.gbMachines);
            this.Name = "Form1";
            this.Text = "PC Builder";
            this.gbMachines.ResumeLayout(false);
            this.gbMachines.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMachines;
        private System.Windows.Forms.RadioButton rbMultimedia;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbGaming;
        private System.Windows.Forms.Button btnDisplaySpec;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

