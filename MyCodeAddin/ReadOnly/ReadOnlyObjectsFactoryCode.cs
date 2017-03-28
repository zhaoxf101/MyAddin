using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeAddin.ReadOnly
{
    public partial class ReadOnlyObjectsFactory
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

        private string dalnamespace = System.Configuration.ConfigurationSettings.AppSettings["DalName"];
        public string DalNameSpace
        {
            get { return dalnamespace; }
            set { dalnamespace = value; }
        }


        public ReadOnlyObjectsFactory(string tablename)
        {
            this.TableName = tablename;
            this.ClassName = tablename;
        }

    }
}
