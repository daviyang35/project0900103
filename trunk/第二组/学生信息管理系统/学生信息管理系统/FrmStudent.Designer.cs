namespace 学生信息管理系统
{
    partial class FrmStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentityID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboClassID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioBoy = new System.Windows.Forms.RadioButton();
            this.radioGirl = new System.Windows.Forms.RadioButton();
            this.picStudentImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboIdentityID = new System.Windows.Forms.ComboBox();
            this.btnInsertSutdent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnChangeStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证号：";
            // 
            // txtIdentityID
            // 
            this.txtIdentityID.Location = new System.Drawing.Point(90, 18);
            this.txtIdentityID.Name = "txtIdentityID";
            this.txtIdentityID.Size = new System.Drawing.Size(132, 21);
            this.txtIdentityID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "地址：";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(90, 58);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 21);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(90, 93);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 21);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(90, 129);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(100, 71);
            this.txtStudentAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "出生日期：";
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(90, 216);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(121, 21);
            this.Birthday.TabIndex = 4;
            this.Birthday.Value = new System.DateTime(2010, 6, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "权限：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // cboClassID
            // 
            this.cboClassID.FormattingEnabled = true;
            this.cboClassID.Location = new System.Drawing.Point(281, 286);
            this.cboClassID.Name = "cboClassID";
            this.cboClassID.Size = new System.Drawing.Size(121, 20);
            this.cboClassID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "性别：";
            // 
            // radioBoy
            // 
            this.radioBoy.AutoSize = true;
            this.radioBoy.Location = new System.Drawing.Point(90, 322);
            this.radioBoy.Name = "radioBoy";
            this.radioBoy.Size = new System.Drawing.Size(35, 16);
            this.radioBoy.TabIndex = 7;
            this.radioBoy.TabStop = true;
            this.radioBoy.Text = "男";
            this.radioBoy.UseVisualStyleBackColor = true;
            // 
            // radioGirl
            // 
            this.radioGirl.AutoSize = true;
            this.radioGirl.Location = new System.Drawing.Point(131, 322);
            this.radioGirl.Name = "radioGirl";
            this.radioGirl.Size = new System.Drawing.Size(35, 16);
            this.radioGirl.TabIndex = 8;
            this.radioGirl.TabStop = true;
            this.radioGirl.Text = "女";
            this.radioGirl.UseVisualStyleBackColor = true;
            // 
            // picStudentImage
            // 
            this.picStudentImage.Location = new System.Drawing.Point(226, 61);
            this.picStudentImage.Name = "picStudentImage";
            this.picStudentImage.Size = new System.Drawing.Size(96, 96);
            this.picStudentImage.TabIndex = 6;
            this.picStudentImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(236, 163);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 9;
            this.btnSelectImage.Text = "选择图片";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "学分：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(281, 253);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "班级：";
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(90, 286);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 20);
            this.cboLevel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.picStudentImage);
            this.groupBox1.Controls.Add(this.radioGirl);
            this.groupBox1.Controls.Add(this.radioBoy);
            this.groupBox1.Controls.Add(this.cboLevel);
            this.groupBox1.Controls.Add(this.cboClassID);
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.txtStudentAddress);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.txtIdentityID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "身份证号：";
            // 
            // cboIdentityID
            // 
            this.cboIdentityID.FormattingEnabled = true;
            this.cboIdentityID.Location = new System.Drawing.Point(102, 27);
            this.cboIdentityID.Name = "cboIdentityID";
            this.cboIdentityID.Size = new System.Drawing.Size(132, 20);
            this.cboIdentityID.TabIndex = 0;
            // 
            // btnInsertSutdent
            // 
            this.btnInsertSutdent.Location = new System.Drawing.Point(457, 107);
            this.btnInsertSutdent.Name = "btnInsertSutdent";
            this.btnInsertSutdent.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSutdent.TabIndex = 2;
            this.btnInsertSutdent.Text = "插入";
            this.btnInsertSutdent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(457, 279);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "删除";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnChangeStudent
            // 
            this.btnChangeStudent.Location = new System.Drawing.Point(457, 191);
            this.btnChangeStudent.Name = "btnChangeStudent";
            this.btnChangeStudent.Size = new System.Drawing.Size(75, 23);
            this.btnChangeStudent.TabIndex = 3;
            this.btnChangeStudent.Text = "修改";
            this.btnChangeStudent.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.btnChangeStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnInsertSutdent);
            this.Controls.Add(this.cboIdentityID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Name = "FrmStudent";
            this.Text = "学生信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentityID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboClassID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBoy;
        private System.Windows.Forms.RadioButton radioGirl;
        private System.Windows.Forms.PictureBox picStudentImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboIdentityID;
        private System.Windows.Forms.Button btnInsertSutdent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnChangeStudent;
    }
}