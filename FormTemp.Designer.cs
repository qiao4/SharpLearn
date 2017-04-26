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
		private System.Windows.Forms.Button controlCollectionTest;
		
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
            this.controlCollectionTest = new System.Windows.Forms.Button();
            this.linqTest = new System.Windows.Forms.Button();
            this.dataColumnTest = new System.Windows.Forms.Button();
            this.stringEx = new System.Windows.Forms.Button();
            this.showTable = new System.Windows.Forms.Button();
            this.showMonthDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lambdaTest
            // 
            this.lambdaTest.Location = new System.Drawing.Point(16, 32);
            this.lambdaTest.Margin = new System.Windows.Forms.Padding(4);
            this.lambdaTest.Name = "lambdaTest";
            this.lambdaTest.Size = new System.Drawing.Size(136, 29);
            this.lambdaTest.TabIndex = 0;
            this.lambdaTest.Text = "lambda test";
            this.lambdaTest.UseVisualStyleBackColor = true;
            this.lambdaTest.Click += new System.EventHandler(this.LambdaTestClick);
            this.lambdaTest.MouseHover += new System.EventHandler(this.LambdaTestMouseHover);
            // 
            // controlCollectionTest
            // 
            this.controlCollectionTest.Location = new System.Drawing.Point(16, 84);
            this.controlCollectionTest.Margin = new System.Windows.Forms.Padding(4);
            this.controlCollectionTest.Name = "controlCollectionTest";
            this.controlCollectionTest.Size = new System.Drawing.Size(157, 48);
            this.controlCollectionTest.TabIndex = 1;
            this.controlCollectionTest.Text = "ControlCollection Test";
            this.controlCollectionTest.UseVisualStyleBackColor = true;
            this.controlCollectionTest.Click += new System.EventHandler(this.ControlCollectionTestClick);
            // 
            // linqTest
            // 
            this.linqTest.Location = new System.Drawing.Point(16, 166);
            this.linqTest.Name = "linqTest";
            this.linqTest.Size = new System.Drawing.Size(157, 39);
            this.linqTest.TabIndex = 2;
            this.linqTest.Text = "Linq Test";
            this.linqTest.UseVisualStyleBackColor = true;
            this.linqTest.Click += new System.EventHandler(this.linqTest_Click);
            // 
            // dataColumnTest
            // 
            this.dataColumnTest.Location = new System.Drawing.Point(16, 226);
            this.dataColumnTest.Name = "dataColumnTest";
            this.dataColumnTest.Size = new System.Drawing.Size(157, 36);
            this.dataColumnTest.TabIndex = 3;
            this.dataColumnTest.Text = "DataColumn Test";
            this.dataColumnTest.UseVisualStyleBackColor = true;
            this.dataColumnTest.Click += new System.EventHandler(this.dataColumnTest_Click);
            // 
            // stringEx
            // 
            this.stringEx.Location = new System.Drawing.Point(13, 284);
            this.stringEx.Name = "stringEx";
            this.stringEx.Size = new System.Drawing.Size(160, 33);
            this.stringEx.TabIndex = 4;
            this.stringEx.Text = "String Extension";
            this.stringEx.UseVisualStyleBackColor = true;
            this.stringEx.Click += new System.EventHandler(this.stringEx_Click);
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(276, 32);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(113, 23);
            this.showTable.TabIndex = 5;
            this.showTable.Text = "show table";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // showMonthDays
            // 
            this.showMonthDays.Location = new System.Drawing.Point(276, 84);
            this.showMonthDays.Name = "showMonthDays";
            this.showMonthDays.Size = new System.Drawing.Size(113, 33);
            this.showMonthDays.TabIndex = 6;
            this.showMonthDays.Text = "month days";
            this.showMonthDays.UseVisualStyleBackColor = true;
            this.showMonthDays.Click += new System.EventHandler(this.showMonthDays_Click);
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 384);
            this.Controls.Add(this.showMonthDays);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.stringEx);
            this.Controls.Add(this.dataColumnTest);
            this.Controls.Add(this.linqTest);
            this.Controls.Add(this.controlCollectionTest);
            this.Controls.Add(this.lambdaTest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.Load += new System.EventHandler(this.FormTempLoad);
            this.Resize += new System.EventHandler(this.FormTemp_Resize);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button linqTest;
        private System.Windows.Forms.Button dataColumnTest;
        private System.Windows.Forms.Button stringEx;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button showMonthDays;
    }
}
