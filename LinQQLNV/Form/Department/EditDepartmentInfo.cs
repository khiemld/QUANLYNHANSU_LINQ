using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanSuADO.Objects;

namespace QuanLyNhanSuADO.Forms
{
    internal class EditDepartmentInfo : AddNewDepartment
    {
        public EditDepartmentInfo() : base()
        {
            InitComponent();
        }

        protected override void InitComponent()
        {
            base.InitComponent();
            this.Text = "Sửa thông tin phòng ban";
            this.submit_button.Text = "Sửa";
            this.maPB_textBox.Enabled = false;
        }

        public virtual void LoadData(string maPB)
        {
            PhongBan phongBan = management.GetPhongBan(maPB);
            if (phongBan == null)
            {
                MessageBox.Show("Không tìm thấy phòng ban có mã " + maPB);
                return;
            }
            this.maPB_textBox.Text = phongBan.MaPB;
            this.tenPB_textBox.Text = phongBan.TenPB;
            foreach (var value in truongPhong_comboBox.Items)
            {
                if (Utilities.GetKeyValueComboBox(value) == phongBan.TruongPB)
                {
                    truongPhong_comboBox.SelectedItem = value;
                    break;
                }
            }
        }

        protected override void submit_button_Click(object sender, EventArgs e)
        {
            PhongBan phongBan = GetPhongBan();
            if (phongBan.Validate)
            {
                if (management.UpdatePhongBan(phongBan))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
        }
    }
}
