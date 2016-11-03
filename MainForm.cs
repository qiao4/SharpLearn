/*
 * 由SharpDevelop创建。
 * 用户： zhangbin
 * 日期: 2016/11/2
 * 时间: 22:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn
{
	/// <summary>
	/// the entrance of other tools
	/// </summary>
	public partial class MainForm : Form
	{
		Program p;
		
		public MainForm(Program p)
		{
			InitializeComponent();
			
			this.p = p;
		}
		void Button1Click(object sender, EventArgs e)
		{
			FormSendMessage f = new FormSendMessage(p);
			f.ShowDialog();
		}
		
		
	}
}
