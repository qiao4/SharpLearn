/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2016/12/26
 * 时间: 22:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace SharpLearn.Forms
{
	partial class FormFormatString
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox inputStr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inputFormatString;
		private System.Windows.Forms.Button buttonFormat;
		
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
			this.inputStr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.inputFormatString = new System.Windows.Forms.TextBox();
			this.buttonFormat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputStr
			// 
			this.inputStr.Location = new System.Drawing.Point(130, 39);
			this.inputStr.Name = "inputStr";
			this.inputStr.Size = new System.Drawing.Size(100, 21);
			this.inputStr.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "input string";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(261, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "format string";
			// 
			// inputFormatString
			// 
			this.inputFormatString.Location = new System.Drawing.Point(389, 39);
			this.inputFormatString.Name = "inputFormatString";
			this.inputFormatString.Size = new System.Drawing.Size(100, 21);
			this.inputFormatString.TabIndex = 3;
			// 
			// buttonFormat
			// 
			this.buttonFormat.Location = new System.Drawing.Point(56, 106);
			this.buttonFormat.Name = "buttonFormat";
			this.buttonFormat.Size = new System.Drawing.Size(75, 23);
			this.buttonFormat.TabIndex = 4;
			this.buttonFormat.Text = "format";
			this.buttonFormat.UseVisualStyleBackColor = true;
			this.buttonFormat.Click += new System.EventHandler(this.ButtonFormatClick);
			// 
			// FormFormatString
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 337);
			this.Controls.Add(this.buttonFormat);
			this.Controls.Add(this.inputFormatString);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputStr);
			this.Name = "FormFormatString";
			this.Text = "FormFormatString";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
