using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.Objects;
using QuanLyNhanSuADO.ADOManagement;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhanSuADO.Forms
{
    internal class EditEmployeeInfo : AddNewEmployee
    {
        public EditEmployeeInfo(): base()
        {
        }

        public override void InitComponent()
        {
            // Init combobox
            base.InitComponent();
            this.Text = "Sửa thông tin nhân viên";
            this.submit_button.Text = "Sửa";
            this.maNV_textBox.Enabled = false;
        }

        public void LoadData(string maNV)
        {
            NhanVien nhanVien = management.GetNhanVien(maNV);
            if (nhanVien != null)
            {
                this.maNV_textBox.Text = nhanVien.MaNV;
                this.hoTen_textBox.Text = nhanVien.HoTen;
                this.ngaySinh_dateTimePicker.Value = nhanVien.NgaySinh.Date;
                if (nhanVien.GioiTinh == "Nam")
                {
                    this.male_radioButton.Checked = true;
                }
                else
                {
                    this.female_radioButton.Checked = true;
                }
                this.trangThai_comboBox.SelectedValue = nhanVien.TrangThai;

                foreach(var item in phongBan_comboBox.Items)
                {
                    if(item.ToString() == nhanVien.MaPB)
                    {
                        this.phongBan_comboBox.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in trangThai_comboBox.Items)
                {
                    if (item.ToString() == nhanVien.TrangThai)
                    {
                        this.trangThai_comboBox.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in chucVu_comboBox.Items)
                {
                    if (item.ToString() == nhanVien.ChucVu)
                    {
                        this.chucVu_comboBox.SelectedItem = item;
                        break;
                    }
                }

                this.luong_textBox.Text = nhanVien.Luong.ToString();
                this.phuCap_textBox.Text = nhanVien.PhuCap.ToString();
                this.sdt_textBox.Text = nhanVien.Sdt;
                this.email_textBox.Text = nhanVien.Email;
                this.chuyenMon_textBox.Text = nhanVien.ChuyenMon;
                this.diaChi_textBox.Text = nhanVien.DiaChi;
            }
        }

        protected override void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = GetNhanVien();
                if (nhanVien.Validate)
                {
                    if (management.UpdateNhanVien(nhanVien))
                    {
                        MessageBox.Show("Sửa nhân viên thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
