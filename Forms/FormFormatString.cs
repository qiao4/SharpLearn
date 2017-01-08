/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/12/26
 * 时间: 22:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn.Forms
{
	/// <summary>
	/// Description of FormFormatString.
	/// </summary>
	public partial class FormFormatString : Form
	{
		public FormFormatString()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonFormatClick(object sender, EventArgs e)
		{
//			Program.log(inputStr.Text.ToString(inputFormatString.Text));
			Program.log(Convert.ToInt32(inputStr.Text).ToString(inputFormatString.Text));
		}
	}
}
