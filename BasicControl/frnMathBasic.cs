using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frnMathBasic : Form
    {
        public frnMathBasic()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btncong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                long nsoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat + nsoThuHai;

                labelKQ.Text = ketQua.ToString("N2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không ký tự. Chi tiết lỗi: {ex.Message}");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn. vui lòng nhập số nhỏ. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé. Chi tiết lỗi: { ex.Message}");
            }
        }
    }
}
