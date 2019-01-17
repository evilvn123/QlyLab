using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QlyLab
{
   
    public partial class Dangnhap : Form
    {
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["QlyLab.Properties.Settings.QlyLabConnectionString"].ConnectionString;
        #region quan ly form
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            txtuser.Text = Properties.Settings.Default.Username;
            txtpass.Text = Properties.Settings.Default.Password;
            forgot_pass.LinkBehavior = LinkBehavior.NeverUnderline;
            link_resister.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void Dangnhap_Shown(object sender, EventArgs e)
        {

        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
            }
        }


        #endregion

        private void btn_signin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string user = txtuser.Text;
                string pass = txtpass.Text;
                string sql = "select *from Dangnhap where username = '" + user + "' and pass = '" + pass + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    Qlythietbi thietbi = new Qlythietbi();
                    thietbi.ShowDialog();

                }
                else
                {
                    DialogResult tb = MessageBox.Show("Dang nhap that bai! \nTai khoan khong ton tai !!!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (tb == DialogResult.Retry)
                    {                     
                        txtpass.Clear();
                        txtpass.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect database error");
            }

            if (chk_remember.Checked)
            {
                Properties.Settings.Default.Username = txtuser.Text;
                Properties.Settings.Default.Password = txtpass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Thoát ứng dụng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();           
            }
        }

        

        private void chk_visiblePass_CheckedChanged(object sender, EventArgs e)
        {
            if(!chk_visiblePass.Checked)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void forgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgot_pass forgot = new forgot_pass();
            forgot.ShowDialog();
        }

        private void link_resister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RESISTER resister = new RESISTER();
            resister.ShowDialog();

        }

        
    }
}
