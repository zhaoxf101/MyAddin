using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyCodeAddin
{
    public class Column : IEqualityComparer<Column>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = ToType(value); }
        }

        private string isnull;
        public string IsNull
        {
            get { return isnull; }
            set { isnull = value; }
        }

        public Column(string name, string type,string isnull)
        {
            this.Name = name;
            this.IsNull = isnull;
            this.Type = type;
        }

        private string ToType(string type)
        {
            string strType = "string";
            switch (type)
            {
                case "varchar":
                case "nvarchar":
                case "char":
                case "text":
                case "nchar":
                    strType = "string";
                    break;
                case "datetime":
                case "date":
                case "smalldatetime":
                    strType = "DateTime";
                    break;
                case "time":
                    strType = "TimeSpan";
                    break;
                case "bit":
                    strType = "bool";
                    break;
                case "numeric":
                case "decimal":
                    strType = "decimal";
                    break;
                case "int":
                    strType = "int";
                    break;
                case "long":
                case "bigint":
                    strType = "long";
                    break;
                case "timestamp":
                case "image":
                    strType = "System.Data.Linq.Binary";
                    break;
                case "uniqueidentifier":
                    strType = "Guid";
                    break;
                default:
                    strType = type;
                    break;
            }
            if (IsNull == "YES" && strType != "string" && strType != "System.Data.Linq.Binary")
            {
                strType = strType + "?";
            }
            return strType;
        }

        public static List<Column> GetList(string TableName)
        {
            string sqlStr = string.Format("select COLUMN_NAME,DATA_TYPE,IS_NULLABLE from information_schema.columns where table_name = '{0}' ", TableName);
            List<Column> list = new List<Column>();
            DataTable data = SqlHelper.ExecuteQuery(sqlStr);
            Column item;
            //List<string> keylist = GetKeyList(TableName);
            //bool isKey = false;
            foreach(DataRow dr in data.Rows)
            {
                //foreach (string keyname in keylist)
                //{
                //    if (dr[0].ToString() == keyname)
                //    {
                //        isKey = true;
                //        break;
                //    }
                //}
                //if (!isKey)
                //{
                    item = new Column(dr[0].ToString(), dr[1].ToString(),dr[2].ToString());
                    list.Add(item);
                //}
                //isKey = false;
            }

            return list;

        }

        public static List<Column> GetKeyTypeList(string TableName)
        {
			string sqlStr = string.Format("select COLUMN_NAME,DATA_TYPE,IS_NULLABLE from information_schema.columns where table_name = '{0}' ", TableName);
            List<Column> list = new List<Column>();
            DataTable data = SqlHelper.ExecuteQuery(sqlStr);
            Column item;
            List<string> keylist = GetKeyList(TableName);
            bool isKey = false;
            foreach (DataRow dr in data.Rows)
            {
                foreach (string keyname in keylist)
                {
                    if (dr[0].ToString() == keyname)
                    {
                        isKey = true;
                        break;
                    }
                }
                if (isKey)
                {
                    item = new Column(dr[0].ToString(), dr[1].ToString(),dr[2].ToString());
                    list.Add(item);
                }
                isKey = false;
            }

            return list;
        }

        public static List<Column> GetNoKeyList(string TableName)
        {
            string sqlStr = string.Format("select COLUMN_NAME,DATA_TYPE,IS_NULLABLE from information_schema.columns where table_name = '{0}' ", TableName);
            List<Column> list = new List<Column>();
            DataTable data = SqlHelper.ExecuteQuery(sqlStr);
            Column item;
            List<string> keylist = GetKeyList(TableName);
            bool isKey = false;
            foreach (DataRow dr in data.Rows)
            {
                foreach (string keyname in keylist)
                {
                    if (dr[0].ToString() == keyname)
                    {
                        isKey = true;
                        break;
                    }
                }
                if (!isKey)
                {
                    item = new Column(dr[0].ToString(), dr[1].ToString(),dr[2].ToString());
                    list.Add(item);
                }
                isKey = false;
            }

            return list;

        }

        private static List<string> GetKeyList(string TableName)
        {
            string sqlStr = string.Format("EXEC SP_PKEYS {0} ", TableName);
            List<string> list = new List<string>();
            DataTable data = SqlHelper.ExecuteQuery(sqlStr);
            foreach (DataRow dr in data.Rows)
            {
                list.Add(dr["COLUMN_NAME"].ToString());
            }

            return list;
        }


		public bool Equals(Column x, Column y)
		{
			return x.name == y.name;
		}

		public int GetHashCode(Column obj)
		{
			return obj.name.GetHashCode();
		}
	}
}
