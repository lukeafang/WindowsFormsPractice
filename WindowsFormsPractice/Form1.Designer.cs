namespace WindowsFormsPractice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxSheet3Fruit = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSheet2 = new System.Windows.Forms.PictureBox();
            this.btnSheet2Load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSheet1Submit = new System.Windows.Forms.Button();
            this.dateTimePickerSheet1 = new System.Windows.Forms.DateTimePicker();
            this.lblSheet1Age = new System.Windows.Forms.Label();
            this.chkSheet1Java = new System.Windows.Forms.CheckBox();
            this.cbSheet1AgeRange = new System.Windows.Forms.ComboBox();
            this.chkSheet1CSharp = new System.Windows.Forms.CheckBox();
            this.chkSheet1CPlus = new System.Windows.Forms.CheckBox();
            this.lblSheet1Skill = new System.Windows.Forms.Label();
            this.radioSheet1Female = new System.Windows.Forms.RadioButton();
            this.radioSheet1Male = new System.Windows.Forms.RadioButton();
            this.lblSheet1Gender = new System.Windows.Forms.Label();
            this.txtSheet1Name = new System.Windows.Forms.TextBox();
            this.lblSheet1Name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dbConnectBtn = new System.Windows.Forms.Button();
            this.dbConnectSelectBtn = new System.Windows.Forms.Button();
            this.dbConnectCreateTableBtn = new System.Windows.Forms.Button();
            this.dbConnectDropTableBtn = new System.Windows.Forms.Button();
            this.dbConnectInsertBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Controller";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxSheet3Fruit);
            this.groupBox3.Location = new System.Drawing.Point(241, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sheet3";
            // 
            // listBoxSheet3Fruit
            // 
            this.listBoxSheet3Fruit.FormattingEnabled = true;
            this.listBoxSheet3Fruit.ItemHeight = 12;
            this.listBoxSheet3Fruit.Items.AddRange(new object[] {
            "Banana",
            "Apple",
            "Strawberry",
            "Orange"});
            this.listBoxSheet3Fruit.Location = new System.Drawing.Point(6, 17);
            this.listBoxSheet3Fruit.Name = "listBoxSheet3Fruit";
            this.listBoxSheet3Fruit.Size = new System.Drawing.Size(113, 88);
            this.listBoxSheet3Fruit.TabIndex = 0;
            this.listBoxSheet3Fruit.DoubleClick += new System.EventHandler(this.listBoxSheet3Fruit_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxSheet2);
            this.groupBox2.Controls.Add(this.btnSheet2Load);
            this.groupBox2.Location = new System.Drawing.Point(7, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sheet2";
            // 
            // pictureBoxSheet2
            // 
            this.pictureBoxSheet2.Location = new System.Drawing.Point(7, 55);
            this.pictureBoxSheet2.Name = "pictureBoxSheet2";
            this.pictureBoxSheet2.Size = new System.Drawing.Size(215, 136);
            this.pictureBoxSheet2.TabIndex = 1;
            this.pictureBoxSheet2.TabStop = false;
            // 
            // btnSheet2Load
            // 
            this.btnSheet2Load.Location = new System.Drawing.Point(7, 22);
            this.btnSheet2Load.Name = "btnSheet2Load";
            this.btnSheet2Load.Size = new System.Drawing.Size(63, 26);
            this.btnSheet2Load.TabIndex = 0;
            this.btnSheet2Load.Text = "Load";
            this.btnSheet2Load.UseVisualStyleBackColor = true;
            this.btnSheet2Load.Click += new System.EventHandler(this.btnSheet2Load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSheet1Submit);
            this.groupBox1.Controls.Add(this.dateTimePickerSheet1);
            this.groupBox1.Controls.Add(this.lblSheet1Age);
            this.groupBox1.Controls.Add(this.chkSheet1Java);
            this.groupBox1.Controls.Add(this.cbSheet1AgeRange);
            this.groupBox1.Controls.Add(this.chkSheet1CSharp);
            this.groupBox1.Controls.Add(this.chkSheet1CPlus);
            this.groupBox1.Controls.Add(this.lblSheet1Skill);
            this.groupBox1.Controls.Add(this.radioSheet1Female);
            this.groupBox1.Controls.Add(this.radioSheet1Male);
            this.groupBox1.Controls.Add(this.lblSheet1Gender);
            this.groupBox1.Controls.Add(this.txtSheet1Name);
            this.groupBox1.Controls.Add(this.lblSheet1Name);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sheet 1";
            // 
            // btnSheet1Submit
            // 
            this.btnSheet1Submit.Location = new System.Drawing.Point(72, 147);
            this.btnSheet1Submit.Name = "btnSheet1Submit";
            this.btnSheet1Submit.Size = new System.Drawing.Size(75, 23);
            this.btnSheet1Submit.TabIndex = 12;
            this.btnSheet1Submit.Text = "Submit";
            this.btnSheet1Submit.UseVisualStyleBackColor = true;
            this.btnSheet1Submit.Click += new System.EventHandler(this.btnSheet1Submit_Click);
            // 
            // dateTimePickerSheet1
            // 
            this.dateTimePickerSheet1.Location = new System.Drawing.Point(9, 118);
            this.dateTimePickerSheet1.Name = "dateTimePickerSheet1";
            this.dateTimePickerSheet1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSheet1.TabIndex = 11;
            // 
            // lblSheet1Age
            // 
            this.lblSheet1Age.AutoSize = true;
            this.lblSheet1Age.Location = new System.Drawing.Point(7, 47);
            this.lblSheet1Age.Name = "lblSheet1Age";
            this.lblSheet1Age.Size = new System.Drawing.Size(63, 12);
            this.lblSheet1Age.TabIndex = 10;
            this.lblSheet1Age.Text = "Age Range: ";
            // 
            // chkSheet1Java
            // 
            this.chkSheet1Java.AutoSize = true;
            this.chkSheet1Java.Location = new System.Drawing.Point(166, 96);
            this.chkSheet1Java.Name = "chkSheet1Java";
            this.chkSheet1Java.Size = new System.Drawing.Size(44, 16);
            this.chkSheet1Java.TabIndex = 8;
            this.chkSheet1Java.Text = "Java";
            this.chkSheet1Java.UseVisualStyleBackColor = true;
            // 
            // cbSheet1AgeRange
            // 
            this.cbSheet1AgeRange.FormattingEnabled = true;
            this.cbSheet1AgeRange.Items.AddRange(new object[] {
            "Under 18",
            "18 - 30",
            "Larger than 30"});
            this.cbSheet1AgeRange.Location = new System.Drawing.Point(72, 44);
            this.cbSheet1AgeRange.Name = "cbSheet1AgeRange";
            this.cbSheet1AgeRange.Size = new System.Drawing.Size(89, 20);
            this.cbSheet1AgeRange.TabIndex = 9;
            // 
            // chkSheet1CSharp
            // 
            this.chkSheet1CSharp.AutoSize = true;
            this.chkSheet1CSharp.Location = new System.Drawing.Point(124, 96);
            this.chkSheet1CSharp.Name = "chkSheet1CSharp";
            this.chkSheet1CSharp.Size = new System.Drawing.Size(38, 16);
            this.chkSheet1CSharp.TabIndex = 7;
            this.chkSheet1CSharp.Text = "C#";
            this.chkSheet1CSharp.UseVisualStyleBackColor = true;
            // 
            // chkSheet1CPlus
            // 
            this.chkSheet1CPlus.AutoSize = true;
            this.chkSheet1CPlus.Location = new System.Drawing.Point(72, 96);
            this.chkSheet1CPlus.Name = "chkSheet1CPlus";
            this.chkSheet1CPlus.Size = new System.Drawing.Size(44, 16);
            this.chkSheet1CPlus.TabIndex = 6;
            this.chkSheet1CPlus.Text = "C++";
            this.chkSheet1CPlus.UseVisualStyleBackColor = true;
            // 
            // lblSheet1Skill
            // 
            this.lblSheet1Skill.AutoSize = true;
            this.lblSheet1Skill.Location = new System.Drawing.Point(7, 97);
            this.lblSheet1Skill.Name = "lblSheet1Skill";
            this.lblSheet1Skill.Size = new System.Drawing.Size(32, 12);
            this.lblSheet1Skill.TabIndex = 5;
            this.lblSheet1Skill.Text = "Skill: ";
            // 
            // radioSheet1Female
            // 
            this.radioSheet1Female.AutoSize = true;
            this.radioSheet1Female.Location = new System.Drawing.Point(124, 70);
            this.radioSheet1Female.Name = "radioSheet1Female";
            this.radioSheet1Female.Size = new System.Drawing.Size(56, 16);
            this.radioSheet1Female.TabIndex = 4;
            this.radioSheet1Female.TabStop = true;
            this.radioSheet1Female.Text = "Female";
            this.radioSheet1Female.UseVisualStyleBackColor = true;
            // 
            // radioSheet1Male
            // 
            this.radioSheet1Male.AutoSize = true;
            this.radioSheet1Male.Location = new System.Drawing.Point(72, 70);
            this.radioSheet1Male.Name = "radioSheet1Male";
            this.radioSheet1Male.Size = new System.Drawing.Size(46, 16);
            this.radioSheet1Male.TabIndex = 3;
            this.radioSheet1Male.TabStop = true;
            this.radioSheet1Male.Text = "Male";
            this.radioSheet1Male.UseVisualStyleBackColor = true;
            // 
            // lblSheet1Gender
            // 
            this.lblSheet1Gender.AutoSize = true;
            this.lblSheet1Gender.Location = new System.Drawing.Point(7, 72);
            this.lblSheet1Gender.Name = "lblSheet1Gender";
            this.lblSheet1Gender.Size = new System.Drawing.Size(45, 12);
            this.lblSheet1Gender.TabIndex = 2;
            this.lblSheet1Gender.Text = "Gender: ";
            // 
            // txtSheet1Name
            // 
            this.txtSheet1Name.Location = new System.Drawing.Point(72, 19);
            this.txtSheet1Name.Name = "txtSheet1Name";
            this.txtSheet1Name.Size = new System.Drawing.Size(100, 22);
            this.txtSheet1Name.TabIndex = 1;
            // 
            // lblSheet1Name
            // 
            this.lblSheet1Name.AutoSize = true;
            this.lblSheet1Name.Location = new System.Drawing.Point(7, 22);
            this.lblSheet1Name.Name = "lblSheet1Name";
            this.lblSheet1Name.Size = new System.Drawing.Size(38, 12);
            this.lblSheet1Name.TabIndex = 0;
            this.lblSheet1Name.Text = "Name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dbConnectInsertBtn);
            this.groupBox4.Controls.Add(this.dbConnectDropTableBtn);
            this.groupBox4.Controls.Add(this.dbConnectCreateTableBtn);
            this.groupBox4.Controls.Add(this.dbConnectSelectBtn);
            this.groupBox4.Controls.Add(this.dbConnectBtn);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 69);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection Test";
            // 
            // dbConnectBtn
            // 
            this.dbConnectBtn.Location = new System.Drawing.Point(6, 21);
            this.dbConnectBtn.Name = "dbConnectBtn";
            this.dbConnectBtn.Size = new System.Drawing.Size(88, 28);
            this.dbConnectBtn.TabIndex = 0;
            this.dbConnectBtn.Text = "Connect";
            this.dbConnectBtn.UseVisualStyleBackColor = true;
            this.dbConnectBtn.Click += new System.EventHandler(this.dbConnectBtn_Click);
            // 
            // dbConnectSelectBtn
            // 
            this.dbConnectSelectBtn.Location = new System.Drawing.Point(390, 21);
            this.dbConnectSelectBtn.Name = "dbConnectSelectBtn";
            this.dbConnectSelectBtn.Size = new System.Drawing.Size(88, 28);
            this.dbConnectSelectBtn.TabIndex = 1;
            this.dbConnectSelectBtn.Text = "Select";
            this.dbConnectSelectBtn.UseVisualStyleBackColor = true;
            this.dbConnectSelectBtn.Click += new System.EventHandler(this.dbConnectSelectBtn_Click);
            // 
            // dbConnectCreateTableBtn
            // 
            this.dbConnectCreateTableBtn.Location = new System.Drawing.Point(102, 21);
            this.dbConnectCreateTableBtn.Name = "dbConnectCreateTableBtn";
            this.dbConnectCreateTableBtn.Size = new System.Drawing.Size(88, 28);
            this.dbConnectCreateTableBtn.TabIndex = 2;
            this.dbConnectCreateTableBtn.Text = "Create Table";
            this.dbConnectCreateTableBtn.UseVisualStyleBackColor = true;
            this.dbConnectCreateTableBtn.Click += new System.EventHandler(this.dbConnectCreateTableBtn_Click);
            // 
            // dbConnectDropTableBtn
            // 
            this.dbConnectDropTableBtn.Location = new System.Drawing.Point(198, 21);
            this.dbConnectDropTableBtn.Name = "dbConnectDropTableBtn";
            this.dbConnectDropTableBtn.Size = new System.Drawing.Size(88, 28);
            this.dbConnectDropTableBtn.TabIndex = 3;
            this.dbConnectDropTableBtn.Text = "Drop Table";
            this.dbConnectDropTableBtn.UseVisualStyleBackColor = true;
            this.dbConnectDropTableBtn.Click += new System.EventHandler(this.dbConnectDropTableBtn_Click);
            // 
            // dbConnectInsertBtn
            // 
            this.dbConnectInsertBtn.Location = new System.Drawing.Point(294, 20);
            this.dbConnectInsertBtn.Name = "dbConnectInsertBtn";
            this.dbConnectInsertBtn.Size = new System.Drawing.Size(88, 28);
            this.dbConnectInsertBtn.TabIndex = 4;
            this.dbConnectInsertBtn.Text = "Insert One";
            this.dbConnectInsertBtn.UseVisualStyleBackColor = true;
            this.dbConnectInsertBtn.Click += new System.EventHandler(this.dbConnectInsertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Practice";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSheet1Age;
        private System.Windows.Forms.ComboBox cbSheet1AgeRange;
        private System.Windows.Forms.CheckBox chkSheet1Java;
        private System.Windows.Forms.CheckBox chkSheet1CSharp;
        private System.Windows.Forms.CheckBox chkSheet1CPlus;
        private System.Windows.Forms.Label lblSheet1Skill;
        private System.Windows.Forms.RadioButton radioSheet1Female;
        private System.Windows.Forms.RadioButton radioSheet1Male;
        private System.Windows.Forms.Label lblSheet1Gender;
        private System.Windows.Forms.TextBox txtSheet1Name;
        private System.Windows.Forms.Label lblSheet1Name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSheet1;
        private System.Windows.Forms.Button btnSheet1Submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxSheet2;
        private System.Windows.Forms.Button btnSheet2Load;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxSheet3Fruit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button dbConnectBtn;
        private System.Windows.Forms.Button dbConnectSelectBtn;
        private System.Windows.Forms.Button dbConnectInsertBtn;
        private System.Windows.Forms.Button dbConnectDropTableBtn;
        private System.Windows.Forms.Button dbConnectCreateTableBtn;
    }
}

