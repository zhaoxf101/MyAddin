using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCodeAddin
{
	public partial class Form1 : Form
	{
		List<Column> listFieldAll;
		List<Column> listFieldNoSel;
		List<Column> listField;

		List<String> listFileBusCode;
		/// <summary>
		/// application对象
		/// </summary>
		private DTE2 _applicationObject;
		/// <summary>
		/// 
		/// </summary>
		public DTE2 applicationObject
		{
			get { return _applicationObject; }
			set { this._applicationObject = value; }
		}

		private string _fileFullPath;
		public string fileFullPath
		{
			get { return _fileFullPath; }
			set { this._fileFullPath = value; }
		}

		private string _filePath;
		public string filePath
		{
			get { return _filePath; }
			set { this._filePath = value; }
		}

		private Project _project;
		public Project project
		{
			get { return _project; }
			set { this._project = value; }
		}

		private SelectedItem _projectSel;
		public SelectedItem projectSel
		{
			get { return _projectSel; }
			set { this._projectSel = value; }
		}

		private Document _doc;
		public Document doc
		{
			get { return _doc; }
			set { this._doc = value; }
		}

		private TextDocument _textDoc;
		public TextDocument textDoc
		{
			get { return _textDoc; }
			set { this._textDoc = value; }
		}

		private TextSelection _texSel;
		public TextSelection texSel
		{
			get { return _texSel; }
			set { this._texSel = value; }
		}

		private EditPoint _start;
		public EditPoint start
		{
			get { return _start; }
			set { this._start = value; }
		}

		private UndoContext _undoObj;
		public UndoContext undoObj
		{
			get { return _undoObj; }
			set { this._undoObj = value; }
		}
		public Form1()
		{
			InitializeComponent();
		}


		private void Menubind()
		{
			//数据库表列表
			List<string> list = MenuList.GetList();
			foreach (string tablename in list)
			{
				cklTableTree.Items.Add(tablename);
			}


			#region 生成代码 文件
			//int count = project.ProjectItems.Count;
			//int indexCode = 0;
			//for (int i = 1; i < count; i++)
			//{
			//	if (project.ProjectItems.Item(i).Name == "Code")
			//	{
			//		indexCode = i;

			//		break;
			//	}
			//}
			#endregion

			//var projectBusCode = project.ProjectItems.Item(indexCode);

			//filePath = projectBusCode.get_FileNames(1);

			//listFileBusCode = new List<String>();

			//for (int i = 1; i <= projectBusCode.ProjectItems.Count; i++)
			//{

			//	string fileName = projectBusCode.ProjectItems.Item(i).Name;
			//	string fileNameShort = string.Empty;
			//	if (fileName.Contains('.'))
			//	{
			//		fileNameShort = fileName.Split('.')[0].ToString().Trim();
			//	}

			//	listFileBusCode.Add(fileNameShort);
			//}


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Menubind();

			var aa = applicationObject;

			var cc = fileFullPath;

			var dd = project;

			var ff = projectSel;

			//string buspath = @System.Configuration.ConfigurationSettings.AppSettings["BusPath"];
			string buspath = filePath;
			txtPath.Text = buspath;
			//txtDataPath.Text = @System.Configuration.ConfigurationSettings.AppSettings["DalPath"];
			txtDataPath.Text = filePath + "CodeDalFactory";
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			//UndoContext undoObj = _applicationObject.UndoContext;
			undoObj.Open("Comment Region");

			#region Business Methods

			//<# foreach(var item in Items)
			//{
			// #>

			//public <#= item.Type #> <#= item.Name #>
			//{
			//	get ;
			//	set ;
			//}

			//<#}#>

			#endregion

			//Do While (Start.LessThan(endpt))
			start.Insert("//");
			start.LineDown();
			start.StartOfLine();
			//Loop
			undoObj.Close();
			//string objStr = "aa";
			//FileStream fr = new FileStream(fileFullPath, FileMode.Append);
			//StreamWriter sw = new StreamWriter(fr);
			//sw.Write(objStr);
			//sw.Close();
			//fr.Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			if (path.ShowDialog() == DialogResult.OK)
			{
				this.txtPath.Text = path.SelectedPath;
			}
		}

		private void btnOpen1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			if (path.ShowDialog() == DialogResult.OK)
			{
				this.txtDataPath.Text = path.SelectedPath;
			}
		}

		/// <summary>
		/// 全部生成
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStartAll_Click(object sender, EventArgs e)
		{
			Generate gen = new Generate(this.txtPath.Text, this.txtDataPath.Text + @"\",
				"Common.Business", "Common.DalFactory", "CMFactory");
			gen.CanBus = cbBus.Checked;
			gen.CanDal = cbDal.Checked;

			List<string> list = MenuList.GetList();//数据库表

			#region 生成代码 文件
			int count = project.ProjectItems.Count;
			int indexCode = 0;
			for (int i = 1; i < count; i++)
			{
				if (project.ProjectItems.Item(i).Name == "Code")
				{
					indexCode = i;

					break;
				}
			}
			#endregion

			var projectBusCode = project.ProjectItems.Item(indexCode);

			//删除多余Bus
			for (int i = listFileBusCode.Count; i > 0; i--)
			{
				string fileNameShort = listFileBusCode[i - 1].Trim();
				if (!list.Contains(fileNameShort))
				{
					//string delFilePath = filePath + fileName;
					//从项目中移除文件
					listFileBusCode.RemoveAt(i-1);
					projectBusCode.ProjectItems.Item(i).Remove();
					//删除移除的文件
					//File.Delete(delFilePath);  
				}
			}

			//新增新表Bus
			foreach (string tablename in list)
			{
				//try
				//{ 
				if (!listFileBusCode.Contains(tablename))
				{
					//生成只读业务对象
					gen.ProgCreateReadOnly(tablename, project);
					break;
				}
				

				//}
				//catch (Exception)
				//{
				//	MessageBox.Show("生成失败");
				//	return;
				//}

			}
		}

		/// <summary>
		/// 生成
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStart_Click(object sender, EventArgs e)
		{
			int n = cklTableTree.CheckedItems.Count;
			Generate gen = new Generate(this.txtPath.Text + @"\", this.txtDataPath.Text + @"\",
				"Common.Business", "Common.DalFactory", "CMFactory");
			gen.CanBus = cbBus.Checked;
			gen.CanDal = cbDal.Checked;
			//try
			//{
			for (int i = 0; i < n; i++)
			{
				//try
				//{
				string tablename = cklTableTree.CheckedItems[i].ToString();

				for (int j = 0; j < cklColumnSel.Items.Count; j++)
				{
					if (!cklColumnSel.GetItemChecked(j))
					{
						listField.RemoveAt(j);
					}
				}


				//if (rdbEditRead.Checked)
				//{
				//	gen.ProgCreateEditRead(tablename, listField);//生成可编辑只读业务对象
				//}

				//if (rdbEdit.Checked)
				//{
				//	gen.ProgCreateEdit(tablename);//生成可编辑业务对象
				//}


				if (rdbReadOnly.Checked)
				{
					gen.ProgCreateReadOnly(tablename, project);//生成只读业务对象
				}

				//}
				//catch
				//{
				//	MessageBox.Show("生成失败");
				//	return;
				//}
			}
			MessageBox.Show("生成成功");
			//}
			//catch
			//{

			//}
		}

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDel_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// 全选/取消全选
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAll.Checked)
			{
				for (int i = 0; i < cklTableTree.Items.Count; i++)
				{
					cklTableTree.SetItemChecked(i, true);//全选
				}
			}
			else
			{
				for (int i = 0; i < cklTableTree.Items.Count; i++)
				{
					cklTableTree.SetItemChecked(i, false);//取消全选
				}
			}
		}

		private void cbPath_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPath.Checked)
			{
				//System.Configuration.ConfigurationSettings.AppSettings["BusPath"] = txtPath.Text;
				//System.Configuration.ConfigurationSettings.AppSettings["DalPath"] = txtDataPath.Text;
				//string code=System.Configuration.SettingAttribute.
			}
		}

		private void cklTableTree_SelectedIndexChanged(object sender, EventArgs e)
		{
			//string tablename = cklTableTree.CheckedItems[0].ToString();

			//List<string> list = MenuList.GetList();

			//foreach (string ziduan in list)
			//{
			//	cklTableTree.Items.Add(tablename);
			//}
		}

		/// <summary>
		/// 挑选表
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cklTableTree_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string tableName = cklTableTree.SelectedItem.ToString();



			if (e.NewValue.ToString() == "Checked")
			{
				//添加字段
				listField = Column.GetList(tableName);



				//List<Column> keylist = Column.GetKeyTypeList(tableName);
				//List<Column> noKeyList = Column.GetNoKeyList(tableName);



				for (int i = 0; i < listField.Count; i++)
				{
					cklColumnSel.Items.Add(listField[i].Name);
					cklColumnSel.SetItemChecked(i, true);
				}

				if (string.IsNullOrEmpty(txtBusFile.Text))
				{
					txtBusFile.Text = tableName;
					txtDalFile.Text = tableName + "Factory";
				}


			}
			else
			{
				//移除字段
				List<Column> list = Column.GetList(tableName);

				foreach (var col in list)
				{
					cklColumnSel.Items.Remove(col.Name);
				}

				txtBusFile.Text = string.Empty;
				txtDalFile.Text = string.Empty;

			}


		}

		





	}
}
