using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    public class Person
    {
        #region 属性
        string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public  string Name
        {
            get { return name; }
            set { name = value; }
        }
        string sex;

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        DateTime birthday;
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        string idCard;
        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard
        {
            get { return idCard; }
            set { idCard = value; }
        }
        #endregion

        /// <summary>
        /// 返回个人信息
        /// </summary>
        /// <returns>返回字符串</returns>
        public string Showinfo()
        {
            return string.Format("{0},性别：{1}，出生日期：{2}，身份证号：{3},", name, sex, birthday, idCard);
        }

        /// <summary>
        /// 获取年龄
        /// </summary>
        /// <returns></returns>
        public virtual int GetAge()  // Ctrl+J
        {
            return DateTime.Now.Year - birthday.Year;
        }

        //public Person()
        //{
        //    name = "";
        //    birthday = DateTime.Now;
        //    sex = "";
        //    idCard = "";
        //}


        public Person():this("",DateTime.Now,"","")
        {
        }

        public Person(string n,DateTime b,string s,string i)
        {
            name = n;
            birthday = b;
            sex = s;
            idCard = i;
        }


    }
}
