using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Score
    {
        /// <summary>
        /// 映射数据表T_Score_Stu_Sub
        /// </summary>
        public Score()
        {
            this.SubjectScore = 0;
            this.StudentID = 0;
            this.StuID = 0;
            this.SubjectID = 0;
        }

        /// <summary>
        /// 映射数据表T_Score_Stu_Sub
        /// </summary>
        /// <param name="iStuID">自动编号</param>
        /// <param name="iStudentID">学号</param>
        /// <param name="iSubjectID">课程号</param>
        /// <param name="iScore">成绩</param>
        public Score(int iStuID,int iStudentID,int iSubjectID,int iScore)
        {
            this.SubjectScore = iScore;
            this.StudentID = iStudentID;
            this.StuID = iStuID;
            this.SubjectID = iSubjectID;
        }
        private int _stuID;

        public int StuID
        {
            get { return _stuID; }
            set { _stuID = value; }
        }
        private int _StudentID;

        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        private int _SubjectID;

        public int SubjectID
        {
            get { return _SubjectID; }
            set { _SubjectID = value; }
        }
        private float _SubjectScore;

        public float SubjectScore
        {
            get { return _SubjectScore; }
            set { _SubjectScore = value; }
        }
    }
}
