/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/11/2
 * 时间: 22:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonRomove;
		private System.Windows.Forms.Button buttonThreadTest;
		private System.Windows.Forms.Button buttonFormatStr;
		private System.Windows.Forms.Button openFile;
		private System.Windows.Forms.Button tempTest;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.buttonRomove = new System.Windows.Forms.Button();
			this.buttonThreadTest = new System.Windows.Forms.Button();
			this.buttonFormatStr = new System.Windows.Forms.Button();
			this.openFile = new System.Windows.Forms.Button();
			this.tempTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "send message";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// buttonRomove
			// 
			this.buttonRomove.Location = new System.Drawing.Point(12, 41);
			this.buttonRomove.Name = "buttonRomove";
			this.buttonRomove.Size = new System.Drawing.Size(104, 23);
			this.buttonRomove.TabIndex = 1;
			this.buttonRomove.Text = "remove space";
			this.buttonRomove.UseVisualStyleBackColor = true;
			this.buttonRomove.Click += new System.EventHandler(this.ButtonRomoveClick);
			// 
			// buttonThreadTest
			// 
			this.buttonThreadTest.Location = new System.Drawing.Point(12, 100);
			this.buttonThreadTest.Name = "buttonThreadTest";
			this.buttonThreadTest.Size = new System.Drawing.Size(104, 23);
			this.buttonThreadTest.TabIndex = 2;
			this.buttonThreadTest.Text = "thread test";
			this.buttonThreadTest.UseVisualStyleBackColor = true;
			this.buttonThreadTest.Click += new System.EventHandler(this.ButtonThreadTestClick);
			// 
			// buttonFormatStr
			// 
			this.buttonFormatStr.Location = new System.Drawing.Point(13, 139);
			this.buttonFormatStr.Name = "buttonFormatStr";
			this.buttonFormatStr.Size = new System.Drawing.Size(104, 23);
			this.buttonFormatStr.TabIndex = 3;
			this.buttonFormatStr.Text = "format string";
			this.buttonFormatStr.UseVisualStyleBackColor = true;
			this.buttonFormatStr.Click += new System.EventHandler(this.ButtonFormatStrClick);
			// 
			// openFile
			// 
			this.openFile.Location = new System.Drawing.Point(13, 190);
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(103, 31);
			this.openFile.TabIndex = 4;
			this.openFile.Text = "open file";
			this.openFile.UseVisualStyleBackColor = true;
			this.openFile.Click += new System.EventHandler(this.OpenFileClick);
			// 
			// tempTest
			// 
			this.tempTest.Location = new System.Drawing.Point(13, 228);
			this.tempTest.Name = "tempTest";
			this.tempTest.Size = new System.Drawing.Size(103, 30);
			this.tempTest.TabIndex = 5;
			this.tempTest.Text = "Temp Test";
			this.tempTest.UseVisualStyleBackColor = true;
			this.tempTest.Click += new System.EventHandler(this.TempTestClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 358);
			this.Controls.Add(this.tempTest);
			this.Controls.Add(this.openFile);
			this.Controls.Add(this.buttonFormatStr);
			this.Controls.Add(this.buttonThreadTest);
			this.Controls.Add(this.buttonRomove);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "SharpLearn";
			this.ResumeLayout(false);

		}
	}
}
