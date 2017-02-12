/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/12
 * 时间: 21:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn
{
	partial class FormTemp
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button lambdaTest;
		
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
			this.lambdaTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lambdaTest
			// 
			this.lambdaTest.Location = new System.Drawing.Point(12, 26);
			this.lambdaTest.Name = "lambdaTest";
			this.lambdaTest.Size = new System.Drawing.Size(102, 23);
			this.lambdaTest.TabIndex = 0;
			this.lambdaTest.Text = "lambda test";
			this.lambdaTest.UseVisualStyleBackColor = true;
			this.lambdaTest.Click += new System.EventHandler(this.LambdaTestClick);
			this.lambdaTest.MouseHover += new System.EventHandler(this.LambdaTestMouseHover);
			// 
			// FormTemp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 307);
			this.Controls.Add(this.lambdaTest);
			this.Name = "FormTemp";
			this.Text = "FormTemp";
			this.ResumeLayout(false);

		}
	}
}
