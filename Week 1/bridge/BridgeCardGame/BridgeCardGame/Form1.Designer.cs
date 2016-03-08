namespace BridgeCardGame
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
            this.Player1ListBox = new System.Windows.Forms.ListBox();
            this.Player2ListBox = new System.Windows.Forms.ListBox();
            this.Player3ListBox = new System.Windows.Forms.ListBox();
            this.Player4ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1ListBox
            // 
            this.Player1ListBox.FormattingEnabled = true;
            this.Player1ListBox.ItemHeight = 16;
            this.Player1ListBox.Location = new System.Drawing.Point(122, 26);
            this.Player1ListBox.Name = "Player1ListBox";
            this.Player1ListBox.Size = new System.Drawing.Size(119, 244);
            this.Player1ListBox.TabIndex = 0;
            // 
            // Player2ListBox
            // 
            this.Player2ListBox.FormattingEnabled = true;
            this.Player2ListBox.ItemHeight = 16;
            this.Player2ListBox.Location = new System.Drawing.Point(309, 26);
            this.Player2ListBox.Name = "Player2ListBox";
            this.Player2ListBox.Size = new System.Drawing.Size(120, 244);
            this.Player2ListBox.TabIndex = 1;
            // 
            // Player3ListBox
            // 
            this.Player3ListBox.FormattingEnabled = true;
            this.Player3ListBox.ItemHeight = 16;
            this.Player3ListBox.Location = new System.Drawing.Point(485, 26);
            this.Player3ListBox.Name = "Player3ListBox";
            this.Player3ListBox.Size = new System.Drawing.Size(118, 244);
            this.Player3ListBox.TabIndex = 2;
            // 
            // Player4ListBox
            // 
            this.Player4ListBox.FormattingEnabled = true;
            this.Player4ListBox.ItemHeight = 16;
            this.Player4ListBox.Location = new System.Drawing.Point(660, 26);
            this.Player4ListBox.Name = "Player4ListBox";
            this.Player4ListBox.Size = new System.Drawing.Size(120, 244);
            this.Player4ListBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 119);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Player4ListBox);
            this.Controls.Add(this.Player3ListBox);
            this.Controls.Add(this.Player2ListBox);
            this.Controls.Add(this.Player1ListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Player1ListBox;
        private System.Windows.Forms.ListBox Player2ListBox;
        private System.Windows.Forms.ListBox Player3ListBox;
        private System.Windows.Forms.ListBox Player4ListBox;
        private System.Windows.Forms.Button button1;
    }
}

