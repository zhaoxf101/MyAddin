using EnvDTE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyCodeAddin
{
	public class Generate
	{
		private string path;
		public string Path
		{
			get { return path; }
			set { path = value; }
		}

		private string busname;
		public string BusName
		{
			get { return busname; }
			set { busname = value; }
		}

		private string dalname;
		public string DalName
		{
			get { return dalname; }
			set { dalname = value; }
		}

		private string filename;

		private string buspath;
		public string BusPath
		{
			get { return buspath; }
			set { buspath = value; }
		}

		private string factory;
		public string Factory
		{
			get { return factory; }
			set { factory = value; }
		}

		private string dalpath;
		public string DalPath
		{
			get { return dalpath; }
			set { dalpath = value; }
		}


		private bool canbus = true;
		public bool CanBus
		{
			get { return canbus; }
			set { canbus = value; }
		}

		private bool candal = true;
		public bool CanDal
		{
			get { return candal; }
			set { candal = value; }
		}

		public Generate(string buspath, string dalpath, string busname, string dalname, string ObjectFactory)
		{
			this.BusPath = buspath;
			this.DalPath = dalpath;
			this.BusName = busname;
			this.DalName = dalname;
			this.Factory = ObjectFactory;
		}

		public Generate(string buspath, string dalpath, string busname, string dalname)
		{
			this.BusPath = buspath;
			this.DalPath = dalpath;
			this.BusName = busname;
			this.DalName = dalname;
		}

		public Generate(string buspath, string dalpath)
		{
			this.BusPath = buspath;
			this.DalPath = dalpath;
		}



		/// <summary>
		/// 生成可编辑只读业务对象
		/// </summary>
		/// <param name="tableName"></param>
		public void ProgCreateEditRead(string tableName, List<Column> list)
		{
			filename = tableName;
			//List<Column> list = Column.GetList(tableName);
			List<Column> keylist = Column.GetKeyTypeList(tableName);
			List<Column> noKeyList = Column.GetNoKeyList(tableName);
			if (CanBus)
			{
				EditRead.EditReadObject obj = new EditRead.EditReadObject(list, keylist, tableName);

				if (!string.IsNullOrEmpty(BusName))
				{
					obj.BusNameSpace = BusName;
				}
				String objstr = obj.TransformText();

				System.IO.File.WriteAllText(string.Format("{0}{1}.cs", buspath, filename), objstr, Encoding.UTF8);
			}
			if (CanDal)
			{
				noKeyList = noKeyList.Intersect(list, new Column("", "", "")).ToList();


				EditRead.EditReadObjectFactory objFactory = new EditRead.EditReadObjectFactory(list, keylist, noKeyList, tableName);
				if (!string.IsNullOrEmpty(DalName))
				{
					objFactory.DalNameSpace = DalName;
				}
				String objFactoryStr = objFactory.TransformText();

				System.IO.File.WriteAllText(string.Format("{0}{1}Factory.cs", dalpath, filename), objFactoryStr, Encoding.UTF8);
			}
		}

		/// <summary>
		/// 生成可编辑业务对象
		/// </summary>
		/// <param name="tableName"></param>
		public void ProgCreateEdit(string tableName)
		{
			//filename = tableName;
			//List<Column> list = Column.GetList(tableName);
			//List<Column> keylist = Column.GetKeyTypeList(tableName);
			//List<Column> noKeyList = Column.GetNoKeyList(tableName);
			//if (CanBus)
			//{
			//	Edit.EditObject obj = new Edit.EditObject(list, keylist, tableName);
			//	Edit.EditObjects objs = new Edit.EditObjects(tableName);

			//	if (!string.IsNullOrEmpty(BusName))
			//	{
			//		obj.BusNameSpace = BusName;
			//		objs.BusNameSpace = BusName;
			//	}
			//	String objstr = obj.TransformText();
			//	String objsStr = objs.TransformText();
			//	System.IO.File.WriteAllText(string.Format("{0}{1}.cs", buspath, filename), objstr, Encoding.UTF8);
			//	System.IO.File.WriteAllText(string.Format("{0}{1}s.cs", buspath, filename), objsStr, Encoding.UTF8);
			//}
			//if (CanDal)
			//{
			//	Edit.EditObjectFactory objFactory = new Edit.EditObjectFactory(list, keylist, noKeyList, tableName);
			//	Edit.EditObjectsFactory objsFactory = new Edit.EditObjectsFactory(tableName);
			//	if (!string.IsNullOrEmpty(DalName))
			//	{
			//		objFactory.DalNameSpace = DalName;
			//		objsFactory.DalNameSpace = DalName;
			//	}
			//	String objFactoryStr = objFactory.TransformText();
			//	String objsFactoryStr = objsFactory.TransformText();
			//	System.IO.File.WriteAllText(string.Format("{0}{1}Factory.cs", dalpath, filename), objFactoryStr, Encoding.UTF8);
			//	System.IO.File.WriteAllText(string.Format("{0}{1}sFactory.cs", dalpath, filename), objsFactoryStr, Encoding.UTF8);
			//}
		}

		/// <summary>
		/// 生成只读业务对象
		/// </summary>
		/// <param name="tableName"></param>
		public void ProgCreateReadOnly(string tableName, Project project)
		{
			filename = tableName;

			string createpathbus = string.Format("{0}{1}.cs", buspath, filename);
			string createpathdal = string.Format("{0}{1}.Factory.cs", dalpath, filename);

			List<Column> list = Column.GetList(tableName);
			if (CanBus)
			{
				ReadOnly.ReadOnlyObject obj = new ReadOnly.ReadOnlyObject(list, tableName);
				if (!string.IsNullOrEmpty(BusName))
				{
					obj.BusNameSpace = BusName;
				}
				obj.Factory = Factory;
				String objstr = obj.TransformText();

				//System.IO.File.WriteAllText(string.Format("{0}{1}.cs", buspath, filename), objstr, Encoding.UTF8);

				FileStream fr = new FileStream(createpathbus, FileMode.Create);
				StreamWriter sw = new StreamWriter(fr);
				sw.Write(objstr);
				sw.Close();
				fr.Close();

				project.ProjectItems.AddFromFile(createpathbus);
			}
			if (CanDal)
			{
				ReadOnly.ReadOnlyObjectFactory objFactory = new ReadOnly.ReadOnlyObjectFactory(list, tableName);
				if (!string.IsNullOrEmpty(DalName))
				{
					objFactory.BusNameSpace = BusName;
					objFactory.DalNameSpace = DalName;
				}

				String objFactoryStr = objFactory.TransformText();

				FileStream fr = new FileStream(createpathdal, FileMode.Create);
				StreamWriter sw = new StreamWriter(fr);
				sw.Write(objFactoryStr);
				sw.Close();
				fr.Close();

				//System.IO.File.WriteAllText(string.Format("{0}{1}Factory.cs", dalpath, filename), objFactoryStr, Encoding.UTF8);

				project.ProjectItems.AddFromFile(createpathdal);
			}

		}

	}
}
