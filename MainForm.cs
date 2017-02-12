/*
 * 由SharpDevelop创建。
 * 用户： qiao4
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
			this.StartPosition = FormStartPosition.Manual;
			Program.log("location x is " + (this.Location.X + this.Size.Width + 5).ToString());
			Program.logger.SetDesktopLocation(this.Location.X + this.Size.Width + 5, 0);
			Program.logger.Location = new Point(this.Location.X + this.Size.Width + 25, 0);
			Program.logger.StartPosition = FormStartPosition.Manual;
			Program.logger.Show();
			Program.log(Program.logger.Location.ToString());
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Program.log("clicked button 1");
			FormSendMessage f = new FormSendMessage(p);
			f.ShowDialog();
		}
		void ButtonRomoveClick(object sender, EventArgs e)
		{
			FormRemoveStringSpace form = new FormRemoveStringSpace(p);
			form.ShowDialog();
		}
		void ButtonThreadTestClick(object sender, EventArgs e)
		{
			Form f = new FormThreadTest();
			f.ShowDialog();
			
			//code generate
			try {
				
			} catch (Exception) {
				
				throw;
			} finally {
				
			}
		}
		void ButtonFormatStrClick(object sender, EventArgs e)
		{
			Form f = new Forms.FormFormatString();
			f.ShowDialog();
		}
		void OpenFileClick(object sender, EventArgs e) {
			Form f = new Forms.FormOpenFileByPath();
			f.ShowDialog();
		}
		void TempTestClick(object sender, EventArgs e) {
			Form f = new FormTemp();
			f.Show();
		}
		
		
	}
}
