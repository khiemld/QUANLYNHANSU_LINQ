using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.ADOManagement;
using QuanLyNhanSuADO.Objects;

namespace QuanLyNhanSuADO.Forms
{
    internal class ViewDepartmentInfo : EditDepartmentInfo
    {
        public ViewDepartmentInfo() : base()
        {
        }

        protected override void InitComponent()
        {
            base.InitComponent();
            this.Text = "Xem thông tin phòng ban";
            this.cancel_button.Text = "Đóng";
            this.submit_button.Enabled = false;
            this.submit_button.Visible = false;
            this.tenPB_textBox.Enabled = false;
            this.maPB_textBox.Enabled = false;
            this.truongPhong_comboBox.Enabled = false;
        }
    }
}
