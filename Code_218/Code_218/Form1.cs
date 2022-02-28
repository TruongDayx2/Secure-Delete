using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Code_218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Sự kiện click xóa file
        private void xoa_Click(object sender, EventArgs e)
        {

            ThongBao2.Visible = false;

            String link_file = file_index.Text;
            if (!File.Exists(link_file))
            {
                MessageBox.Show("File không tồn tại");
            }
            else
            {
                ThongBao.Visible = true;
                btn_no.Visible = true;
                btn_yes.Visible = true;
            }
        }

        class Program
        {
            public static void Delete_File(string filename, int n)
            {
                // Đặt lại thuộc tính file thành bình thường.
                File.SetAttributes(filename, FileAttributes.Normal);

                // Tính tổng số sectors trong file.
                double sectors = Math.Ceiling(new FileInfo(filename).Length / 512.0);

                // Tạo một bộ đệm giả có kích thước bằng một sector.
                byte[] bo_dem = new byte[512];

                // Tạo một bộ mã số ngẫu nhiên để làm dữ liệu rác.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                // Mở filename vào FileStream inputstream.
                FileStream inputStream = new FileStream(filename, FileMode.Open);

                // Vòng lặp cho việc ghi đè.
                for (int currentPass = 0; currentPass < n; currentPass++)
                {
                    //Đặt lại vị trí bắt đầu.
                    inputStream.Position = 0;

                    // Vòng lặp cho sectors
                    for (int sectorsWritten = 0; sectorsWritten < sectors; sectorsWritten++)
                    {
                        // Điền vào bộ đệm giả với dữ liệu ngẫu nhiên 
                        rng.GetBytes(bo_dem);

                        //Viết nó vào inputStream.
                        inputStream.Write(bo_dem, 0, bo_dem.Length);
                    }
                }

                // Đặt size file thành 0 bytes.
                inputStream.SetLength(0);

                // Đóng inputStream.
                inputStream.Close();

                // Đặt lại thời gian cho file.
                DateTime dt = new DateTime(2030, 1, 1, 0, 0, 0);
                File.SetCreationTime(filename, dt);
                File.SetLastAccessTime(filename, dt);
                File.SetLastWriteTime(filename, dt);

                // Đổi tên và đuôi file.
                String rename = @"D:\fdasnfknczvncxm.txdfasdjfbdnt";
                File.Move(filename, rename);

                // Xóa file.
                File.Delete(rename);
            }
        }

        // Sự kiện click chọn yes để xóa
        private void btn_yes_Click(object sender, EventArgs e)
        {
            String link_file = file_index.Text;
            Program.Delete_File(link_file, 5);
            ThongBao2.Visible = true;
            btn_no.Visible = false;
            btn_yes.Visible = false;
            ThongBao.Visible = false;
        }

        // Sự kiện click chọn No để không xóa
        private void btn_no_Click(object sender, EventArgs e)
        {
            btn_no.Visible = false;
            btn_yes.Visible = false;
            ThongBao.Visible = false;
        }
    }
}
