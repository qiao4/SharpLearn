/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/11/22
 * 时间: 21:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn
{
	partial class FormThreadTest
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonIncrease;
		private System.Windows.Forms.ProgressBar progress;
		private System.Windows.Forms.Label label;
		
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonIncrease = new System.Windows.Forms.Button();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(40, 25);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// buttonIncrease
			// 
			this.buttonIncrease.Location = new System.Drawing.Point(334, 25);
			this.buttonIncrease.Name = "buttonIncrease";
			this.buttonIncrease.Size = new System.Drawing.Size(75, 23);
			this.buttonIncrease.TabIndex = 1;
			this.buttonIncrease.Text = "+";
			this.buttonIncrease.UseVisualStyleBackColor = true;
			this.buttonIncrease.Click += new System.EventHandler(this.ButtonIncreaseClick);
			// 
			// progress
			// 
			this.progress.Location = new System.Drawing.Point(83, 119);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(100, 23);
			this.progress.TabIndex = 2;
			this.progress.Visible = false;
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(190, 118);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 3;
			this.label.Text = "0";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label.Visible = false;
			// 
			// FormThreadTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 313);
			this.Controls.Add(this.label);
			this.Controls.Add(this.progress);
			this.Controls.Add(this.buttonIncrease);
			this.Controls.Add(this.buttonStart);
			this.Name = "FormThreadTest";
			this.Text = "FormThreadTest";
			this.Load += new System.EventHandler(this.FormThreadTestLoad);
			this.ResumeLayout(false);

		}
	}
}
