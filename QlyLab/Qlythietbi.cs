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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


namespace QlyLab
{
    #region
    public partial class Qlythietbi : Form
    {
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["QlyLab.Properties.Settings.QlyLabConnectionString"].ConnectionString;
        public Qlythietbi()
        {
            InitializeComponent();
        }   

       /* private void KetNoiCSDL()
        {
            
             * con.Open(); //mo ket noi
            string sql = "select * from thietbi";
            SqlCommand com = new SqlCommand(sql, con);  //truy van du lieu
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //van chuyen du lieu
            DataTable dt = new DataTable();
            da.Fill(dt); //do du lieu vao table
            con.Close(); //dong ket noi
            dataGridView1.DataSource = dt;
        }*/



        private void Qlythietbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlyLabDataSet.thietbi' table. You can move, or remove it, as needed.
           // this.thietbiTableAdapter.Fill(this.qlyLabDataSet.thietbi);
           /* KetNoiCSDL();
            LoadData();*/
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            Hienthi();
            //LoadData();
            comboBox1.Items.Add("Tên thiết bị");
            comboBox1.Items.Add("Tình trạng");
            comboBox1.Items.Add("Nơi giữ");
            comboBox1.Items.Add("Người giữ");
            comboBox1.SelectedIndex = 0;

        }

       /* private void LoadData()
        {

            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dataGridView1.DataSource, "STT");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dataGridView1.DataSource, "ten");
            txtgia.DataBindings.Clear();
            txtgia.DataBindings.Add("Text", dataGridView1.DataSource, "gia");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dataGridView1.DataSource, "SL");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dataGridView1.DataSource, "trangthai");
            txtngaymua.DataBindings.Clear();
            txtngaymua.DataBindings.Add("Text", dataGridView1.DataSource, "ngaymua");
        }*/
        private void Qlythietbi_Shown(object sender, EventArgs e)
        {

        }

        private void Qlythietbi_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Close();
        }

        public void Hienthi()
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sqlSELECT = "SELECT STT, ten as Tên ,ghichu as 'Ghi chú', model as MODEL, SL as SL, tinhtrang as 'Tình trạng', noigiu as 'Nơi giữ', ngaycapnhat as 'Ngày cập nhật', phone as Phone from thietbi order by STT ASC";
            SqlCommand cmd = new SqlCommand(sqlSELECT,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void Qlythietbi_KeyDown(object sender, KeyEventArgs e)
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

    #endregion

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sqlINSERT = "INSERT INTO thietbi VALUES (@STT, @ten, @ghichu, @model ,@SL, @tinhtrang, @noigiu, @nguoigiu, @ngaycapnhat, @phone)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("STT", txtSTT.Text);
            cmd.Parameters.AddWithValue("ten", txtten.Text);
            cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
            cmd.Parameters.AddWithValue("model", txtModel.Text);
            cmd.Parameters.AddWithValue("SL", txtSL.Text);
            cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
            cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
            cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
            cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
            cmd.Parameters.AddWithValue("phone", textBox9.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            MessageBox.Show("Thêm thành công !");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sqlDEL = "delete from thietbi where STT = @STT";
            SqlCommand cmd = new SqlCommand(sqlDEL, con);
            cmd.Parameters.AddWithValue("STT", txtSTT.Text);
            cmd.Parameters.AddWithValue("ten", txtten.Text);
            cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
            cmd.Parameters.AddWithValue("model", txtModel.Text);
            cmd.Parameters.AddWithValue("SL", txtSL.Text);
            cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
            cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
            cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
            cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
            cmd.Parameters.AddWithValue("phone", textBox9.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            txtSTT.Focus();
            MessageBox.Show("Đã Xóa !");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sqlEDIT = "UPDATE thietbi SET ten = @ten, ghichu = @ghichu, model = @model, tinhtrang = @tinhtrang, noigiu = @noigiu, nguoigiu = @nguoigiu, ngaycapnhat = @ngaycapnhat, phone = @phone WHERE STT = @STT";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("STT", txtSTT.Text);
            cmd.Parameters.AddWithValue("ten", txtten.Text);
            cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
            cmd.Parameters.AddWithValue("model", txtModel.Text);
            cmd.Parameters.AddWithValue("SL", txtSL.Text);
            cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
            cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
            cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
            cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
            cmd.Parameters.AddWithValue("phone", textBox9.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            MessageBox.Show("Đã Sửa");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtSTT.Clear();
            txtten.Clear();
            txtghichu.Clear();
            txtModel.Clear();
            txtSL.Clear();
            txttinhtrang.Clear();
            txtnoigiu.Clear();
            txtnguoigiu.Clear();
            txtngaycapnhat.Clear();
            textBox9.Clear();
            txtSTT.Focus();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string gettext = comboBox1.SelectedItem.ToString();
            if (gettext == "Tên thiết bị")
            {
                SqlConnection con = new SqlConnection(chuoiketnoi);
                con.Open();
                string sqlFind = "SELECT *from thietbi where ten like '%' + @ten + '%'";
                SqlCommand cmd = new SqlCommand(sqlFind, con);
                cmd.Parameters.AddWithValue("STT", txtSTT.Text);
                cmd.Parameters.AddWithValue("ten", txtTimkiem.Text);
                cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                cmd.Parameters.AddWithValue("model", txtModel.Text);
                cmd.Parameters.AddWithValue("SL", txtSL.Text);
                cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
                cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
                cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
                cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
                cmd.Parameters.AddWithValue("phone", textBox9.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (gettext == "Tình trạng")
                   {
                       SqlConnection con = new SqlConnection(chuoiketnoi);
                       con.Open();
                       string sqlFind = "SELECT *from thietbi where tinhtrang like '%' + @tinhtrang + '%'";
                       SqlCommand cmd = new SqlCommand(sqlFind, con);
                       cmd.Parameters.AddWithValue("STT", txtSTT.Text);
                       cmd.Parameters.AddWithValue("ten", txtten.Text);
                       cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                       cmd.Parameters.AddWithValue("model", txtModel.Text);
                       cmd.Parameters.AddWithValue("SL", txtSL.Text);
                       cmd.Parameters.AddWithValue("tinhtrang", txtTimkiem.Text);
                       cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
                       cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
                       cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
                       cmd.Parameters.AddWithValue("phone", textBox9.Text);
                       cmd.ExecuteNonQuery();
                       SqlDataReader dr = cmd.ExecuteReader();
                       DataTable dt = new DataTable();
                       dt.Load(dr);
                       dataGridView1.DataSource = dt;
                   }
                     else if (gettext == "Nơi giữ")
                          {
                                SqlConnection con = new SqlConnection(chuoiketnoi);
                                con.Open();
                                string sqlFind = "SELECT *from thietbi where noigiu like '%' + @noigiu + '%'";
                                SqlCommand cmd = new SqlCommand(sqlFind, con);
                                cmd.Parameters.AddWithValue("STT", txtSTT.Text);
                                cmd.Parameters.AddWithValue("ten", txtten.Text);
                                cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                                cmd.Parameters.AddWithValue("model", txtModel.Text);
                                cmd.Parameters.AddWithValue("SL", txtSL.Text);
                                cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
                                cmd.Parameters.AddWithValue("noigiu", txtTimkiem.Text);
                                cmd.Parameters.AddWithValue("nguoigiu", txtnguoigiu.Text);
                                cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
                                cmd.Parameters.AddWithValue("phone", textBox9.Text);
                                cmd.ExecuteNonQuery();
                                SqlDataReader dr = cmd.ExecuteReader();
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                dataGridView1.DataSource = dt;
                          }
                          else if (gettext == "Người giữ")
                                 {
                                     SqlConnection con = new SqlConnection(chuoiketnoi);
                                     con.Open();
                                     string sqlFind = "SELECT *from thietbi where nguoigiu like '%' + @nguoigiu + '%'";
                                     SqlCommand cmd = new SqlCommand(sqlFind, con);
                                     cmd.Parameters.AddWithValue("STT", txtSTT.Text);
                                     cmd.Parameters.AddWithValue("ten", txtten.Text);
                                     cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                                     cmd.Parameters.AddWithValue("model", txtModel.Text);
                                     cmd.Parameters.AddWithValue("SL", txtSL.Text);
                                     cmd.Parameters.AddWithValue("tinhtrang", txttinhtrang.Text);
                                     cmd.Parameters.AddWithValue("noigiu", txtnoigiu.Text);
                                     cmd.Parameters.AddWithValue("nguoigiu", txtTimkiem.Text);
                                     cmd.Parameters.AddWithValue("ngaycapnhat", txtngaycapnhat.Text);
                                     cmd.Parameters.AddWithValue("phone", textBox9.Text);
                                     cmd.ExecuteNonQuery();
                                     SqlDataReader dr = cmd.ExecuteReader();
                                     DataTable dt = new DataTable();
                                     dt.Load(dr);
                                     dataGridView1.DataSource = dt;   
                                 }
           
          
           /* string sqlFind = "SELECT *from thietbi where ten like '%' + @ten + '%'";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.Parameters.AddWithValue("STT", txtSTT.Text);
            cmd.Parameters.AddWithValue("ten", txtTimkiem.Text);
            cmd.Parameters.AddWithValue("gia", txtgia.Text);
            cmd.Parameters.AddWithValue("SL", txtSL.Text);
            cmd.Parameters.AddWithValue("trangthai", txtTrangthai.Text);
            cmd.Parameters.AddWithValue("ngaymua", txtngaymua.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;*/
        
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thoát ứng dụng ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
        }

        private void btncreator_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin thiết bị!");
            }
            else
            {
                QRCodeEncoder endcoder = new QRCodeEncoder();

                Bitmap img = endcoder.Encode("Tên: " + txtten.Text + "\nGhi chú:" + txtghichu.Text + "\nTình trạng: " + txttinhtrang.Text + "\nNơi giữ: " + txtnoigiu.Text + "\nPhone: " + textBox9.Text + "\n ");
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "JPEG File|*.jpg";
                if (sd.ShowDialog() == DialogResult.OK) 
                {
                    img.Save(sd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    
                    MessageBox.Show("Tạo thành công !");
                }
                //img.Save("E:\\picture\\" + txtten.Text + "-" + txtghichu.Text + ".jpg");       
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txtSTT.Text = row.Cells[0].Value.ToString();
                txtten.Text = row.Cells[1].Value.ToString();
                txtghichu.Text = row.Cells[2].Value.ToString();
                txtModel.Text = row.Cells[3].Value.ToString();
                txtSL.Text = row.Cells[4].Value.ToString();
                txttinhtrang.Text = row.Cells[5].Value.ToString();
                txtnoigiu.Text = row.Cells[6].Value.ToString();
                
                txtngaycapnhat.Text = row.Cells[7].Value.ToString();
                textBox9.Text = row.Cells[8].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanQRcode scan = new ScanQRcode();
            scan.ShowDialog();
        }


        

     
    }
}
