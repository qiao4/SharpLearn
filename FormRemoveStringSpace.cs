/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/11/17
 * 时间: 22:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn
{
	/// <summary>
	/// Description of FormRemoveStringSpace.
	/// </summary>
	public partial class FormRemoveStringSpace : Form
	{
		Program p;
		
		public FormRemoveStringSpace(Program p)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.p = p;
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			textBox1.Text = p.Remove(textBox1.Text);
		}
	}
}
