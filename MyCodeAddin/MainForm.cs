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

using EnvDTE;
using EnvDTE80;

namespace MyCodeAddin
{
	public partial class MainForm : Form
	{
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


		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var aa = applicationObject;

			var cc = fileFullPath;

			var dd = project;


			string bb = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//读取选中类文件


			FileStream fs = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read);



			StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
			//将文件内容编译生成对象
			string conString = sr.ReadToEnd();
			object classobject = DynamicCompiling.Compo(conString);

			string aa = classobject.GetType().Namespace;

			if (classobject is string)
			{
				MessageBox.Show("动态编译失败:" + "\r\n" + classobject, "类文件编译错误!");
				sr.Close();
				fs.Close();

				return;
			}

			//创建代码文件,并添加到项目中
			Createcode(classobject, project, filePath, textBox1.Text.Trim());

			sr.Close();
			fs.Close();
		}


		//创建viewmodel代码文件,并添加到项目
		public static ProjectItem Createcode(object model, Project project, string path,string xuhao)
		{
			TextTemplate1 consoleCode = new TextTemplate1(model);
			string codetext = consoleCode.TransformText();
			//如果不存在文件夹,则创建
			string Projectpath = path;
			if (!Directory.Exists(Projectpath))
			{
				Directory.CreateDirectory(Projectpath);
			}

			//将目标代码生成文件

			string createpath = Projectpath + "Program" + xuhao + ".cs";
			FileStream fr = new FileStream(createpath, FileMode.Create);
			StreamWriter sw = new StreamWriter(fr);
			sw.Write(codetext);
			sw.Close();
			fr.Close();



			//添加文件到项目中
			var aa = project.ProjectItems.AddFromFile(createpath);

			return aa;

		}


		//获取选中所属项目
		private Project GetSelectedProject()
		{
			Project project = null;
			//从被选中对象中获取工程对象 
			EnvDTE.SelectedItem item = _applicationObject.SelectedItems.Item(1);

			if (item.Project != null)
			{//被选中的就是项目本生 
				project = item.Project;
			}
			else
			{//被选中的是项目下的子项 
				project = item.ProjectItem.ProjectItems.ContainingProject;
			}
			return project;
		}
		//获取选中文件全路径
		private string GetSelecteditempath()
		{

			//从被选中对象中获取工程对象 
			EnvDTE.SelectedItem item = _applicationObject.SelectedItems.Item(1);

			string selectpath = item.ProjectItem.Properties.Item("FullPath").Value.ToString();

			return selectpath;
		}

		//获取选中文件所属项目的路径,不含文件名
		private string GetSelectedProjectPath()
		{
			string path = "";
			//获取被选中的工程 
			Project project = GetSelectedProject();
			if (project != null)
			{
				//全名包括*.csproj这样的文件命 
				path = project.FullName;
			}
			//去掉工程的文件名 

			path = project.FullName.Replace(project.Name + ".csproj", "");

			return path;
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			int count = project.ProjectItems.Count;
			int n = count - 2;
			for (int i = project.ProjectItems.Count - 2; i >0; i--)
			{
				string aa = project.ProjectItems.Item(i).Name;

				string delFilePath = filePath + aa;
				//从项目中移除文件
				project.ProjectItems.Item(i).Delete();
				//删除移除的文件
				//File.Delete(delFilePath);  

				string asdf = string.Empty;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}



	}



}
