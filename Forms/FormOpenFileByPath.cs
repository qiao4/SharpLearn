/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/7
 * 时间: 22:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn.Forms
{
	/// <summary>
	/// Description of FormOpenFileByPath.
	/// </summary>
	public partial class FormOpenFileByPath : Form
	{
		public FormOpenFileByPath()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void OpenClick(object sender, EventArgs e) {
			try {
				System.Diagnostics.Process.Start(inputPath.Text);
			} catch(Exception ex) {
				MessageBox.Show("error,maybe wrong path");
			}
		}
	}
}
