using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyCodeAddin
{
    public class MenuList
    {
        public static List<string> GetList()
        {
            string sql = string.Format("select [name] from sys.tables order by [name]");
            DataTable dt = SqlHelper.ExecuteQuery(sql);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            return list;
        }
    }
}
