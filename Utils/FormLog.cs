/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/12/6
 * 时间: 21:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn.Utils
{
	/// <summary>
	/// Description of FormLog.
	/// </summary>
	public partial class FormLog : Form
	{
		private delegate void AppendLog(String log);
		
		public void appendLog(String log) {
			if(this.InvokeRequired) {
				AppendLog a = new FormLog.AppendLog(appendLog);
				this.Invoke(a, new object[]{log});
			} else {
				inputLog.AppendText(log + "\n");
			}
		}
		
		public FormLog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
