using System;
using System.Collections.Generic;
using System.Text;

namespace JiCheng
{
    class Teacher : Person
    {
        string tno;
        /// <summary>
        /// ����
        /// </summary>
        public string Tno
        {
            get { return tno; }
            set { tno = value; }
        }
        string department;
        /// <summary>
        /// ����
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// ���ؽ�ʦ��Ϣ
        /// </summary>
        /// <returns>�����ַ���</returns>
        public new string Showinfo()
        {
            //return string.Format("��ʦ {0},�Ա�{1}���������ڣ�{2}�����֤�ţ�{3}�����ţ�{4},���ţ�{5}", Name, Sex, Birthday, IdCard, tno, department);
            return string.Format("��ʦ {0}�����ţ�{1},���ţ�{2}", base.Showinfo(), tno, department);

        }
    }
}
