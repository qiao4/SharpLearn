/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/13
 * 时间: 13:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn.Controls
{
	/// <summary>
	/// Description of UserControlTest.
	/// </summary>
	public partial class UserControlTest : UserControl
	{
		String toolTip = "";
		public String ToolTip
		{
			get {
				return toolTip;
			}
			set {
				toolTip = value;
			}
		}
		public UserControlTest()
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
