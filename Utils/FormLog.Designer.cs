/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/12/6
 * 时间: 21:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn.Utils
{
	partial class FormLog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox inputLog;
		
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
			this.inputLog = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// inputLog
			// 
			this.inputLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputLog.Location = new System.Drawing.Point(0, 0);
			this.inputLog.Multiline = true;
			this.inputLog.Name = "inputLog";
			this.inputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.inputLog.Size = new System.Drawing.Size(772, 418);
			this.inputLog.TabIndex = 0;
			// 
			// FormLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 418);
			this.Controls.Add(this.inputLog);
			this.Name = "FormLog";
			this.Text = "FormLog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
