using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ZooManagemtSystem
{
    public class DBHelper
    {
        private static string _connStr = "";
        private SqlConnection _conn;

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        static public void GetConnStr()
        {
            // var encrypt = Convert.ToBoolean(ConfigurationManager.AppSettings["ConnEncrypt"]);
            _connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString.Trim();
        }

        /// <summary>
        /// 得到当前连接对象
        /// </summary>
        /// <returns>连接对象</returns>
        static public SqlConnection GetConn()
        {
            if (_connStr == "")
                GetConnStr();
            var conn = new SqlConnection(_connStr);
            return conn;
        }

        public void OpenConnection()
        {
            _conn = GetConn();
            _conn.Open();
        }

        public void CloseConnection()
        {
            if (_conn.State != ConnectionState.Closed)
                _conn.Close();
        }

        //-------------- 执行命令 ----------------
        public bool ExecuteNonQuery(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                int len = cmd.ExecuteNonQuery();
                if (len > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        //-------------- 返回一个值 ----------------
        public object ExecuteScalar(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        //-------------- 返回DataReader ----------------
        public SqlDataReader ExecuteReader(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                CloseConnection();
                return null;
            }
        }

    }
}
