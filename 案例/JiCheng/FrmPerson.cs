using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JiCheng
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = txtName.Text;
            p.Sex = txtSex.Text;
            p.Birthday = dtpBrithday.Value;
            p.IdCard = txtIDCard.Text;
            MessageBox.Show(p.Showinfo());
        }
    }
}