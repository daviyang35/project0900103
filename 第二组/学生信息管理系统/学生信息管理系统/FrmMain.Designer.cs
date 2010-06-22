namespace 学生信息管理系统
{
    partial class FrmMain
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
            this.MainFrmMenu = new System.Windows.Forms.MenuStrip();
            this.基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系部信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.综合查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFrmMenu
            // 
            this.MainFrmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息管理ToolStripMenuItem});
            this.MainFrmMenu.Location = new System.Drawing.Point(0, 0);
            this.MainFrmMenu.Name = "MainFrmMenu";
            this.MainFrmMenu.Size = new System.Drawing.Size(487, 25);
            this.MainFrmMenu.TabIndex = 0;
            this.MainFrmMenu.Text = "menuStrip1";
            // 
            // 基本信息管理ToolStripMenuItem
            // 
            this.基本信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级信息管理ToolStripMenuItem,
            this.系部信息管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.综合查询ToolStripMenuItem});
            this.基本信息管理ToolStripMenuItem.Name = "基本信息管理ToolStripMenuItem";
            this.基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.基本信息管理ToolStripMenuItem.Text = "基本信息管理";
            // 
            // 班级信息管理ToolStripMenuItem
            // 
            this.班级信息管理ToolStripMenuItem.Name = "班级信息管理ToolStripMenuItem";
            this.班级信息管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班级信息管理ToolStripMenuItem.Text = "班级信息管理";
            // 
            // 系部信息管理ToolStripMenuItem
            // 
            this.系部信息管理ToolStripMenuItem.Name = "系部信息管理ToolStripMenuItem";
            this.系部信息管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.系部信息管理ToolStripMenuItem.Text = "系部信息管理";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 综合查询ToolStripMenuItem
            // 
            this.综合查询ToolStripMenuItem.Name = "综合查询ToolStripMenuItem";
            this.综合查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.综合查询ToolStripMenuItem.Text = "综合查询";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 328);
            this.Controls.Add(this.MainFrmMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainFrmMenu;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MainFrmMenu.ResumeLayout(false);
            this.MainFrmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFrmMenu;
        private System.Windows.Forms.ToolStripMenuItem 基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系部信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 综合查询ToolStripMenuItem;
    }
}