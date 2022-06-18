using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSuADO.ADOManagement;

namespace QuanLyNhanSuADO.Forms
{
    public partial class Statistics : Form
    {
        ADOEmployeeManagement management;
        public Statistics()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();
        }

        private void thongKeLuong_Click(object sender, EventArgs e)
        {

            //try
            //{
                int min = Convert.ToInt32(Utilities.NormalizedString(min_textBox.Text));
                int max = Convert.ToInt32(Utilities.NormalizedString(max_textBox.Text));
                DataTable data = management.GetAllLuongNhanVien(min, max);
                Utilities.ExportExcelFile(data, Utilities.NhanVienHeader, $"Thống kê lương nhân viên", $"Thống kê nhân viên có lương từ {min} đến {max}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void retire_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = management.GetAllNhanVienRetire();
                Utilities.ExportExcelFile(data, Utilities.NhanVienHeader, $"Thống kê nhân viên đã nghỉ việc", $"Thống kê nhân viên đã nghỉ việc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void birthday_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = management.GetAllNhanVienHaveBirthday();
                Utilities.ExportExcelFile(data, Utilities.NhanVienHeader, $"Thống kê sinh nhật nhân viên", $"Thống kê nhân viên có sinh nhật trong tháng này");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soNV_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = management.GetCountNhanVien();
                string[] header = { "Mã phòng ban", "Số nhân viên" };
                Utilities.ExportExcelFile(data, header, $"Thống kê số nhân viên", $"Thống kê số nhân viên theo phòng ban");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sumLuong_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = management.GetSumSalary();
                string[] header = { "Mã phòng ban", "Tổng lương" };
                Utilities.ExportExcelFile(data, header, $"Thống kê tổng lương nhân viên", $"Thống kê tổng lương nhân viên theo phòng ban");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
