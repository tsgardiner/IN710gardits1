namespace QuizNight
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
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.btnScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdult);
            this.groupBox1.Controls.Add(this.rbChild);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team";
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(36, 44);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(49, 17);
            this.rbAdult.TabIndex = 2;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(36, 84);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(48, 17);
            this.rbChild.TabIndex = 3;
            this.rbChild.TabStop = true;
            this.rbChild.Text = "Child";
            this.rbChild.UseVisualStyleBackColor = true;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(400, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(88, 124);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Get Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correct Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incorrect Answers";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(563, 63);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(51, 20);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 159);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quiz Scorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbScore;
    }
}

