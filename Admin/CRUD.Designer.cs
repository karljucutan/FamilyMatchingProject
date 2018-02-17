namespace Admin
{
    partial class CRUD
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
            this.tabControl_CUD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_AddPerson = new System.Windows.Forms.Button();
            this.radioButton_Add_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Add_Male = new System.Windows.Forms.RadioButton();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_AddPerson = new System.Windows.Forms.Label();
            this.textBox_Add_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_Update_Name = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.radioButton_Update_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Update_Male = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Update = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox_Delete_Name = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_SecondToFirstRelationship = new System.Windows.Forms.Label();
            this.label_FirstToSecondRelationship = new System.Windows.Forms.Label();
            this.button_Match = new System.Windows.Forms.Button();
            this.comboBox_Person2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Person1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Update_FatherName = new System.Windows.Forms.ComboBox();
            this.comboBox_Update_MotherName = new System.Windows.Forms.ComboBox();
            this.comboBox_Update_SpouseName = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_CUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_CUD
            // 
            this.tabControl_CUD.Controls.Add(this.tabPage1);
            this.tabControl_CUD.Controls.Add(this.tabPage2);
            this.tabControl_CUD.Controls.Add(this.tabPage3);
            this.tabControl_CUD.Controls.Add(this.tabPage4);
            this.tabControl_CUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_CUD.Location = new System.Drawing.Point(0, 0);
            this.tabControl_CUD.Name = "tabControl_CUD";
            this.tabControl_CUD.SelectedIndex = 0;
            this.tabControl_CUD.Size = new System.Drawing.Size(680, 304);
            this.tabControl_CUD.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_AddPerson);
            this.tabPage1.Controls.Add(this.radioButton_Add_Female);
            this.tabPage1.Controls.Add(this.radioButton_Add_Male);
            this.tabPage1.Controls.Add(this.label_Gender);
            this.tabPage1.Controls.Add(this.label_Name);
            this.tabPage1.Controls.Add(this.label_AddPerson);
            this.tabPage1.Controls.Add(this.textBox_Add_Name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_AddPerson
            // 
            this.button_AddPerson.Location = new System.Drawing.Point(308, 227);
            this.button_AddPerson.Name = "button_AddPerson";
            this.button_AddPerson.Size = new System.Drawing.Size(75, 23);
            this.button_AddPerson.TabIndex = 13;
            this.button_AddPerson.Text = "Add";
            this.button_AddPerson.UseVisualStyleBackColor = true;
            this.button_AddPerson.Click += new System.EventHandler(this.button_AddPerson_Click);
            // 
            // radioButton_Add_Female
            // 
            this.radioButton_Add_Female.AutoSize = true;
            this.radioButton_Add_Female.Location = new System.Drawing.Point(207, 108);
            this.radioButton_Add_Female.Name = "radioButton_Add_Female";
            this.radioButton_Add_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Add_Female.TabIndex = 12;
            this.radioButton_Add_Female.TabStop = true;
            this.radioButton_Add_Female.Text = "Female";
            this.radioButton_Add_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Add_Male
            // 
            this.radioButton_Add_Male.AutoSize = true;
            this.radioButton_Add_Male.Location = new System.Drawing.Point(153, 108);
            this.radioButton_Add_Male.Name = "radioButton_Add_Male";
            this.radioButton_Add_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Add_Male.TabIndex = 11;
            this.radioButton_Add_Male.TabStop = true;
            this.radioButton_Add_Male.Text = "Male";
            this.radioButton_Add_Male.UseVisualStyleBackColor = true;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(73, 108);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(45, 13);
            this.label_Gender.TabIndex = 10;
            this.label_Gender.Text = "Gender:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(73, 82);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 13);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name: ";
            // 
            // label_AddPerson
            // 
            this.label_AddPerson.AutoSize = true;
            this.label_AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPerson.Location = new System.Drawing.Point(289, 23);
            this.label_AddPerson.Name = "label_AddPerson";
            this.label_AddPerson.Size = new System.Drawing.Size(92, 20);
            this.label_AddPerson.TabIndex = 1;
            this.label_AddPerson.Text = "Add Person";
            // 
            // textBox_Add_Name
            // 
            this.textBox_Add_Name.Location = new System.Drawing.Point(153, 79);
            this.textBox_Add_Name.Name = "textBox_Add_Name";
            this.textBox_Add_Name.Size = new System.Drawing.Size(333, 20);
            this.textBox_Add_Name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_Update_SpouseName);
            this.tabPage2.Controls.Add(this.comboBox_Update_MotherName);
            this.tabPage2.Controls.Add(this.comboBox_Update_FatherName);
            this.tabPage2.Controls.Add(this.comboBox_Update_Name);
            this.tabPage2.Controls.Add(this.button_Update);
            this.tabPage2.Controls.Add(this.radioButton_Update_Female);
            this.tabPage2.Controls.Add(this.radioButton_Update_Male);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label_Update);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_Update_Name
            // 
            this.comboBox_Update_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Update_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Update_Name.FormattingEnabled = true;
            this.comboBox_Update_Name.Location = new System.Drawing.Point(153, 79);
            this.comboBox_Update_Name.Name = "comboBox_Update_Name";
            this.comboBox_Update_Name.Size = new System.Drawing.Size(333, 21);
            this.comboBox_Update_Name.TabIndex = 27;
            this.comboBox_Update_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox_Update_Name_SelectedIndexChanged);
            // 
            // button_Update
            // 
            this.button_Update.Enabled = false;
            this.button_Update.Location = new System.Drawing.Point(308, 227);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 26;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // radioButton_Update_Female
            // 
            this.radioButton_Update_Female.AutoSize = true;
            this.radioButton_Update_Female.Enabled = false;
            this.radioButton_Update_Female.Location = new System.Drawing.Point(207, 108);
            this.radioButton_Update_Female.Name = "radioButton_Update_Female";
            this.radioButton_Update_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Update_Female.TabIndex = 25;
            this.radioButton_Update_Female.Text = "Female";
            this.radioButton_Update_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Update_Male
            // 
            this.radioButton_Update_Male.AutoSize = true;
            this.radioButton_Update_Male.Checked = true;
            this.radioButton_Update_Male.Enabled = false;
            this.radioButton_Update_Male.Location = new System.Drawing.Point(153, 108);
            this.radioButton_Update_Male.Name = "radioButton_Update_Male";
            this.radioButton_Update_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Update_Male.TabIndex = 24;
            this.radioButton_Update_Male.TabStop = true;
            this.radioButton_Update_Male.Text = "Male";
            this.radioButton_Update_Male.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Spouse Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mother Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Father Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name: ";
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Update.Location = new System.Drawing.Point(289, 23);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(116, 20);
            this.label_Update.TabIndex = 15;
            this.label_Update.Text = "Update Person";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox_Delete_Name);
            this.tabPage3.Controls.Add(this.button_Delete);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(672, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox_Delete_Name
            // 
            this.comboBox_Delete_Name.AutoCompleteCustomSource.AddRange(new string[] {
            "Kealu"});
            this.comboBox_Delete_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Delete_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Delete_Name.FormattingEnabled = true;
            this.comboBox_Delete_Name.Location = new System.Drawing.Point(153, 79);
            this.comboBox_Delete_Name.Name = "comboBox_Delete_Name";
            this.comboBox_Delete_Name.Size = new System.Drawing.Size(333, 21);
            this.comboBox_Delete_Name.TabIndex = 40;
            this.comboBox_Delete_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox_Delete_Name_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.Enabled = false;
            this.button_Delete.Location = new System.Drawing.Point(308, 227);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 39;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Name: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Delete Person";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.pictureBox3);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label_SecondToFirstRelationship);
            this.tabPage4.Controls.Add(this.label_FirstToSecondRelationship);
            this.tabPage4.Controls.Add(this.button_Match);
            this.tabPage4.Controls.Add(this.comboBox_Person2);
            this.tabPage4.Controls.Add(this.comboBox_Person1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(672, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Match";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_SecondToFirstRelationship
            // 
            this.label_SecondToFirstRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SecondToFirstRelationship.Location = new System.Drawing.Point(244, 157);
            this.label_SecondToFirstRelationship.Name = "label_SecondToFirstRelationship";
            this.label_SecondToFirstRelationship.Size = new System.Drawing.Size(200, 48);
            this.label_SecondToFirstRelationship.TabIndex = 7;
            this.label_SecondToFirstRelationship.Text = "Relationship";
            this.label_SecondToFirstRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FirstToSecondRelationship
            // 
            this.label_FirstToSecondRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstToSecondRelationship.Location = new System.Drawing.Point(244, 70);
            this.label_FirstToSecondRelationship.Name = "label_FirstToSecondRelationship";
            this.label_FirstToSecondRelationship.Size = new System.Drawing.Size(200, 50);
            this.label_FirstToSecondRelationship.TabIndex = 6;
            this.label_FirstToSecondRelationship.Text = "Relationship";
            this.label_FirstToSecondRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Match
            // 
            this.button_Match.Location = new System.Drawing.Point(299, 128);
            this.button_Match.Name = "button_Match";
            this.button_Match.Size = new System.Drawing.Size(75, 23);
            this.button_Match.TabIndex = 5;
            this.button_Match.Text = "Match";
            this.button_Match.UseVisualStyleBackColor = true;
            this.button_Match.Click += new System.EventHandler(this.button_Match_Click);
            // 
            // comboBox_Person2
            // 
            this.comboBox_Person2.FormattingEnabled = true;
            this.comboBox_Person2.Location = new System.Drawing.Point(395, 128);
            this.comboBox_Person2.Name = "comboBox_Person2";
            this.comboBox_Person2.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Person2.TabIndex = 4;
            // 
            // comboBox_Person1
            // 
            this.comboBox_Person1.FormattingEnabled = true;
            this.comboBox_Person1.Location = new System.Drawing.Point(78, 130);
            this.comboBox_Person1.Name = "comboBox_Person1";
            this.comboBox_Person1.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Person1.TabIndex = 3;
            // 
            // comboBox_Update_FatherName
            // 
            this.comboBox_Update_FatherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Update_FatherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Update_FatherName.Enabled = false;
            this.comboBox_Update_FatherName.FormattingEnabled = true;
            this.comboBox_Update_FatherName.Location = new System.Drawing.Point(153, 131);
            this.comboBox_Update_FatherName.Name = "comboBox_Update_FatherName";
            this.comboBox_Update_FatherName.Size = new System.Drawing.Size(333, 21);
            this.comboBox_Update_FatherName.TabIndex = 28;
            // 
            // comboBox_Update_MotherName
            // 
            this.comboBox_Update_MotherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Update_MotherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Update_MotherName.Enabled = false;
            this.comboBox_Update_MotherName.FormattingEnabled = true;
            this.comboBox_Update_MotherName.Location = new System.Drawing.Point(153, 157);
            this.comboBox_Update_MotherName.Name = "comboBox_Update_MotherName";
            this.comboBox_Update_MotherName.Size = new System.Drawing.Size(333, 21);
            this.comboBox_Update_MotherName.TabIndex = 29;
            // 
            // comboBox_Update_SpouseName
            // 
            this.comboBox_Update_SpouseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Update_SpouseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Update_SpouseName.Enabled = false;
            this.comboBox_Update_SpouseName.FormattingEnabled = true;
            this.comboBox_Update_SpouseName.Location = new System.Drawing.Point(153, 183);
            this.comboBox_Update_SpouseName.Name = "comboBox_Update_SpouseName";
            this.comboBox_Update_SpouseName.Size = new System.Drawing.Size(333, 21);
            this.comboBox_Update_SpouseName.TabIndex = 30;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Admin.Properties.Resources.Arrow3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(450, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Admin.Properties.Resources.Arrow4;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(138, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Admin.Properties.Resources.Arrow2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(450, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 52);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Admin.Properties.Resources.Arrow1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(138, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 304);
            this.Controls.Add(this.tabControl_CUD);
            this.Name = "CUD";
            this.Text = "FamilyTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_CUD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_CUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_AddPerson;
        private System.Windows.Forms.TextBox textBox_Add_Name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.RadioButton radioButton_Add_Female;
        private System.Windows.Forms.RadioButton radioButton_Add_Male;
        private System.Windows.Forms.Button button_AddPerson;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.RadioButton radioButton_Update_Female;
        private System.Windows.Forms.RadioButton radioButton_Update_Male;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_Update_Name;
        private System.Windows.Forms.ComboBox comboBox_Delete_Name;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_Match;
        private System.Windows.Forms.ComboBox comboBox_Person2;
        private System.Windows.Forms.ComboBox comboBox_Person1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_SecondToFirstRelationship;
        private System.Windows.Forms.Label label_FirstToSecondRelationship;
        private System.Windows.Forms.ComboBox comboBox_Update_SpouseName;
        private System.Windows.Forms.ComboBox comboBox_Update_MotherName;
        private System.Windows.Forms.ComboBox comboBox_Update_FatherName;
    }
}

