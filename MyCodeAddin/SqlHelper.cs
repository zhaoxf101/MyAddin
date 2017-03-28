using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyCodeAddin
{
    /// <summary>
    /// 数据库操作辅助类
    /// </summary>
    public abstract class SqlHelper
    {
        public static int ExecuteNonQuery(string sql, params SqlParameter[] cmdParms)
        {
            SqlConnection con = ConnectDB.Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            try
            {
                con.Open();
                int num = cmd.ExecuteNonQuery();
                return num;
            }
            catch
            {
                return 0;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] cmdparms)
        {
            SqlConnection con = ConnectDB.Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            foreach (SqlParameter parm in cmdparms)
            {
                cmd.Parameters.Add(parm);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        public static DataTable ExecuteQuery(out int total, string sql, string sortExpression, int startRowIndex, int maximumRows, params SqlParameter[] cmdParms)
        {
            string sort = String.IsNullOrEmpty(sortExpression) ? "" : " order by " + sortExpression;
            string sql1 = "select count(*) " + sql.Substring(sql.IndexOf(" from"));
            SqlConnection con = ConnectDB.Connect();
            SqlCommand cmd = new SqlCommand(sql + sort, con);
            SqlCommand cmd1 = new SqlCommand(sql, con);
            con.Open();
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
                cmd1.Parameters.Add(parm);
            }

            total = Int32.Parse(cmd1.ExecuteScalar().ToString());//获取记录总数

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(startRowIndex, maximumRows, dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
                cmd1.Dispose();
                con.Close();
            }

        }

        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] cmdParms)
        {
            SqlConnection con = ConnectDB.Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch
            {
                return null;
            }

        }

        public static object ExecuteScalar(string sql, params SqlParameter[] cmdParms)
        {
            SqlConnection con = ConnectDB.Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                object val = cmd.ExecuteScalar();
                return val;
            }
            catch
            {
                return null;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

    }
}
