using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSuADO.Forms
{
    internal class ViewRelativeInfo : EditRelativeInfo
    {
        public ViewRelativeInfo()
        {
            this.Text = "Xem thông tin thân nhân";
            this.submit_button.Visible = false;
            this.ten_textBox.Enabled = false;
            this.nv_comboBox.Enabled = false;
            this.sdt_textBox.Enabled = false;
            this.quanhe_comboBox.Enabled = false;
        }
    }
}
