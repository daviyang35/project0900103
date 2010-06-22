using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin frm = new FrmLogin();
            if(frm.ShowDialog()==DialogResult.Yes)
            {
                this.UserID = frm.UserID;
                return;
            }
            else
            {
                this.Close();
            }
        }

        public string UserID;
    }
}
