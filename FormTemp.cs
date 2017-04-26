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
using SharpLearn.Utils;
using System.Data;

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
            //MessageBox.Show(System.Windows.Forms.Screen
            //    .FromControl(this).Bounds.Width.ToString());
            //MessageBox.Show(this.Bounds.Width.ToString());
            //MessageBox.Show(new DateTime().Subtract(
            //    new DateTime().AddDays(1)).TotalMinutes.ToString());
            Program.log("this.Font is " + this.Font.ToString()
                + "\r\n 勉強's width is "
                + System.Windows.Forms.TextRenderer.MeasureText("勉強", this.Font).Width.ToString());
            this.Font = new System.Drawing.Font(
                "Noto Sans CJK JP Bold", 9F
                , System.Drawing.FontStyle.Bold
                , System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            Program.log("this.Font is " + this.Font.ToString()
                + "\r\n 勉強's width is "
                + System.Windows.Forms.TextRenderer.MeasureText("勉強", this.Font).Width.ToString());
        }

        private void FormTemp_Resize(object sender, EventArgs e) {
            Program.log("Width of form is " + this.Width.ToString());
            //this.Bounds.Width
            //
            //System.Windows.Forms.Screen.FromControl(this).Bounds.Width
        }

        private void stringEx_Click(object sender, EventArgs e) {
            String str = "tom' or (1=1) --";
            Program.log(String.Format("select 1 from user where user = {0} and psd = {1}", str, ""));
            Program.log(String.Format("select 1 from user where user = {0} and psd = {1}", str.Quote(), ""));
        }

        private void showTable_Click(object sender, EventArgs e) {
            DataTable tb = new DataTable();
            tb.Columns.Add(new DataColumn("name", Type.GetType("System.String")));
            tb.Columns.Add(new DataColumn("id", Type.GetType("System.Double")));

            DataRow dr = tb.NewRow();
            dr[0] = "tom";
            dr[1] = 0;
            tb.Rows.Add(dr);
            tb.AcceptChanges();
            Program.ShowTable(tb);

        }

        private void showMonthDays_Click(object sender, EventArgs e) {
            int i = (new Random().Next() % 12) + 1;
            DateTime dt = new DateTime(DateTime.Now.Year, i, 1);
            MessageBox.Show(dt.ToString("yyyy-MM : ") 
                + Program.GetWeekdayNum(dt) + " days");
        }
    }
}
