using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    class Student : Person
    {
        string sno;
        /// <summary>
        /// ѧ��
        /// </summary>
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        string sclass;
        /// <summary>
        /// �༶
        /// </summary>
        public string Sclass
        {
            get { return sclass; }
            set { sclass = value; }
        }

        /// <summary>
        /// ����ѧ����Ϣ
        /// </summary>
        /// <returns>�����ַ���</returns>
        public new string Showinfo()
        {
            return string.Format("ѧ�� {0},�Ա�{1}���������ڣ�{2}�����֤�ţ�{3}��ѧ�ţ�{4},�༶��{5},", Name, Sex, Birthday, IdCard, sno, sclass);
        }

        /// <summary>
        /// ѧ������
        /// </summary>
        /// <returns></returns>
        public override int GetAge()
        {
            return base.GetAge();
        }
    }
}
