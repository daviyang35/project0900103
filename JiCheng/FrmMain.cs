using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JiCheng
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            //实例化窗体对象
            FrmPerson frm = new FrmPerson();
            //显示窗体(以模式对话框的形式)
            frm.ShowDialog();
            ////显示窗体(以非模式对话框的形式)
            //frm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FrmTeacher frm = new FrmTeacher();
            frm.ShowDialog();
        }
    }
}