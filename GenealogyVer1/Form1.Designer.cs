namespace GenealogyVer1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox_Person1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Person2 = new System.Windows.Forms.ComboBox();
            this.button_Match = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Person1
            // 
            this.comboBox_Person1.FormattingEnabled = true;
            this.comboBox_Person1.Location = new System.Drawing.Point(85, 142);
            this.comboBox_Person1.Name = "comboBox_Person1";
            this.comboBox_Person1.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Person1.TabIndex = 0;
            // 
            // comboBox_Person2
            // 
            this.comboBox_Person2.FormattingEnabled = true;
            this.comboBox_Person2.Location = new System.Drawing.Point(402, 140);
            this.comboBox_Person2.Name = "comboBox_Person2";
            this.comboBox_Person2.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Person2.TabIndex = 1;
            // 
            // button_Match
            // 
            this.button_Match.Location = new System.Drawing.Point(306, 140);
            this.button_Match.Name = "button_Match";
            this.button_Match.Size = new System.Drawing.Size(75, 23);
            this.button_Match.TabIndex = 2;
            this.button_Match.Text = "Match";
            this.button_Match.UseVisualStyleBackColor = true;
            this.button_Match.Click += new System.EventHandler(this.button_Match_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 477);
            this.Controls.Add(this.button_Match);
            this.Controls.Add(this.comboBox_Person2);
            this.Controls.Add(this.comboBox_Person1);
            this.Name = "Form1";
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_Person1;
        private System.Windows.Forms.ComboBox comboBox_Person2;
        private System.Windows.Forms.Button button_Match;
    }
}

