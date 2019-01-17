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
    public partial class forgot_pass : Form
    {
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["QlyLab.Properties.Settings.QlyLabConnectionString"].ConnectionString;
        public forgot_pass()
        {
            InitializeComponent();
        }
        
        private void forgot_pass_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
        }

        private void forgot_pass_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string user = txtuser.Text;
            string sdt = txtsdt.Text;
            string pass = txtpass.Text;
            string rtype_pass = txtretype_pass.Text;
            string sql = "select *from Dangnhap where username = '" + user + "' and sdt = '" + sdt + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                if (pass == "")
                {
                    MessageBox.Show("Chưa nhập pass ?");
                }
                else if (pass != rtype_pass)
                {
                    MessageBox.Show("Mật khẩu sai khác", "Thông báo", MessageBoxButtons.RetryCancel,  MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(chuoiketnoi);
                    conn.Open();
                    string sqlEDIT = "UPDATE Dangnhap SET username = @user, pass = @pass, sdt = @sdt WHERE user= @user";
                    SqlCommand sss = new SqlCommand(sqlEDIT, conn);
                    sss.Parameters.AddWithValue("user", txtuser.Text);
                    sss.Parameters.AddWithValue("pass", txtpass.Text);
                    sss.Parameters.AddWithValue("sdt", txtsdt.Text);
                    sss.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công !");
                    this.Hide();
                    Dangnhap dangnhap = new Dangnhap();
                    dangnhap.ShowDialog();
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Số điện thoại xác nhận không đúng ?");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RESISTER resister = new RESISTER();
            resister.ShowDialog();
        }
    }
}
