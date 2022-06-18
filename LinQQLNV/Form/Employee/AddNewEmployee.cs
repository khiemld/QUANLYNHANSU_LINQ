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
using QuanLyNhanSuADO.Objects;

namespace QuanLyNhanSuADO.Forms
{
    public partial class AddNewEmployee : Form
    {
        protected ADOEmployeeManagement management;
        public AddNewEmployee()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();

            InitComponent();
        }

        public virtual void InitComponent()
        {
            // Centering windows to center of screen

            // Init combobox
            foreach (var value in DanhSachChon.ChucVu)
            {
                this.chucVu_comboBox.Items.Add(value);
            }
            this.chucVu_comboBox.SelectedIndex = 0;

            foreach (var value in DanhSachChon.TrangThai)
            {
                this.trangThai_comboBox.Items.Add(value);
            }
            this.trangThai_comboBox.SelectedIndex = 0;

            DataTable phongBan = management.GetAllPhongBan();
            foreach (DataRow row in phongBan.Rows)
            {
                this.phongBan_comboBox.Items.Add(Utilities.NormalizedString(row["TenPB"].ToString()));
            }
            this.phongBan_comboBox.SelectedIndex = 0;

            male_radioButton.Checked = true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            // Quit form
            this.Close();
        }

        protected NhanVien GetNhanVien()
        {
            string maNV = Utilities.NormalizedString(this.maNV_textBox.Text).ToUpper();
            string hoTen = Utilities.NormalizedString(this.hoTen_textBox.Text);
            string gioiTinh = male_radioButton.Checked == true ? "Nam" : "Nu";
            string diaChi = Utilities.NormalizedString(this.diaChi_textBox.Text);
            string chuyenMon = Utilities.NormalizedString(this.chuyenMon_textBox.Text);
            DateTime ngaySinh = this.ngaySinh_dateTimePicker.Value.Date;
            string email = Utilities.NormalizedString(this.email_textBox.Text);
            string sdt = Utilities.NormalizedString(this.sdt_textBox.Text);
            int luong = Utilities.ToNumber(this.luong_textBox.Text);
            int phuCap = Utilities.ToNumber(this.phuCap_textBox.Text);
            string chucVu = Utilities.NormalizedString(this.chucVu_comboBox.Text);
            string phongBan = Utilities.NormalizedString(this.phongBan_comboBox.Text);
            string maPB = management.GetMaPB(phongBan);
            string trangThai = Utilities.NormalizedString(this.trangThai_comboBox.Text);
            return new NhanVien(maNV, hoTen, gioiTinh, ngaySinh, maPB, trangThai, luong, sdt, diaChi, chucVu, email, chuyenMon, phuCap);
        }

        protected virtual void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = GetNhanVien();
                if (nhanVien.Validate)
                {
                    if (management.AddNhanVien(nhanVien))
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // AddNewEmployee
        //    // 
        //    this.ClientSize = new System.Drawing.Size(282, 253);
        //    this.Name = "AddNewEmployee";
        //    this.Load += new System.EventHandler(this.AddNewEmployee_Load);
        //    this.ResumeLayout(false);

        //}

        private void AddNewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}

