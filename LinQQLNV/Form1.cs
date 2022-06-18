using QuanLyNhanSuADO.Forms;
using QuanLyNhanSuADO.ADOManagement;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSuADO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
        }
               

        private void employee_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageEmployee employee = new FormManageEmployee();
            employee.ShowDialog();
        }

        private void department_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageDepartment department = new FormManageDepartment();
            department.ShowDialog();
        }

        private void relative_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageRelative relative = new FormManageRelative();
            relative.ShowDialog();
        }

        private void statistics_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}