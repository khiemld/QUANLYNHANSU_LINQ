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
    public partial class Login : Form
    {

        ADOEmployeeManagement management;
        public Login()
        {
            InitializeComponent();
            management = new ADOEmployeeManagement();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = Utilities.NormalizedString(username_textBox.Text);
            string password = Utilities.NormalizedString(pwd_textBox.Text);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (management.LoginCheck(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
