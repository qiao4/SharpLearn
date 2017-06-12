using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.google.zxing.qrcode;

namespace SharpLearn.Forms {
    public partial class FormQRCode : Form {
        public FormQRCode() {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e) {
            if(message.Text.Length == 0) {
                return;
            }
            QRCodeWriter writer = new QRCodeWriter();
            var matrix = writer.encode(message.Text, com.google.zxing.BarcodeFormat.QR_CODE, 
                qrcode.Width, qrcode.Height);
            qrcode.Image = matrix.ToBitmap();
        }
    }
}
