/*
 * 由SharpDevelop创建。
 * 用户： qiao4
 * 日期: 2017/2/12
 * 时间: 21:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpLearn {
    /// <summary>
    /// Description of FormTemp.
    /// </summary>
    public partial class FormTemp : Form {
        delegate String D(String t, int i);
        ToolTip t = new ToolTip();
        public FormTemp() {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void LambdaTestMouseHover(object sender, EventArgs e) {
            //			ToolTip t = new ToolTip();
            ////			t.Show("repeat String some times", lambdaTest);
            //			t.SetToolTip(lambdaTest, "repeat String some times");
        }
        void LambdaTestClick(object sender, EventArgs e) {
            String test = "abc";
            int num = 10;

            D d = (String test1, int num2) => {
                if (num2 < 1) return test1;
                String t = "";
                for (int i = 0; i < num2 - 1; i++) {
                    t += test1;
                }
                return t;
            };
            Program.log(d(test, num));
        }

        void FormTempLoad(object sender, EventArgs e) {
            t.SetToolTip(lambdaTest, "repeat String some times");
        }

        void ControlCollectionTestClick(object sender, EventArgs e) {
            Panel p = new Panel();
            p.Size = new Size(40, 50);

            Label l1 = new Label();
            l1.Text = "1";
            l1.Size = new Size(40, 25);
            l1.Dock = DockStyle.Top;
            l1.BackColor = Color.LightBlue;
            Label l2 = new Label();
            l2.Text = "2";
            l2.Size = new Size(40, 25);
            l2.Dock = DockStyle.Top;
            l2.BackColor = Color.LightGray;
            p.Controls.Add(l1);
            p.Controls.Add(l2);

            foreach (Control c in p.Controls) {
                if (c is Label) {
                    Program.log("Text is " + (c as Label).Text +
                                " | TabIndex is " + (c as Label).TabIndex.ToString());
                }
            }
            p.Location = new Point(this.Width - 2 * p.Width, this.Height - 2 * p.Height);
            this.Controls.Add(p);
            foreach (Control c in this.Controls) {
                Program.log("Text is " + c.Text +
                            " | TabIndex is " + c.TabIndex.ToString());
            }
        }

        private void linqTest_Click(object sender, EventArgs e) {
            Program.LinqTest();
        }

        private void dataColumnTest_Click(object sender, EventArgs e) {
            Program.DataColumnTest();
        }
    }
}
