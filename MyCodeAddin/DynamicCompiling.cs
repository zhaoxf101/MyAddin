using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace MyCodeAddin
{
	class DynamicCompiling
	{
		public static object Compo(string code)
		{
			string liststr = "";
			// 1.CSharpCodePrivoder
			CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

			// 2.ICodeComplier
			ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

			// 3.CompilerParameters
			CompilerParameters objCompilerParameters = new CompilerParameters();
			objCompilerParameters.ReferencedAssemblies.Add("System.dll");
			objCompilerParameters.ReferencedAssemblies.Add("System.Core.dll");
			objCompilerParameters.ReferencedAssemblies.Add(Application.StartupPath + "\\T4Attribute.dll");
			objCompilerParameters.GenerateExecutable = false;
			objCompilerParameters.GenerateInMemory = true;

			// 4.CompilerResults
			CompilerResults cr = objICodeCompiler.CompileAssemblyFromSource(objCompilerParameters, code);

			if (cr.Errors.HasErrors)
			{
				foreach (CompilerError err in cr.Errors)
				{
					liststr = liststr + err.ErrorText + "\r\n";

				}
				return liststr;
			}
			else
			{
				// 通过反射，调用objmodel的实例
				Assembly objAssembly = cr.CompiledAssembly;
				object objmodel = objAssembly.CreateInstance(objAssembly.GetTypes().FirstOrDefault().ToString());
				return objmodel;
			}
		}
	}
}