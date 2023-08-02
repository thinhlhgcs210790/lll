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

namespace DOAN_QLBH.GUI
{
    public partial class frm_dangnhap : Form
    {
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
       
        public frm_dangnhap()
        {
            InitializeComponent();
           
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void tbn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = lopchung.connection();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from DangNhap where TenDangNhap = '" + txt_taikhoan.Text + "'and MatKhau = '" + txt_matkhau.Text + "'";
            comm.Connection = conn;
            conn.Open();
          
            SqlDataReader read = comm.ExecuteReader();
            if (read.Read() == true)
            {
                this.Hide();
                frm_main main = new frm_main();

                main.Show();

            }
            else
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox cảnh báo với tùy chọn Yes/No
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng nếu người dùng chọn "Yes"
                Application.Exit();
            }
            // Nếu người dùng chọn "No", không làm gì cả, form vẫn sẽ tiếp tục hoạt động
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
