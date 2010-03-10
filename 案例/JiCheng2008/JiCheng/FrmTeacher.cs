using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JiCheng
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Teacher p = new Teacher();              //实例化一个老师类
            p.Name = txtName.Text;
            p.Sex = txtSex.Text;
            p.Birthday = dtpBrithday.Value;
            p.IdCard = txtIDCard.Text;
            p.Tno = txtTNO.Text;
            p.Department = txtDepartment.Text;
            MessageBox.Show(p.Showinfo());          //显示信息
        }
    }
}