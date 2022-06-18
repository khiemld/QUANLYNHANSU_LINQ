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
    public partial class AddNewRelative : Form
    {
        ADOEmployeeManagement management;
        public AddNewRelative()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();
            InitComponent();
        }

        protected virtual void InitComponent()
        {
            Utilities.ListNhanVienToComboBox(management, nv_comboBox);
            quanhe_comboBox.DataSource = new BindingSource(DanhSachChon.QuanHeVoiNV, null);
        }

        protected ThanNhan GetThanNhan()
        {
            string nv = Utilities.GetKeyValueComboBox(nv_comboBox.SelectedItem);
            string hoTen = Utilities.NormalizedString(this.ten_textBox.Text);
            string sdt = Utilities.NormalizedString(this.sdt_textBox.Text);
            string quanHe = Utilities.NormalizedString(this.quanhe_comboBox.Text);

            ThanNhan thanNhan = new ThanNhan(nv, hoTen, quanHe, sdt);
            return thanNhan;
        }

        protected virtual void submit_button_Click(object sender, EventArgs e)
        {
            string id = ((KeyValuePair<string, string>)nv_comboBox.SelectedItem).Key;
            string nv = Utilities.NormalizedString(id);
            string hoTen = Utilities.NormalizedString(this.ten_textBox.Text);
            string sdt = Utilities.NormalizedString(this.sdt_textBox.Text);
            string quanHe = Utilities.NormalizedString(this.quanhe_comboBox.Text);

            ThanNhan thanNhan = new ThanNhan(nv, hoTen, quanHe, sdt);
            try
            {
                management.AddThanNhan(thanNhan);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
