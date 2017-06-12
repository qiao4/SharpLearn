namespace SharpLearn.Forms {
    partial class FormQRCode {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.qrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Noto Sans CJK SC Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message.Location = new System.Drawing.Point(141, 12);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(503, 108);
            this.message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(672, 15);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 2;
            this.generate.Text = "confirm";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // qrcode
            // 
            this.qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrcode.Location = new System.Drawing.Point(141, 146);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(350, 346);
            this.qrcode.TabIndex = 3;
            this.qrcode.TabStop = false;
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 521);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Name = "FormQRCode";
            this.Text = "Generate QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.PictureBox qrcode;
    }
}