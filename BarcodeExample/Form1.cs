using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox.Image = barcode.Draw(txtBarcode.Text, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox.Image = qrcode.Draw(txtQRCode.Text, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        //This is the part where printing happen
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
