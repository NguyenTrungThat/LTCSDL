using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCSDL
{
    public partial class FrmHocSinh : Form
    {
        public FrmHocSinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHS hs = new QLHS();
            hs.ThemMoi(Convert.ToInt32(txtMaHs.Text), txtTenHS.Text, txtDc.Text, ddNgaySinh.Value, txtDienThoai.Text);
            //Hien thi du hoc sinh vua them vào trong ds hoc sinh
            HocSinh objHs = hs.dshs[0];// FirstOrDefault()// Lấy 1 đối tượng đã thêm từ ds học sinh
            lblMaHS.Text = objHs.MaHs.ToString();// lấy giá trị ma hs hiên thị ra màn hình text box.
            lblTenHS.Text = objHs.TenHS;// Lấy tên học sinh hiển thị





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
