namespace QlyLab
{
    partial class RESISTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESISTER));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txt_rtype = new System.Windows.Forms.TextBox();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(171, 82);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(135, 20);
            this.txtuser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(41, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(41, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "RETYPE PASS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(90, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sign up";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(171, 124);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(135, 20);
            this.txtphone.TabIndex = 13;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(171, 167);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(135, 20);
            this.txtpass.TabIndex = 14;
            // 
            // txt_rtype
            // 
            this.txt_rtype.Location = new System.Drawing.Point(171, 208);
            this.txt_rtype.Name = "txt_rtype";
            this.txt_rtype.Size = new System.Drawing.Size(135, 20);
            this.txt_rtype.TabIndex = 15;
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.Tomato;
            this.btn_dangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dangky.Location = new System.Drawing.Point(44, 255);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(252, 39);
            this.btn_dangky.TabIndex = 16;
            this.btn_dangky.Text = "CONFIRM";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click_1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(44, 310);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(252, 39);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // RESISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(341, 366);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.txt_rtype);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Name = "RESISTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESISTER";
            this.Load += new System.EventHandler(this.RESISTER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txt_rtype;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Button btn_Cancel;
    }
}