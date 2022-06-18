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
    public partial class AddNewDepartment : Form
    {
        protected ADOEmployeeManagement management;
        public AddNewDepartment()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();
            InitComponent();
        }
        
        protected PhongBan GetPhongBan()
        {
            string maNV = Utilities.GetKeyValueComboBox(truongPhong_comboBox.SelectedItem);
            PhongBan phongBan = new PhongBan(maPB_textBox.Text, tenPB_textBox.Text, maNV);
            return phongBan;
        }

        protected virtual void InitComponent()
        {
           DataTable phongBan = management.GetAllNhanVien();
            Dictionary<string, string> phongBanDictionary = new Dictionary<string, string>();
            
           foreach(DataRow phong in phongBan.Rows)
            {
                phongBanDictionary.Add(phong["MaNV"].ToString(), phong["HoTen"].ToString());
            }
            this.truongPhong_comboBox.DataSource = new BindingSource(phongBanDictionary, null);
        }

        protected virtual void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBan phongBan = GetPhongBan();
                if (phongBan.Validate)
                {
                    if (management.AddPhongBan(phongBan))
                    {
                        MessageBox.Show("Thêm phòng ban thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng ban thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
