/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/11/2
 * 时间: 22:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SharpLearn
{
	/// <summary>
	/// Send Message by ip in lan
	/// </summary>
	public partial class FormSendMessage : Form
	{
		Program p;
		
		public delegate void SetTextBoxValue(string value);
		private void SetMyTextBoxValue(string value)
        {
            if (textboxMessage.InvokeRequired)
            {
                SetTextBoxValue objSetTextBoxValue = new SetTextBoxValue(SetMyTextBoxValue);
                IAsyncResult result = this.textboxMessage.BeginInvoke(objSetTextBoxValue, new object[] { value });
                try
                {
                    objSetTextBoxValue.EndInvoke(result);
                }
                catch
                {
                }
            }
            else
            {
                this.textboxMessage.Text += value + Environment.NewLine;
            }
        }
		
		public FormSendMessage(Program p)
		{
			InitializeComponent();
			
			this.p = p;
		}
		void ButtonSendClick(object sender, EventArgs e)
		{
			p.SendMessage(inputIp.Text, inputMessage.Text);
		}
		void FormSendMessageLoad(object sender, EventArgs e)
		{
			System.Threading.Thread newThread = new System.Threading.Thread(StartListen);
			newThread.IsBackground = true;
			newThread.Start();
		}
		
		public void StartListen() {
			Socket s = null;
			try {
				IPAddress ipa = IPAddress.Parse("192.168.1.102");
				IPEndPoint ipp = new IPEndPoint(IPAddress.Any, 8091);
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
					SetMyTextBoxValue(string.Format("{0} --ip:{1} in {2}", UTF8Encoding.Default.GetString(message), ((IPEndPoint)point).Address, DateTime.Now));
					
				}
			} catch (Exception e) {
				string error = e.StackTrace;
			} finally {
				if(s != null) {
					s.Close();
				}
			}
		}
	}
}
