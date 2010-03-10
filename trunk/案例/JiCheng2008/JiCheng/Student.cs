using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    class Student : Person
    {
        string sno;
        /// <summary>
        /// 学号
        /// </summary>
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        string sclass;
        /// <summary>
        /// 班级
        /// </summary>
        public string Sclass
        {
            get { return sclass; }
            set { sclass = value; }
        }

        /// <summary>
        /// 返回学生信息
        /// </summary>
        /// <returns>返回字符串</returns>
        public new string Showinfo()
        {
            return string.Format("学生 {0},性别：{1}，出生日期：{2}，身份证号：{3}，学号：{4},班级：{5},", Name, Sex, Birthday, IdCard, sno, sclass);
        }

        /// <summary>
        /// 学生年龄
        /// </summary>
        /// <returns></returns>
        public override int GetAge()
        {
            return base.GetAge();
        }
    }
}
