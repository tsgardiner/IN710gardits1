namespace PredicateLab
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
            this.lbRandoms = new System.Windows.Forms.ListBox();
            this.lbDisplaySelected = new System.Windows.Forms.ListBox();
            this.btnGenRandoms = new System.Windows.Forms.Button();
            this.btnEvenNums = new System.Windows.Forms.Button();
            this.btnLessThanTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRandoms
            // 
            this.lbRandoms.FormattingEnabled = true;
            this.lbRandoms.Location = new System.Drawing.Point(36, 164);
            this.lbRandoms.Name = "lbRandoms";
            this.lbRandoms.Size = new System.Drawing.Size(131, 290);
            this.lbRandoms.TabIndex = 0;
            // 
            // lbDisplaySelected
            // 
            this.lbDisplaySelected.FormattingEnabled = true;
            this.lbDisplaySelected.Location = new System.Drawing.Point(228, 164);
            this.lbDisplaySelected.Name = "lbDisplaySelected";
            this.lbDisplaySelected.Size = new System.Drawing.Size(131, 290);
            this.lbDisplaySelected.TabIndex = 1;
            // 
            // btnGenRandoms
            // 
            this.btnGenRandoms.Location = new System.Drawing.Point(36, 34);
            this.btnGenRandoms.Name = "btnGenRandoms";
            this.btnGenRandoms.Size = new System.Drawing.Size(131, 91);
            this.btnGenRandoms.TabIndex = 2;
            this.btnGenRandoms.Text = "Generate Randoms";
            this.btnGenRandoms.UseVisualStyleBackColor = true;
            this.btnGenRandoms.Click += new System.EventHandler(this.btnGenRandoms_Click);
            // 
            // btnEvenNums
            // 
            this.btnEvenNums.Location = new System.Drawing.Point(228, 34);
            this.btnEvenNums.Name = "btnEvenNums";
            this.btnEvenNums.Size = new System.Drawing.Size(131, 35);
            this.btnEvenNums.TabIndex = 3;
            this.btnEvenNums.Text = "Select Even Numbers";
            this.btnEvenNums.UseVisualStyleBackColor = true;
            this.btnEvenNums.Click += new System.EventHandler(this.btnEvenNums_Click);
            // 
            // btnLessThanTen
            // 
            this.btnLessThanTen.Location = new System.Drawing.Point(228, 90);
            this.btnLessThanTen.Name = "btnLessThanTen";
            this.btnLessThanTen.Size = new System.Drawing.Size(131, 35);
            this.btnLessThanTen.TabIndex = 4;
            this.btnLessThanTen.Text = "Select Numbers < 10";
            this.btnLessThanTen.UseVisualStyleBackColor = true;
            this.btnLessThanTen.Click += new System.EventHandler(this.btnLessThanTen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 494);
            this.Controls.Add(this.btnLessThanTen);
            this.Controls.Add(this.btnEvenNums);
            this.Controls.Add(this.btnGenRandoms);
            this.Controls.Add(this.lbDisplaySelected);
            this.Controls.Add(this.lbRandoms);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predicate Lab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRandoms;
        private System.Windows.Forms.ListBox lbDisplaySelected;
        private System.Windows.Forms.Button btnGenRandoms;
        private System.Windows.Forms.Button btnEvenNums;
        private System.Windows.Forms.Button btnLessThanTen;
    }
}

