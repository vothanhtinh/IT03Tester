using EnTiTyFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnTiTyFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbConText())
            {
                var student = new SinhVien { Name = txttenSV.Text };
                db.SinhVien.Add(student);
                db.SaveChanges();
                txttenSV.Text = "";
                MessageBox.Show("Thêm Thành Công Sinh Viên");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbConText())
            {
                var students = context.SinhVien.ToList();
                dtgvSinhVien.DataSource = students;
            }
        }

        private void dtgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSinhVien.SelectedRows.Count > 0)
            {
                var row = dtgvSinhVien.SelectedRows[0];
                txttenSV.Text = row.Cells["Name"].Value.ToString();
               
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvSinhVien.SelectedRows.Count > 0)
            {
                var row = dtgvSinhVien.SelectedRows[0];
                var id = int.Parse(row.Cells["StudentId"].Value.ToString());
                using (var db = new ApplicationDbConText())
                {
                    var student = db.SinhVien.Find(id);
                    student.Name = txttenSV.Text;
                    db.SaveChanges();
                    MessageBox.Show("Cập Nhật Thành Công Sinh Viên");

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvSinhVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dtgvSinhVien.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dtgvSinhVien.Rows[selectedRowIndex];
                // Xử lý xóa dòng
                using (var context = new ApplicationDbConText())
                {
                    int selectedIndex = dtgvSinhVien.SelectedRows[0].Index;
                    int studentId = Convert.ToInt32(dtgvSinhVien.Rows[selectedRowIndex].Cells["StudentId"].Value);
                    SinhVien student = context.SinhVien.Find(studentId);
                    context.SinhVien.Remove(student);
                    context.SaveChanges();
                    MessageBox.Show("Đã Xóa Thành Công");
                    txttenSV.Text = "";
                }
            }
        }
    }
}
