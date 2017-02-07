/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/7
 * 时间: 22:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn.Forms
{
	partial class FormOpenFileByPath
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputPath;
		private System.Windows.Forms.Button open;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.inputPath = new System.Windows.Forms.TextBox();
			this.open = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "path";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputPath
			// 
			this.inputPath.Location = new System.Drawing.Point(93, 64);
			this.inputPath.Name = "inputPath";
			this.inputPath.Size = new System.Drawing.Size(390, 21);
			this.inputPath.TabIndex = 1;
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(490, 62);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(75, 23);
			this.open.TabIndex = 2;
			this.open.Text = "open";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.OpenClick);
			// 
			// FormOpenFileByPath
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 342);
			this.Controls.Add(this.open);
			this.Controls.Add(this.inputPath);
			this.Controls.Add(this.label1);
			this.Name = "FormOpenFileByPath";
			this.Text = "FormOpenFileByPath";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
