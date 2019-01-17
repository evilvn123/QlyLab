namespace QlyLab
{
    partial class ScanQRcode
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Scan = new System.Windows.Forms.ToolStripMenuItem();
            this.decode = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfile = new System.Windows.Forms.Button();
            this.btndecode = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbxTenCamera = new System.Windows.Forms.ComboBox();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Scan,
            this.decode});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Scan
            // 
            this.Scan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(55, 20);
            this.Scan.Text = "Scan";
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // decode
            // 
            this.decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(134, 20);
            this.decode.Text = "Decode from file";
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 308);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnfile
            // 
            this.btnfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnfile.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnfile.Location = new System.Drawing.Point(719, 383);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(123, 33);
            this.btnfile.TabIndex = 2;
            this.btnfile.Text = "Browse";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btndecode
            // 
            this.btndecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btndecode.ForeColor = System.Drawing.Color.SlateBlue;
            this.btndecode.Location = new System.Drawing.Point(570, 383);
            this.btndecode.Name = "btndecode";
            this.btndecode.Size = new System.Drawing.Size(134, 33);
            this.btndecode.TabIndex = 3;
            this.btndecode.Text = "Giải mã";
            this.btndecode.UseVisualStyleBackColor = true;
            this.btndecode.Click += new System.EventHandler(this.btndecode_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(570, 61);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(248, 308);
            this.txtresult.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbxTenCamera
            // 
            this.cbxTenCamera.FormattingEnabled = true;
            this.cbxTenCamera.Location = new System.Drawing.Point(294, 25);
            this.cbxTenCamera.MaximumSize = new System.Drawing.Size(200, 0);
            this.cbxTenCamera.Name = "cbxTenCamera";
            this.cbxTenCamera.Size = new System.Drawing.Size(180, 21);
            this.cbxTenCamera.TabIndex = 5;
            // 
            // btnketnoi
            // 
            this.btnketnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnketnoi.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnketnoi.Location = new System.Drawing.Point(503, 25);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(114, 23);
            this.btnketnoi.TabIndex = 6;
            this.btnketnoi.Text = "Start Scan";
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Camera:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnclear.Location = new System.Drawing.Point(643, 341);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 28);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(124, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 308);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Crimson;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnback.Location = new System.Drawing.Point(18, 28);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 33);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "<<Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ScanQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 444);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnketnoi);
            this.Controls.Add(this.cbxTenCamera);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btndecode);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScanQRcode";
            this.Text = "ScanQRcode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanQRcode_FormClosing);
            this.Load += new System.EventHandler(this.ScanQRcode_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Scan;
        private System.Windows.Forms.ToolStripMenuItem decode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btndecode;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbxTenCamera;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnback;
    }
}