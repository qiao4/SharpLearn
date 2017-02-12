/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/12
 * 时间: 21:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn
{
	/// <summary>
	/// Description of FormTemp.
	/// </summary>
	public partial class FormTemp : Form
	{
		delegate String D(String t, int i);
		public FormTemp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LambdaTestMouseHover(object sender, EventArgs e) {
			ToolTip t = new ToolTip();
			t.Show("repeat String some times", lambdaTest);
		}
		void LambdaTestClick(object sender, EventArgs e) {
			String test = "abc";
			int num = 10;
			
			D d = (String test1, int num2) => {
				if(num2 < 1) return test1;
				String t = "";
				for(int i = 0; i < num2 - 1; i++) {
					t += test1;
				}
				return t;
			};
			Program.log(d(test, num));
		}
		
	}
}
