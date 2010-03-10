using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    class Teacher : Person
    {
        string tno;
        /// <summary>
        /// 工号
        /// </summary>
        public string Tno
        {
            get { return tno; }
            set { tno = value; }
        }



        string department;
        /// <summary>
        /// 部门
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// 返回教师信息
        /// </summary>
        /// <returns>返回字符串</returns>
        public new string Showinfo()
        {
            //return string.Format("教师 {0},性别：{1}，出生日期：{2}，身份证号：{3}，工号：{4},部门：{5}", Name, Sex, Birthday, IdCard, tno, department);
            return string.Format("教师 {0}，工号：{1},部门：{2},", base.Showinfo(), tno, department);

        }

        /// <summary>
        /// 教师的工作年龄
        /// </summary>
        /// <returns></returns>
        public override int GetAge()
        {
            return base.GetAge() - 18;
        }


        public Teacher():base()
        {
            //Name = "";
            //Sex = "";
            //Birthday = DateTime.Now;
            //IdCard = "";
           
            tno = "";
            department = "";
        }


        public Teacher(string n, string s, DateTime b, string i, string t, string d):base(n,b,s,i)
        {
            Name = n;
            Sex = s;
            Birthday = b;
            IdCard = i;

            tno = t;
            department = d;
        }
    }
}
