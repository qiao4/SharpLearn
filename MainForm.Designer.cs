﻿/*
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 358);
			this.Controls.Add(this.buttonThreadTest);
			this.Controls.Add(this.buttonRomove);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "SharpLearn";
			this.ResumeLayout(false);

		}
	}
}
