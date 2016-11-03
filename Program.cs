/*
 * 由SharpDevelop创建。
 * 用户： zhangbin
 * 日期: 2016/11/2
 * 时间: 22:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SharpLearn
{
	/// <summary>
	/// controller class
	/// </summary>
	public sealed class Program
	{
		static Program p = new Program();
		int port = 8091;
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(p));
		}
		
		
		public bool SendMessage(String ip, String message) {
			Socket s = null;
			try {
				IPAddress ipa = IPAddress.Parse(ip);
				IPEndPoint ipp = new IPEndPoint(ipa, port);
				s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
				                      ProtocolType.Udp);
				byte[] bs = UTF8Encoding.Default.GetBytes(message);
				
				byte[] data = new byte[bs.Length + 1];
				new byte[]{(byte)bs.Length}.CopyTo(data,0);
				bs.CopyTo(data, 1);
				s.Connect(ipp);
				s.Send(data, data.Length, 0);
			} catch (Exception e) {
				MessageBox.Show(e.StackTrace);
			} finally {
				if(s != null) {
					s.Close();
				}
			}
			return true;
		}
		
	}
}
