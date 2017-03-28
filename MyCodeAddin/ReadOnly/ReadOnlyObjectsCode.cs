using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeAddin.ReadOnly
{
    public partial class ReadOnlyObjects
    {
        private string classname;
        public string ClassName
        {
            get
            { 
                return classname; 
            }
            set
            {
                classname = value;
            }
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

        public ReadOnlyObjects(string name)
        {
            ClassName = name;
        }
    }
}
