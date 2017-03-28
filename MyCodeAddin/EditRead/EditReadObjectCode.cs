using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeAddin.EditRead
{
    public partial class EditReadObject
    {
        private string tablename;
        public string TableName
        {
            get { return tablename; }
            set { tablename = value; }
        }

        private string classname;
        public string ClassName
        {
            get { return classname; }
            set { classname = value; }
        }

        private string busnamespace = System.Configuration.ConfigurationSettings.AppSettings["BusName"];
        public string BusNameSpace
        {
            get { return busnamespace; }
            set { busnamespace = value; }
        }

        private string factory = System.Configuration.ConfigurationSettings.AppSettings["ObjectFactory"];
        public string Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        private List<Column> items;
        public List<Column> Items
        {
            get { return items; }
            set { items = value; }
        }

        private List<Column> keyitems;
        public List<Column> KeyItems
        {
            get { return keyitems; }
            set { keyitems = value; }
        }

        public EditReadObject(List<Column> list,List<Column> keylist,string tablename)
        {
            this.Items = list;
            this.KeyItems = keylist;
            this.TableName = tablename;
            this.ClassName = tablename;
        }

    }
}
