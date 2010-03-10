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

        private void btnTest_Click(object sender, EventArgs e)
        {
            //
            Person p = new Person();
            Student s = new Student();
            Teacher t = new Teacher();

            lblMessage.Text = "未进行派生类对象赋值给基类对象前调用ShowInfo()：\nt.ShowInfo()" + t.Showinfo() + "\n" + "s.ShowInfo()" + s.Showinfo() + "\n" + "p.ShowInfo()" + p.Showinfo() + "\n";

            lblMessage.Text += "未进行派生类对象赋值给基类对象前调用GetAge()：\nt.GetAge()" + t.GetAge() + "\n" + "s.GetAge()" + s.GetAge() + "\n" + "p.GetAge()";
            lblMessage.Text += p.GetAge() + "\n";
           
            p = new Teacher();   //

            lblMessage.Text += "派生类对象t赋值给基类对象p之后调用ShowInfo()：\nt.ShowInfo()" + t.Showinfo() + "\n" + "s.ShowInfo()" + s.Showinfo() + "\n" + "p.ShowInfo()" + p.Showinfo() + "\n";

            lblMessage.Text += "派生类对象t赋值给基类对象p之后调用GetAge()：\nt.GetAge()" + t.GetAge() + "\n" + "s.GetAge()" + s.GetAge() + "\n" + "p.GetAge()";
            lblMessage.Text += p.GetAge() + "\n";



            p = new Student();   //

            lblMessage.Text += "派生类对象t赋值给基类对象p之后调用ShowInfo()：\nt.ShowInfo()" + t.Showinfo() + "\n" + "s.ShowInfo()" + s.Showinfo() + "\n" + "p.ShowInfo()" + p.Showinfo() + "\n";

            lblMessage.Text += "派生类对象t赋值给基类对象p之后调用GetAge()：\nt.GetAge()" + t.GetAge() + "\n" + "s.GetAge()" + s.GetAge() + "\n" + "p.GetAge()";
            lblMessage.Text += p.GetAge() + "\n";

            //s = p;//不正确

          
        }
    }
}