using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    public class Person
    {
        #region ����
        string name;

        /// <summary>
        /// ����
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string sex;

        /// <summary>
        /// �Ա�
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        DateTime birthday;
        /// <summary>
        /// ����
        /// </summary>
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        string idCard;
        /// <summary>
        /// ���֤
        /// </summary>
        public string IdCard
        {
            get { return idCard; }
            set { idCard = value; }
        }
        #endregion

        /// <summary>
        /// ���ظ�����Ϣ
        /// </summary>
        /// <returns>�����ַ���</returns>
        public string Showinfo()
        {
            return string.Format("{0},�Ա�{1}���������ڣ�{2}�����֤�ţ�{3}", name, sex, birthday, idCard);
        }
    }
}
