using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4Attribute
{
	[AttributeUsage(AttributeTargets.Class)]
	public class T4ClassAttribute : Attribute
	{
		public string Author;  //开发者名字

		public T4ClassAttribute(string author)
		{
			this.Author = author;
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class T4PropertyAttribute : Attribute
	{
		public string DisplayName;  //打印的名字
		public bool IsOutput;  //是否打印

		public T4PropertyAttribute(string DisplayName, bool IsOutput)
		{
			this.DisplayName = DisplayName;
			this.IsOutput = IsOutput;
		}
	}
}