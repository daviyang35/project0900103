using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JiCheng
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Student p = new Student();
            p.Name = txtName.Text;
            p.Sex = txtSex.Text;
            p.Birthday = dtpBrithday.Value;
            p.IdCard = txtIDCard.Text;

            p.Sno = txtSNO.Text;
            p.Sclass = txtSClass.Text;

            MessageBox.Show(p.Showinfo());
        }
    }
}