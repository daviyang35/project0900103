namespace 学生信息管理系统
{
    partial class FrmSelect
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentInfoView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepartmentTree = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StudentInfo = new System.Windows.Forms.DataGridView();
            this.DepartmentInfo = new System.Windows.Forms.DataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(723, 458);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentInfoView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // StudentInfoView
            // 
            this.StudentInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentInfoView.Location = new System.Drawing.Point(3, 17);
            this.StudentInfoView.Name = "StudentInfoView";
            this.StudentInfoView.RowTemplate.Height = 23;
            this.StudentInfoView.Size = new System.Drawing.Size(167, 186);
            this.StudentInfoView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartmentTree);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DepartmentTree
            // 
            this.DepartmentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentTree.Location = new System.Drawing.Point(3, 17);
            this.DepartmentTree.Name = "DepartmentTree";
            this.DepartmentTree.Size = new System.Drawing.Size(167, 229);
            this.DepartmentTree.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StudentInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 249);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DepartmentInfo);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 209);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // StudentInfo
            // 
            this.StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentInfo.Location = new System.Drawing.Point(3, 49);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.RowTemplate.Height = 23;
            this.StudentInfo.Size = new System.Drawing.Size(540, 197);
            this.StudentInfo.TabIndex = 0;
            // 
            // DepartmentInfo
            // 
            this.DepartmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DepartmentInfo.Location = new System.Drawing.Point(3, 46);
            this.DepartmentInfo.Name = "DepartmentInfo";
            this.DepartmentInfo.RowTemplate.Height = 23;
            this.DepartmentInfo.Size = new System.Drawing.Size(540, 160);
            this.DepartmentInfo.TabIndex = 1;
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSelect";
            this.Text = "综合查询";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView StudentInfoView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView DepartmentTree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView StudentInfo;
        private System.Windows.Forms.DataGridView DepartmentInfo;


    }
}