using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        public static readonly string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["stuManage"];
        /// <summary>
        /// 通常用于执行增删改
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="cmdType">如何解释命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        /// 有事务处理的增删改操作
        /// </summary>
        /// <param name="trans">事务</param>
        /// <param name="cmdType">如何解释命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdType">解释如何处理命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        /// <summary>
        /// 返回一张数据表
        /// </summary>
        /// <param name="cmdType">解释如何处理命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static DataTable GetDT(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr, LoadOption.OverwriteChanges);
                cmd.Parameters.Clear();
            }
            catch
            {
                conn.Close();
                throw;
            }
            return dt;
        }
        /// <summary>
        /// 返回首行首列 
        /// </summary>
        /// <param name="cmdType">解释如何处理命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        /// 与其它方法通信
        /// </summary>
        /// <param name="cmd">命令类</param>
        /// <param name="conn">连接类</param>
        /// <param name="trans">事务类</param>
        /// <param name="cmdType">解释如何处理命令字符串</param>
        /// <param name="cmdText">T-SQL文本</param>
        /// <param name="cmdParms">参数</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

    }
}
