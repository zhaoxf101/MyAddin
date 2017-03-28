using System;
using Extensibility;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MyCodeAddin
{
	/// <summary>用于实现外接程序的对象。</summary>
	/// <seealso class='IDTExtensibility2' />
	public class Connect : IDTExtensibility2, IDTCommandTarget
	{
		/// <summary>实现外接程序对象的构造函数。请将您的初始化代码置于此方法内。</summary>
		public Connect()
		{
		}

		///本事件处理函数是在插件被加载时发生，一般用于做一些初始化工作，如创建菜单等。
		/// <summary>实现 IDTExtensibility2 接口的 OnConnection 方法。接收正在加载外接程序的通知。</summary>
		/// <param term='application'>宿主应用程序的根对象。</param>
		/// <param term='connectMode'>描述外接程序的加载方式。</param>
		/// <param term='addInInst'>表示此外接程序的对象。</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
		{
			//_applicationObject = (DTE2)application;
			//_addInInstance = (AddIn)addInInst;
			//if (connectMode == ext_ConnectMode.ext_cm_UISetup)
			//{
			//	object[] contextGUIDS = new object[] { };
			//	Commands2 commands = (Commands2)_applicationObject.Commands;
			//	string toolsMenuName = "Tools";

			//	//将此命令置于“工具”菜单上。
			//	//查找 MenuBar 命令栏，该命令栏是容纳所有主菜单项的顶级命令栏:
			//	Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar = ((Microsoft.VisualStudio.CommandBars.CommandBars)_applicationObject.CommandBars)["MenuBar"];

			//	//在 MenuBar 命令栏上查找“工具”命令栏:
			//	CommandBarControl toolsControl = menuBarCommandBar.Controls[toolsMenuName];
			//	CommandBarPopup toolsPopup = (CommandBarPopup)toolsControl;

			//	//如果希望添加多个由您的外接程序处理的命令，可以重复此 try/catch 块，
			//	//  只需确保更新 QueryStatus/Exec 方法，使其包含新的命令名。
			//	try
			//	{
			//		//将一个命令添加到 Commands 集合:
			//		Command command = commands.AddNamedCommand2(_addInInstance, "MyCodeAddin", "MyCodeAddin", "Executes the command for MyCodeAddin", true, 59, ref contextGUIDS, (int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);

			//		//将对应于该命令的控件添加到“工具”菜单:
			//		if ((command != null) && (toolsPopup != null))
			//		{
			//			command.AddControl(toolsPopup.CommandBar, 1);
			//		}
			//	}
			//	catch (System.ArgumentException)
			//	{
			//		//如果出现此异常，原因很可能是由于具有该名称的命令
			//		//  已存在。如果确实如此，则无需重新创建此命令，并且
			//		//  可以放心忽略此异常。
			//	}
			//}


			_applicationObject = (DTE2)application;
			_addInInstance = (AddIn)addInInst;
			if (connectMode == ext_ConnectMode.ext_cm_UISetup)
			{
				object[] contextGUIDS = new object[] { };
				Commands2 commands = (Commands2)_applicationObject.Commands;

				CommandBars cbs = (CommandBars)_applicationObject.CommandBars;
				//添加命令到   项目中.cs文件 
				//CommandBar projBar = cbs["Item"];
				//添加命令到   代码编辑窗口右键弹出菜单的工具条
				CommandBar projBar = cbs["Code Window"];
				//添加命令到   项目
				//CommandBar projBar = cbs["Project"];


				//如果希望添加多个由您的外接程序处理的命令，可以重复此 try/catch 块，
				//  只需确保更新 QueryStatus/Exec 方法，使其包含新的命令名。
				try
				{
					//将一个命令添加到 Commands 集合:
					//1.AddIn pAddIn //用于添加新命令的 AddIn 对象
					//2.string Name//新命令的名称缩写。AddNamedCommand 会自动给此缩写加上前面类前缀的
					//3.string ButtonText,//在命令绑定到以名称而不是以图标显示的按钮时使用的名称
					//4.string Tooltip,    //当用户将鼠标指针悬停在任何绑定到新命令的控件上时所显示的文本
					//5.bool MSOButton,    //指示指定命令的按钮图片是否是 Office 图片。True = 按钮图片从Office资源文件中获取。False则表示按钮的图片资源来源于其他的文件
					//6.int Bitmap,        //在按钮上显示的位图的 ID
					//7.object[] ppsaContextUIGUIDs,//GUID的SafeArray，它确定启用此命令的环境上下文（即调试模式、设计模式等
					//8.int DisableFlags  //确定当您提供了 ContextUIGUIDs 而当前它们都不活动时，此命令的禁用状态是不可见还是灰色的
					Command command = commands.AddNamedCommand2(_addInInstance,
						"MyCodeAddin", "MyCodeAddin", "Executes the command for MyCodeAddin",
						true, 59, ref contextGUIDS,
						(int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled,
						(int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);

					//将子菜单加入Project的右键菜单
					if (command != null)
					{
						command.AddControl(projBar, 1);
					}
				}
				catch (System.ArgumentException e)
				{
					MessageBox.Show(e.Message);
					//如果出现此异常，原因很可能是由于具有该名称的命令
					//  已存在。如果确实如此，则无需重新创建此命令，并且
					//  可以放心忽略此异常。
				}
			}
		}

		/// <summary>实现 IDTCommandTarget 接口的 QueryStatus 方法。此方法在更新该命令的可用性时调用</summary>
		/// <param term='commandName'>要确定其状态的命令的名称。</param>
		/// <param term='neededText'>该命令所需的文本。</param>
		/// <param term='status'>该命令在用户界面中的状态。</param>
		/// <param term='commandText'>neededText 参数所要求的文本。</param>
		/// <seealso class='Exec' />
		public void QueryStatus(string commandName, vsCommandStatusTextWanted neededText, ref vsCommandStatus status, ref object commandText)
		{

			if (neededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
			{
				//status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;

				if (commandName == "MyCodeAddin.Connect.MyCodeAddin")
				{
					status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;

					//if (!GetSelecteditempath().ToLower().EndsWith(".cs"))
					//{
					//	status = (vsCommandStatus)vsCommandStatus.vsCommandStatusInvisible;

					//	//status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;
					//}
					//else
					//{
					//	status = (vsCommandStatus)vsCommandStatus.vsCommandStatusInvisible;
					//	//status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;
					//}
					return;
				}
			}
		}

		/// <summary>实现 IDTCommandTarget 接口的 Exec 方法。此方法在调用该命令时调用。</summary>
		/// <param term='commandName'>要执行的命令的名称。</param>
		/// <param term='executeOption'>描述该命令应如何运行。</param>
		/// <param term='varIn'>从调用方传递到命令处理程序的参数。</param>
		/// <param term='varOut'>从命令处理程序传递到调用方的参数。</param>
		/// <param term='handled'>通知调用方此命令是否已被处理。</param>
		/// <seealso class='Exec' />
		public void Exec(string commandName, vsCommandExecOption executeOption, ref object varIn, ref object varOut, ref bool handled)
		{
			handled = false;
			if (executeOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
			{
				if (commandName == "MyCodeAddin.Connect.MyCodeAddin")
				{
					//此处添加自己的逻辑代码
					#region
					//Point pos = new Point();
					//var aa = GetCaretPos(ref pos);
					#endregion


					//TextPoint pt;
					//var ab = pt.CodeElement[vsCMElement



					

					//获取被选中文件路径及文件名
					string fileFullPath = GetSelecteditempath();
					//获取被选中文件路径（不包含文件名）
					string filePath = GetSelectedProjectPath();
					//获取被选中的工程 
					Project project = GetSelectedProject();

					SelectedItem item = GetProjectItemSel();

					//文档
					Document doc = _applicationObject.ActiveDocument;
					TextDocument textDoc = (TextDocument)_applicationObject.ActiveDocument.Object("");
					TextSelection texSel = (TextSelection)_applicationObject.ActiveDocument.Selection;


					EditPoint Start = texSel.AnchorPoint.CreateEditPoint();
					TextPoint endpt = texSel.BottomPoint;

					UndoContext undoObj = _applicationObject.UndoContext;
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
					Start.Insert("public  {get;set;}"  );
					Start.LineDown();
					Start.StartOfLine();
					//Loop
					undoObj.Close();

					string actDocName = doc.Name;

					//var er=textPT.get_CodeElement(vsCMElement.vsCMElementClass);


					//var pt = textPT.CodeElement[vsCMElement.vsCMElementClass];

					//MainForm mainF = new MainForm();
					//mainF.applicationObject = _applicationObject;
					//mainF.project = project;
					//mainF.fileFullPath = fileFullPath;
					//mainF.filePath = filePath;
					//mainF.Show();

					//handled = true;
					//return;


					//Form1 mainF = new Form1();
					//mainF.applicationObject = _applicationObject;
					//mainF.project = project;
					//mainF.projectSel = item;
					//mainF.fileFullPath = fileFullPath;
					//mainF.filePath = filePath;

					//mainF.doc = doc;
					//mainF.textDoc = textDoc;

					//mainF.texSel = texSel;
					//mainF.start = Start;
					//mainF.undoObj = undoObj;
					//mainF.Show();

					handled = true;
					return;

					//if (!GetSelecteditempath().ToLower().EndsWith(".cs"))
					//{
					//	return;
					//}
					////读取选中类文件
					//FileStream fs = new FileStream(GetSelecteditempath(), FileMode.Open, FileAccess.Read);
					//StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
					////将文件内容编译生成对象
					//string conString = sr.ReadToEnd();
					//object classobject = DynamicCompiling.Compo(conString);

					//string aa = classobject.GetType().Namespace;

					//if (classobject is string)
					//{
					//	MessageBox.Show("动态编译失败:" + "\r\n" + classobject, "类文件编译错误!");
					//	sr.Close();
					//	fs.Close();
					//	handled = true;
					//	return;
					//}

					////创建代码文件,并添加到项目中
					//Createcode(classobject, GetSelectedProject(), GetSelectedProjectPath());

					//sr.Close();
					//fs.Close();

					//handled = true;

				}
			}
		}

		//创建viewmodel代码文件,并添加到项目
		public static ProjectItem Createcode(object model, Project project, string path)
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
			string createpath = Projectpath + "Program.cs";
			FileStream fr = new FileStream(createpath, FileMode.Create);
			StreamWriter sw = new StreamWriter(fr);
			sw.Write(codetext);
			sw.Close();
			fr.Close();



			//添加文件到项目中
			var aa = project.ProjectItems.AddFromFile(createpath);

			project.ProjectItems.Item(0).Remove();

			return aa;

		}

		//获取选中文件全路径
		private SelectedItem GetProjectItemSel()
		{

			//从被选中对象中获取工程对象 
			EnvDTE.SelectedItem item = _applicationObject.SelectedItems.Item(1);

			//string selectpath = item.ProjectItem.Properties.Item("FullPath").Value.ToString();

			return item;
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

		/// <summary>实现 IDTExtensibility2 接口的 OnDisconnection 方法。接收正在卸载外接程序的通知。</summary>
		/// <param term='disconnectMode'>描述外接程序的卸载方式。</param>
		/// <param term='custom'>特定于宿主应用程序的参数数组。</param>
		/// <seealso class='IDTExtensibility2' />
		///  OnDisconnection（）函数：系统卸载插件时被调用
		public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
		{
		}

		/// <summary>实现 IDTExtensibility2 接口的 OnAddInsUpdate 方法。当外接程序集合已发生更改时接收通知。</summary>
		/// <param term='custom'>特定于宿主应用程序的参数数组。</param>
		/// <seealso class='IDTExtensibility2' />		
		public void OnAddInsUpdate(ref Array custom)
		{
		}

		/// <summary>实现 IDTExtensibility2 接口的 OnStartupComplete 方法。接收宿主应用程序已完成加载的通知。</summary>
		/// <param term='custom'>特定于宿主应用程序的参数数组。</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnStartupComplete(ref Array custom)
		{
		}

		/// <summary>实现 IDTExtensibility2 接口的 OnBeginShutdown 方法。接收正在卸载宿主应用程序的通知。</summary>
		/// <param term='custom'>特定于宿主应用程序的参数数组。</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnBeginShutdown(ref Array custom)
		{
		}

		private DTE2 _applicationObject;
		private AddIn _addInInstance;
		private DTE _applicationDTE;

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		static extern bool GetCaretPos(ref Point IpPoint);
	}



}