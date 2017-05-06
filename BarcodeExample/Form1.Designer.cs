namespace BarcodeExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(407, 219);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(142, 268);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(115, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode:";
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(263, 265);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(263, 294);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(75, 23);
            this.btnQRCode.TabIndex = 6;
            this.btnQRCode.Text = "QRCode";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "QRcode:";
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(142, 297);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(115, 20);
            this.txtQRCode.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(88, 346);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(250, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 381);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "QR Code and Bar Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnPrint;
    }
}

