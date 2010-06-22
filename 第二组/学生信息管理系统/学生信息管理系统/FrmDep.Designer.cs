namespace 学生信息管理系统
{
    partial class FrmDep
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
            this.cboDepartmentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartmentCount = new System.Windows.Forms.TextBox();
            this.btnChangeDepartment = new System.Windows.Forms.Button();
            this.btnInsertDepartmen = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDepartmentID
            // 
            this.cboDepartmentID.FormattingEnabled = true;
            this.cboDepartmentID.Location = new System.Drawing.Point(143, 36);
            this.cboDepartmentID.Name = "cboDepartmentID";
            this.cboDepartmentID.Size = new System.Drawing.Size(121, 20);
            this.cboDepartmentID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择系部编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "系部名称：";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(107, 90);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(100, 21);
            this.txtDepartmentID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "系部编号：";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(107, 135);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(100, 21);
            this.txtDepartmentName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "系部人数：";
            // 
            // txtDepartmentCount
            // 
            this.txtDepartmentCount.Location = new System.Drawing.Point(107, 174);
            this.txtDepartmentCount.Name = "txtDepartmentCount";
            this.txtDepartmentCount.ReadOnly = true;
            this.txtDepartmentCount.Size = new System.Drawing.Size(100, 21);
            this.txtDepartmentCount.TabIndex = 2;
            // 
            // btnChangeDepartment
            // 
            this.btnChangeDepartment.Location = new System.Drawing.Point(251, 121);
            this.btnChangeDepartment.Name = "btnChangeDepartment";
            this.btnChangeDepartment.Size = new System.Drawing.Size(99, 23);
            this.btnChangeDepartment.TabIndex = 3;
            this.btnChangeDepartment.Text = "修改系部信息";
            this.btnChangeDepartment.UseVisualStyleBackColor = true;
            // 
            // btnInsertDepartmen
            // 
            this.btnInsertDepartmen.Location = new System.Drawing.Point(251, 82);
            this.btnInsertDepartmen.Name = "btnInsertDepartmen";
            this.btnInsertDepartmen.Size = new System.Drawing.Size(99, 23);
            this.btnInsertDepartmen.TabIndex = 3;
            this.btnInsertDepartmen.Text = "插入系部信息";
            this.btnInsertDepartmen.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(251, 166);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteDepartment.TabIndex = 3;
            this.btnDeleteDepartment.Text = "删除系部信息";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            // 
            // FrmDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 227);
            this.Controls.Add(this.btnInsertDepartmen);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnChangeDepartment);
            this.Controls.Add(this.txtDepartmentCount);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDepartmentID);
            this.Name = "FrmDep";
            this.Text = "系部信息管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartmentCount;
        private System.Windows.Forms.Button btnChangeDepartment;
        private System.Windows.Forms.Button btnInsertDepartmen;
        private System.Windows.Forms.Button btnDeleteDepartment;
    }
}