namespace QlyLab
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.forgot_pass = new System.Windows.Forms.LinkLabel();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.chk_visiblePass = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.link_resister = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(104, 108);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(171, 26);
            this.txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(104, 158);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(171, 26);
            this.txtpass.TabIndex = 5;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signin.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_signin.FlatAppearance.BorderSize = 0;
            this.btn_signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_signin.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_signin.Location = new System.Drawing.Point(0, 253);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(314, 41);
            this.btn_signin.TabIndex = 7;
            this.btn_signin.Text = "Login";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // forgot_pass
            // 
            this.forgot_pass.AutoSize = true;
            this.forgot_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pass.ForeColor = System.Drawing.Color.Fuchsia;
            this.forgot_pass.Image = ((System.Drawing.Image)(resources.GetObject("forgot_pass.Image")));
            this.forgot_pass.LinkColor = System.Drawing.Color.Fuchsia;
            this.forgot_pass.Location = new System.Drawing.Point(165, 215);
            this.forgot_pass.Name = "forgot_pass";
            this.forgot_pass.Size = new System.Drawing.Size(137, 16);
            this.forgot_pass.TabIndex = 9;
            this.forgot_pass.TabStop = true;
            this.forgot_pass.Text = "Forgot Password ?";
            this.forgot_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_pass_LinkClicked);
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chk_remember.BackgroundImage")));
            this.chk_remember.Checked = true;
            this.chk_remember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_remember.ForeColor = System.Drawing.Color.Magenta;
            this.chk_remember.Location = new System.Drawing.Point(10, 215);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(128, 20);
            this.chk_remember.TabIndex = 10;
            this.chk_remember.Text = "Remember me";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // chk_visiblePass
            // 
            this.chk_visiblePass.AutoSize = true;
            this.chk_visiblePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chk_visiblePass.BackgroundImage")));
            this.chk_visiblePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_visiblePass.ForeColor = System.Drawing.Color.Magenta;
            this.chk_visiblePass.Location = new System.Drawing.Point(281, 170);
            this.chk_visiblePass.Name = "chk_visiblePass";
            this.chk_visiblePass.Size = new System.Drawing.Size(15, 14);
            this.chk_visiblePass.TabIndex = 11;
            this.chk_visiblePass.UseVisualStyleBackColor = true;
            this.chk_visiblePass.CheckedChanged += new System.EventHandler(this.chk_visiblePass_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.forgot_pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chk_remember);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.chk_visiblePass);
            this.groupBox1.Controls.Add(this.btn_signin);
            this.groupBox1.Location = new System.Drawing.Point(34, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 294);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(106, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(31, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Don\'t have an account ?";
            // 
            // link_resister
            // 
            this.link_resister.AutoSize = true;
            this.link_resister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_resister.ForeColor = System.Drawing.Color.DarkMagenta;
            this.link_resister.Image = ((System.Drawing.Image)(resources.GetObject("link_resister.Image")));
            this.link_resister.LinkColor = System.Drawing.Color.DarkMagenta;
            this.link_resister.Location = new System.Drawing.Point(218, 383);
            this.link_resister.Name = "link_resister";
            this.link_resister.Size = new System.Drawing.Size(130, 16);
            this.link_resister.TabIndex = 15;
            this.link_resister.TabStop = true;
            this.link_resister.Text = "RESISTER HERE";
            this.link_resister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_resister_LinkClicked);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 420);
            this.Controls.Add(this.link_resister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.Shown += new System.EventHandler(this.Dangnhap_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dangnhap_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.LinkLabel forgot_pass;
        private System.Windows.Forms.CheckBox chk_remember;
        private System.Windows.Forms.CheckBox chk_visiblePass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel link_resister;
    }
}

