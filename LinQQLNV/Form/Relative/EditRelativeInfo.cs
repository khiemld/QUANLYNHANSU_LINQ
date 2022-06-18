using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSuADO.Objects;
using QuanLyNhanSuADO.ADOManagement;
using System.Windows.Forms;

namespace QuanLyNhanSuADO.Forms
{
    internal class EditRelativeInfo:AddNewRelative
    {
        ADOEmployeeManagement management;
        public EditRelativeInfo()
        {
            management = new ADOEmployeeManagement();
            this.Text = "Sửa thông tin thân nhân";
            this.submit_button.Text = "Sửa";
        }

        protected override void InitComponent()
        {
            base.InitComponent();
            this.nv_comboBox.Enabled = false;
            this.ten_textBox.Enabled = false;
        }

        public void LoadData(string maNV, string ten)
        {
            ThanNhan thanNhan = management.GetThanNhan(maNV, ten);
            if (thanNhan == null) return;
            foreach(var item in quanhe_comboBox.Items) { 
                if(Utilities.NormalizedString(item.ToString()) == thanNhan.QuanHeVoiNV)
                {
                    quanhe_comboBox.SelectedItem = item;
                    break;
                }
            }
            foreach(var item in nv_comboBox.Items)
            {
                string key = ((KeyValuePair<string, string>)item).Key;
                if (Utilities.NormalizedString(key) == thanNhan.MaNV)
                {
                    nv_comboBox.SelectedItem = item;
                    break;
                }
            }
            
            this.ten_textBox.Text = thanNhan.TenTN;
            this.sdt_textBox.Text = thanNhan.Sdt;
        }

        protected override void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                ThanNhan thanNhan = GetThanNhan();
                if (management.UpdateThanNhan(thanNhan))
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception err) {

                MessageBox.Show(err.Message);
            }
        }
    }
}
