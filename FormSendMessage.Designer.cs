/*
 * 由SharpDevelop创建。
 * 用户： zhangbin
 * 日期: 2016/11/2
 * 时间: 22:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn
{
	partial class FormSendMessage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox inputMessage;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputIp;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.TextBox textboxMessage;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputMessage = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.inputIp = new System.Windows.Forms.TextBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.textboxMessage = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textboxMessage);
			this.panel1.Controls.Add(this.inputMessage);
			this.panel1.Controls.Add(this.buttonSend);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.inputIp);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(575, 316);
			this.panel1.TabIndex = 0;
			// 
			// inputMessage
			// 
			this.inputMessage.Location = new System.Drawing.Point(30, 66);
			this.inputMessage.Name = "inputMessage";
			this.inputMessage.Size = new System.Drawing.Size(227, 21);
			this.inputMessage.TabIndex = 3;
			this.inputMessage.Text = "test";
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(302, 12);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.ButtonSendClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "ip";
			// 
			// inputIp
			// 
			this.inputIp.Location = new System.Drawing.Point(103, 12);
			this.inputIp.Name = "inputIp";
			this.inputIp.Size = new System.Drawing.Size(154, 21);
			this.inputIp.TabIndex = 0;
			this.inputIp.Text = "192.168.1.100";
			// 
			// textboxMessage
			// 
			this.textboxMessage.Location = new System.Drawing.Point(30, 94);
			this.textboxMessage.Multiline = true;
			this.textboxMessage.Name = "textboxMessage";
			this.textboxMessage.Size = new System.Drawing.Size(347, 180);
			this.textboxMessage.TabIndex = 4;
			// 
			// FormSendMessage
			// 
			this.AcceptButton = this.buttonSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 316);
			this.Controls.Add(this.panel1);
			this.Name = "FormSendMessage";
			this.Text = "FormSendMessage";
			this.Load += new System.EventHandler(this.FormSendMessageLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
