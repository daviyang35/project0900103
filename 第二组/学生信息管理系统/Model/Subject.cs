using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Subject
    {

        /// <summary>
        /// 学生与课程表之间的关联
        /// </summary>
        /// <param name="iStuID">学号</param>
        /// <param name="iSubID">课程号</param>
        /// <param name="flCredit">课程学分</param>
        public Subject(int iStuID,int iSubID,float flCredit)
        {
            this.Credit = flCredit;
            this.StuID = iStuID;
            this.SubID = iSubID;
        }
        private int _stuID;

        public int StuID
        {
            get { return _stuID; }
            set { _stuID = value; }
        }
        private int _SubID;

        public int SubID
        {
            get { return _SubID; }
            set { _SubID = value; }
        }
        private float _Credit;

        public float Credit
        {
            get { return _Credit; }
            set { _Credit = value; }
        }

    }
}
