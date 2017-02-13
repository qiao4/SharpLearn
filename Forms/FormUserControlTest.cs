/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/13
 * 时间: 13:11
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn.Forms
{
	/// <summary>
	/// Description of FormUserControlTest.
	/// </summary>
	public partial class FormUserControlTest : Form
	{
		public FormUserControlTest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Controls.UserControlTest t = new SharpLearn.Controls.UserControlTest();
			panel1.Controls.Add(t);
		}
	}
}
