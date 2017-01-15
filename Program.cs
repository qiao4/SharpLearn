/*
 * 由SharpDevelop创建。
 * 用户： qiao4
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
using System.Threading;

namespace SharpLearn
{
	/// <summary>
	/// controller class
	/// </summary>
	public sealed class Program
	{
		static Program p = new Program();
		public static Utils.FormLog logger;
		int port = 8091;
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			logger = new Utils.FormLog();
			Application.Run(new MainForm(p));
		}
		
		public void ForOthers()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			logger = new Utils.FormLog();
			Application.Run(new MainForm(p));
		}
		
		//send message by udp in lan
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
		
		//listen port 8091 by udp
		public void StartListen(object textbox) {
			TextBox tb = textbox as TextBox;
			Socket s = null;
			try {
				IPAddress ipa = IPAddress.Parse("192.168.1.102");
				IPEndPoint ipp = new IPEndPoint(IPAddress.Any, port);
				s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
				               ProtocolType.Udp);
				s.Bind(ipp);
				while(true) {
					EndPoint point = new IPEndPoint(IPAddress.Any, 0);//用来保存发送方的ip和端口号
					byte[] data = new byte[1024];
					s.ReceiveFrom(data, ref point);//接收数据报
					int length = data[0];
					byte[] message = new byte[length];
					Buffer.BlockCopy(data, 1, message, 0,message.Length);
					MessageBox.Show(UTF8Encoding.Default.GetString(message));
					tb.AppendText(UTF8Encoding.Default.GetString(message));
				}
			} catch (Exception e) {
				string error = e.StackTrace;
			} finally {
				if(s != null) {
					s.Close();
				}
			}
		}
		
		//receive message
		public void ReceiveMessage(object ss) {
			Socket s = (Socket)ss;
			byte[] data = new byte[1024];
			s.Receive(data, data.Length, 0);
			int length = data[0];
			byte[] message = new byte[length];
			Buffer.BlockCopy(data, 1, message, 0,message.Length);
			MessageBox.Show(UTF8Encoding.Default.GetString(message));
			s.Close();
		}
		
		public String Remove(String str) {
			return str.Replace(" ", "");
		}
		
		
		public static void log(String logMessage) {
			logger.appendLog(logMessage);
		}
	}
}
