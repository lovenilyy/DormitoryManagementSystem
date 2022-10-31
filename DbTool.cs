using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 高校宿舍管理系统
{
    
    public class DbTool
    {
        public static string strCon = ConfigurationManager.AppSettings["Db"];
        public static SqlDataReader DR;
        public class Yh
        {
            /// <summary>
            /// Sf
            /// </summary>		
            private string _sf;
            public string Sf
            {
                get { return _sf; }
                set { _sf = value; }
            }
            public Yh(string sf)
            {
                Sf = sf;
            }
        }
        public static bool Execute(string sql)
        {
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                if (count >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool Login(string name,string pwd,string sf)
        {
            string sql = string.Format("select * from Yh where Yhm='{0}' and Mm='{1}' and Sf='{2}'", name, pwd, sf);
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, strCon);
            try
            {
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
            finally
            {
                adp.Dispose();
            }
        }
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //conn.Close();
            }
            return null;
        }
        public static SqlDataReader lstl(string sql)
        {

            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.CommandText = sql;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DR = cmd.ExecuteReader();
                return DR;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
