using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Student
    {
        /// <summary>
        /// 构造函数-无参数
        /// </summary>
        public Student()
        {
            this.IdentityID = "";
            this.StudentID = 0;
            this.StudentName = "";
            this.StuImage = null;
            this.StudentAddress = "";
            //this.StuBirthday = "";
            this.Sex = 0;
            this.Password = "";
            this.Level = "";
            this.ClassID = 0;
        }

        /// <summary>
        /// 构造函数-带参数
        /// </summary>
        /// <param name="strIdentityID">身份证号</param>
        /// <param name="iStudentID">学号</param>
        /// <param name="strStudentName">学生姓名</param>
        /// <param name="strStudentAddress">家庭住址</param>
        /// <param name="dteStuBirthday">生日</param>
        /// <param name="strPassword">密码</param>
        /// <param name="strLevel">权限</param>
        /// <param name="iSex">性别</param>
        /// <param name="iClassID">班级编号</param>
        /// <param name="bImage">照片</param>
        public Student(string strIdentityID,int iStudentID,string strStudentName,string strStudentAddress,DateTime dteStuBirthday,string strPassword,string strLevel,int iSex,int iClassID,byte[] bImage)
        {
            this.IdentityID = strIdentityID;
            this.StudentID = iStudentID;
            this.StudentName = strStudentName;
            this.StuImage = bImage;
            this.StudentAddress = strStudentAddress;
            this.StuBirthday = dteStuBirthday;
            this.Sex = iSex;
            this.Password = strPassword;
            this.Level = strLevel;
            this.ClassID = iClassID;
        }
        private string _identityID;

        public string IdentityID
        {
            get { return _identityID; }
            set { _identityID = value; }
        }
        private int _StudentID;

        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        private string _StudentName;

        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; }
        }
        private string _StudentAddress;

        public string StudentAddress
        {
            get { return _StudentAddress; }
            set { _StudentAddress = value; }
        }
        private DateTime _stuBirthday;

        public DateTime StuBirthday
        {
            get { return _stuBirthday; }
            set { _stuBirthday = value; }
        }
        private String _Password;

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _Level;

        public string Level
        {
            get { return _Level; }
            set { _Level = value; }
        }
        private int _Sex;

        public int Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        private int _ClassID;

        public int ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }
        private byte[] _stuImage;

        public byte[] StuImage
        {
            get { return _stuImage; }
            set { _stuImage = value; }
        }
    }
}
