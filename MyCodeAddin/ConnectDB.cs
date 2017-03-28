using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MyCodeAddin
{
    public class ConnectDB
    {
        //private static string connectString = System.Configuration.ConfigurationSettings.AppSettings["source"];

		private static string connectString = "server=118.178.226.143;database=dev;uid=abap;pwd=engine1";
        public static SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(connectString);
            return con;
        }

        public static bool CanConnect()
        {
            SqlConnection con = Connect();
            bool isexect = false;
            try
            {
                con.Open();
                isexect = true;
            }
            catch
            {
                isexect = false;
            }
            finally
            {
                con.Close();
                con.Dispose();

            }
            return isexect;
        }
    }
}
