/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/11/22
 * 时间: 21:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SharpLearn
{
	/// <summary>
	/// Description of FormThreadTest.
	/// </summary>
	public partial class FormThreadTest : Form
	{
		private delegate void SetProgess(int pro);
		private BackgroundWorker bw;
		
		private void SetProcessBar(int pro) {
			if(this.InvokeRequired) {
				SetProgess s = new SetProgess(SetProcessBar);
				this.Invoke(s, new object[]{pro});
			} else {
				progress.Value = Convert.ToInt32(pro);
				label.Text = pro.ToString() + "%";
				
				//if use backgroundworker,dont need this because event RunWorkerCompleted
//				if(progress.Value >= 100) {
//					progress.Visible = false;
//					label.Visible = false;
//				}
				//endif
			}
		}
		
		public FormThreadTest()
		{
			InitializeComponent();
		}
		
		void FormThreadTestLoad(object sender, EventArgs e)
		{
			bw = new BackgroundWorker();
			
			bw.DoWork += new DoWorkEventHandler(bw_DoWork);
			bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
			
			//method no2
//			bw.DoWork += bw_DoWork;
//			bw.RunWorkerCompleted += bw_RunWorkerCompleted;
			
			//method no3
//			bw.DoWork += delegate { CountToHundred(); };
//			bw.RunWorkerCompleted += delegate {
//				progress.Visible = false;
//				label.Visible = false;
//			};
		}
		
		void ButtonStartClick(object sender, EventArgs e)
		{
			progress.Visible = true;
			label.Visible = true;
			
			MessageBox.Show("main threadid is " + System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
			
//			System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(CountToHundred));
//			t.Start();
			
			bw.RunWorkerAsync();
		}
		
		void ButtonIncreaseClick(object sender, EventArgs e)
		{
			if(progress.Value <= 80) {
				progress.Value += 20;
			} else {
				progress.Value = 100;
			}
		}
		
		public void CountToHundred() {
			MessageBox.Show("sub threadid is " + System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
			for(int i = 0; i <= 100; i++) {
				System.Threading.Thread.Sleep(200);
				SetProcessBar(i);
			}
		}
		
		void bw_DoWork(object sender, DoWorkEventArgs e)
		{
			CountToHundred();
		}

		void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			progress.Visible = false;
			label.Visible = false;
		}
	}
}
