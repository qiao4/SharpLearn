/*
 * 由SharpDevelop创建。
 * 用户： zhangbin
 * 日期: 2016/11/2
 * 时间: 22:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn
{
	/// <summary>
	/// Send Message by ip in lan
	/// </summary>
	public partial class FormSendMessage : Form
	{
		Program p;
		
		public FormSendMessage(Program p)
		{
			InitializeComponent();
			
			this.p = p;
		}
		void ButtonSendClick(object sender, EventArgs e)
		{
			p.SendMessage(inputIp.Text, inputMessage.Text);
		}
	}
}
