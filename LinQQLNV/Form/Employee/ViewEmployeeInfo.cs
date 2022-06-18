using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.ADOManagement;
using QuanLyNhanSuADO.Objects;

namespace QuanLyNhanSuADO.Forms
{
    internal class ViewEmployeeInfo : EditEmployeeInfo
    {
        public ViewEmployeeInfo() : base()
        {
            InitComponent();
        }

        public override void InitComponent()
        {
            base.InitComponent();
            this.Text = "Xem thông tin nhân viên";
            this.submit_button.Visible = false;
            this.cancel_button.Text = "Đóng";
            // Disable all textbox
            this.maNV_textBox.Enabled = false;
            this.hoTen_textBox.Enabled = false;
            this.ngaySinh_dateTimePicker.Enabled = false;
            this.gioiTinh_groupBox.Enabled = false;
            this.phongBan_comboBox.Enabled = false;
            this.trangThai_comboBox.Enabled = false;
            this.luong_textBox.Enabled = false;
            this.phuCap_textBox.Enabled = false;
            this.sdt_textBox.Enabled = false;
            this.email_textBox.Enabled = false;
            this.chuyenMon_textBox.Enabled = false;
            this.chucVu_comboBox.Enabled = false;
            this.diaChi_textBox.Enabled = false;
        }

        private void InitializeComponent()
        {
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gioiTinh_groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trangThai_comboBox
            // 
            this.trangThai_comboBox.Size = new System.Drawing.Size(200, 24);
            // 
            // chucVu_comboBox
            // 
            this.chucVu_comboBox.Size = new System.Drawing.Size(200, 24);
            // 
            // phongBan_comboBox
            // 
            this.phongBan_comboBox.Size = new System.Drawing.Size(200, 24);
            // 
            // ViewEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Name = "ViewEmployeeInfo";
            this.Text = "Xem thông tin nhân viên";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gioiTinh_groupBox.ResumeLayout(false);
            this.gioiTinh_groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
