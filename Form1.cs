using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhSachSvWithCode
{

   
    public partial class Form1 : Form
    {

        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string TenSinhVien { get; set; }
            public string LopHoc { get; set; }
        }
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvSinhVien.MultiSelect = false; 
        }
        private void CapNhatDataGridView()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = danhSachSinhVien;
        }

        private void ClearTextBoxes()
        {
            MsvText.Clear();
            TenSvText.Clear();
            LopSvText.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MsvText.Text) && !string.IsNullOrEmpty(TenSvText.Text) && !string.IsNullOrEmpty(LopSvText.Text))
            {
                SinhVien sv = new SinhVien()
                {
                    MaSinhVien = MsvText.Text,
                    TenSinhVien = TenSvText.Text,
                    LopHoc = LopSvText.Text
                };

                danhSachSinhVien.Add(sv);
                CapNhatDataGridView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.");
            }

        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                int index = dgvSinhVien.SelectedRows[0].Index;
                SinhVien sv = danhSachSinhVien[index];

                sv.MaSinhVien = MsvText.Text;
                sv.TenSinhVien = TenSvText.Text;
                sv.LopHoc = LopSvText.Text;

                CapNhatDataGridView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                int index = dgvSinhVien.SelectedRows[0].Index;
                danhSachSinhVien.RemoveAt(index);

                CapNhatDataGridView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                int index = dgvSinhVien.SelectedRows[0].Index;
                SinhVien sv = danhSachSinhVien[index];

                MsvText.Text = sv.MaSinhVien;
                TenSvText.Text = sv.TenSinhVien;
                LopSvText.Text = sv.LopHoc;
            }
        }
    }
}
