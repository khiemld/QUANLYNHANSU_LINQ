using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSuADO.ADOManagement;

namespace QuanLyNhanSuADO.Forms
{
    internal class FormManageDepartment : FormManagementBase
    {
        private ADOEmployeeManagement management;

        public FormManageDepartment() : base()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();
        }

        protected override void add_button_Click(object sender, EventArgs e)
        {
            AddNewDepartment addNewDepartment = new AddNewDepartment();
            addNewDepartment.ShowDialog();
        }

        protected override void edit_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            EditDepartmentInfo editDepartmentInfo = new EditDepartmentInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            editDepartmentInfo.LoadData(maNV);
            editDepartmentInfo.ShowDialog();
        }

        protected override void view_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            ViewDepartmentInfo viewDepartmentInfo = new ViewDepartmentInfo();
            string maPB = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            viewDepartmentInfo.LoadData(maPB);
            viewDepartmentInfo.ShowDialog();
        }

        protected override void update_button_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        protected override void delete_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            string maPB = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            management.RemovePhongBan(maPB);
            MessageBox.Show("Xóa thành công");
        }

        protected override void InitializeAdditionalComponent()
        {
        }

        private void InitializeComponent()
        {
            this.custom_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_label
            // 
            this.form_label.Size = new System.Drawing.Size(249, 23);
            this.form_label.Text = "DANH SÁCH PHÒNG BAN";
            // 
            // FormManageDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Name = "FormManageDepartment";
            this.Text = "Quản lý phòng ban";
            this.Load += new System.EventHandler(this.FormManageDepartment_Load);
            this.custom_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void FormManageDepartment_Load(object sender, EventArgs e)
        {
            RefreshForm();
            this.list_dataGridView.Columns[0].HeaderText = "Mã phòng ban";
            this.list_dataGridView.Columns[1].HeaderText = "Tên phòng ban";
            this.list_dataGridView.Columns[2].HeaderText = "Trưởng phòng";
            this.list_dataGridView.Columns["DAXOA"].Visible = false;
        }

        private void RefreshForm()
        {
            list_dataGridView.DataSource = management.GetAllPhongBan();
        }
    }
}
