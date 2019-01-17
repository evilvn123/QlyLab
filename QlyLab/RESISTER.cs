using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace QlyLab
{
    public partial class RESISTER : Form
    {
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["QlyLab.Properties.Settings.QlyLabConnectionString"].ConnectionString;
        
        public RESISTER()
        {
            InitializeComponent();
        }

        

        private void RESISTER_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
        }

        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
        }

        private void btn_dangky_Click_1(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string sdt = txtphone.Text;
            string pass = txtpass.Text;
            string rtype = txt_rtype.Text;
            if (user == "" || sdt == "" || pass == "" || rtype == "")
            {
                MessageBox.Show("Chưa điền đủ dữ liệu ? ");
                txtuser.Focus();
            }
            else
            {
                if (pass != rtype)
                {
                    DialogResult tb = MessageBox.Show("Pass khong hop le ?", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (tb == DialogResult.Retry)
                    {
                        txtpass.Focus();
                    }
                }
                else
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string sqlINSERT = "INSERT INTO Dangnhap VALUES (@username, @pass, @sdt)";
                    SqlCommand cmd = new SqlCommand(sqlINSERT,con);
                    cmd.Parameters.AddWithValue("username", txtuser.Text);
                    cmd.Parameters.AddWithValue("pass", txtpass.Text);
                    cmd.Parameters.AddWithValue("sdt", txtphone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký tài khoản thành công !!!");
                    this.Hide();
                    Dangnhap dangnhap = new Dangnhap();
                    dangnhap.ShowDialog();
                }
            }
        }

    }
}
