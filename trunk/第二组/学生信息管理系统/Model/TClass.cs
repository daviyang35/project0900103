using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class TClass
    {
        /// <summary>
        /// 构造函数-无参数
        /// </summary>
        public TClass()
        {
            this.ClassCount = 0;
            this.ClassID = 0;
            this.ClassManageName = "";
            this.ClassName = "";
            this.DepartmentID = 0;
        }

        /// <summary>
        /// 构造函数-带参数
        /// </summary>
        /// <param name="iClassID">班级ID</param>
        /// <param name="strClassName">班级名称</param>
        /// <param name="strClassManagerName"></param>
        /// <param name="iClassCount">班级人数</param>
        /// <param name="iDepartmentID">系部编号</param>
        public TClass(int iClassID,string strClassName,string strClassManagerName,int iClassCount,int iDepartmentID)
        {
            this.ClassCount = iClassCount;
            this.ClassID = iClassID;
            this.ClassManageName = strClassManagerName;
            this.ClassName = strClassName;
            this.DepartmentID = iDepartmentID;
        }
        private int _ClassID;

        public int ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }
        private string _ClassName;

        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        private string _ClassManageName;

        public string ClassManageName
        {
            get { return _ClassManageName; }
            set { _ClassManageName = value; }
        }
        private int _ClassCount;

        public int ClassCount
        {
            get { return _ClassCount; }
            set { _ClassCount = value; }
        }
        private int _DepartmentID;

        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

    }
}
