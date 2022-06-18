using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSuADO.ADOManagement;

namespace QuanLyNhanSuADO.Forms
{
    internal class FormManageEmployee : FormManagementBase
    {
        private Button search_button;
        private GroupBox sex_groupBox;
        private RadioButton female_radioButton;
        private RadioButton male_radioButton;
        private Label phongBan_label;
        private TextBox ten_textBox;
        private Label ten_label;
        private TextBox maNV_textBox;
        private Label maNV_label;
        private RadioButton all_radioButton;
        private ComboBox phongBan_comboBox;


        public FormManageEmployee() : base()
        {
            InitializeComponent();
            InitializeAdditionalComponent();
        }

        protected override void add_button_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog();
        }

        protected override void edit_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            EditEmployeeInfo editEmployeeInfo = new EditEmployeeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            editEmployeeInfo.LoadData(maNV);
            editEmployeeInfo.ShowDialog();
        }

        protected override void view_button_Click(object sender, EventArgs e)
        {
            ViewEmployeeInfo viewEmployeeInfo = new ViewEmployeeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            viewEmployeeInfo.LoadData(maNV);
            viewEmployeeInfo.ShowDialog();
        }

        protected override void update_button_Click(object sender, EventArgs e)
        {
            list_dataGridView.DataSource = management.GetAllNhanVien();
        }

        protected override void delete_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            management.RemoveNhanVien(maNV);
            MessageBox.Show("Xóa thành công");
        }

        protected override void InitializeAdditionalComponent()
        {
            base.InitializeAdditionalComponent();
            this.custom_groupBox.Text = "Tìm kiếm";
            this.all_radioButton.Checked = true;
            DataTable phongBan = this.management.GetAllPhongBan();
            foreach (DataRow row in phongBan.Rows)
            {
                this.phongBan_comboBox.Items.Add(Utilities.NormalizedString(row["TenPB"].ToString()));
            }
        }

        private void InitializeComponent()
        {
            this.maNV_label = new System.Windows.Forms.Label();
            this.maNV_textBox = new System.Windows.Forms.TextBox();
            this.ten_textBox = new System.Windows.Forms.TextBox();
            this.ten_label = new System.Windows.Forms.Label();
            this.phongBan_label = new System.Windows.Forms.Label();
            this.sex_groupBox = new System.Windows.Forms.GroupBox();
            this.all_radioButton = new System.Windows.Forms.RadioButton();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.phongBan_comboBox = new System.Windows.Forms.ComboBox();
            this.custom_groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sex_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // custom_groupBox
            // 
            this.custom_groupBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.custom_groupBox.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.custom_groupBox.Size = new System.Drawing.Size(1142, 219);
            // 
            // form_label
            // 
            this.form_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 22);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.phongBan_comboBox);
            this.panel2.Controls.Add(this.search_button);
            this.panel2.Controls.Add(this.sex_groupBox);
            this.panel2.Controls.Add(this.phongBan_label);
            this.panel2.Controls.Add(this.ten_textBox);
            this.panel2.Controls.Add(this.ten_label);
            this.panel2.Controls.Add(this.maNV_textBox);
            this.panel2.Controls.Add(this.maNV_label);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Size = new System.Drawing.Size(1130, 191);
            // 
            // maNV_label
            // 
            this.maNV_label.AutoSize = true;
            this.maNV_label.Location = new System.Drawing.Point(31, 40);
            this.maNV_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maNV_label.Name = "maNV_label";
            this.maNV_label.Size = new System.Drawing.Size(64, 20);
            this.maNV_label.TabIndex = 0;
            this.maNV_label.Text = "Mã NV";
            // 
            // maNV_textBox
            // 
            this.maNV_textBox.Location = new System.Drawing.Point(152, 37);
            this.maNV_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maNV_textBox.Name = "maNV_textBox";
            this.maNV_textBox.Size = new System.Drawing.Size(265, 27);
            this.maNV_textBox.TabIndex = 1;
            // 
            // ten_textBox
            // 
            this.ten_textBox.Location = new System.Drawing.Point(152, 96);
            this.ten_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ten_textBox.Name = "ten_textBox";
            this.ten_textBox.Size = new System.Drawing.Size(265, 27);
            this.ten_textBox.TabIndex = 3;
            // 
            // ten_label
            // 
            this.ten_label.AutoSize = true;
            this.ten_label.Location = new System.Drawing.Point(31, 101);
            this.ten_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ten_label.Name = "ten_label";
            this.ten_label.Size = new System.Drawing.Size(71, 20);
            this.ten_label.TabIndex = 2;
            this.ten_label.Text = "Tên NV";
            // 
            // phongBan_label
            // 
            this.phongBan_label.AutoSize = true;
            this.phongBan_label.Location = new System.Drawing.Point(462, 40);
            this.phongBan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phongBan_label.Name = "phongBan_label";
            this.phongBan_label.Size = new System.Drawing.Size(100, 20);
            this.phongBan_label.TabIndex = 4;
            this.phongBan_label.Text = "Phòng ban";
            // 
            // sex_groupBox
            // 
            this.sex_groupBox.AutoSize = true;
            this.sex_groupBox.Controls.Add(this.all_radioButton);
            this.sex_groupBox.Controls.Add(this.female_radioButton);
            this.sex_groupBox.Controls.Add(this.male_radioButton);
            this.sex_groupBox.Location = new System.Drawing.Point(462, 72);
            this.sex_groupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sex_groupBox.Name = "sex_groupBox";
            this.sex_groupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sex_groupBox.Size = new System.Drawing.Size(271, 83);
            this.sex_groupBox.TabIndex = 6;
            this.sex_groupBox.TabStop = false;
            this.sex_groupBox.Text = "Giới tính";
            // 
            // all_radioButton
            // 
            this.all_radioButton.AutoSize = true;
            this.all_radioButton.Location = new System.Drawing.Point(161, 27);
            this.all_radioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.all_radioButton.Name = "all_radioButton";
            this.all_radioButton.Size = new System.Drawing.Size(82, 24);
            this.all_radioButton.TabIndex = 2;
            this.all_radioButton.Text = "Tất cả";
            this.all_radioButton.UseVisualStyleBackColor = true;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(90, 26);
            this.female_radioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(54, 24);
            this.female_radioButton.TabIndex = 1;
            this.female_radioButton.Text = "Nữ";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Checked = true;
            this.male_radioButton.Location = new System.Drawing.Point(9, 26);
            this.male_radioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(70, 24);
            this.male_radioButton.TabIndex = 0;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Nam";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(772, 96);
            this.search_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(108, 28);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "Tìm kiếm";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // phongBan_comboBox
            // 
            this.phongBan_comboBox.FormattingEnabled = true;
            this.phongBan_comboBox.Location = new System.Drawing.Point(614, 36);
            this.phongBan_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phongBan_comboBox.Name = "phongBan_comboBox";
            this.phongBan_comboBox.Size = new System.Drawing.Size(265, 26);
            this.phongBan_comboBox.TabIndex = 8;
            // 
            // FormManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.ClientSize = new System.Drawing.Size(1142, 540);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormManageEmployee";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormManageEmployee_Load);
            this.custom_groupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sex_groupBox.ResumeLayout(false);
            this.sex_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // Search with name id department and sex
                bool isMale = this.male_radioButton.Checked;
            bool isAll = this.all_radioButton.Checked;

            string sex = "";

            if (!isAll)
            {
                sex = isMale ? "Nam" : "Nu";
            }

                string name = Utilities.NormalizedString(this.ten_textBox.Text);
                string department = Utilities.NormalizedString(this.phongBan_comboBox.Text);
                string id = Utilities.NormalizedString(this.maNV_textBox.Text);
                string departmentID = management.GetMaPB(department);
            try
            {
                this.list_dataGridView.DataSource = management.SearchNhanVien(id, name, departmentID, sex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormManageEmployee_Load(object sender, EventArgs e)
        {
            this.list_dataGridView.DataSource = management.GetAllNhanVien();
            this.list_dataGridView.Columns[0].HeaderText = "Mã nhân viên";
            this.list_dataGridView.Columns[1].HeaderText = "Tên nhân viên";
            this.list_dataGridView.Columns[2].HeaderText = "Giới tính";
            this.list_dataGridView.Columns[3].HeaderText = "Ngày sinh";
            this.list_dataGridView.Columns[4].HeaderText = "Mã phòng ban";
            this.list_dataGridView.Columns[5].HeaderText = "Trạng thái";
            this.list_dataGridView.Columns[6].HeaderText = "Lương";
            this.list_dataGridView.Columns[7].HeaderText = "Phụ cấp";
            this.list_dataGridView.Columns[8].HeaderText = "Số điện thoại";
            this.list_dataGridView.Columns[9].HeaderText = "Email";
            this.list_dataGridView.Columns[10].HeaderText = "Chuyên môn";
            this.list_dataGridView.Columns[11].HeaderText = "Chức vụ";
            this.list_dataGridView.Columns[12].HeaderText = "Địa chỉ";
            this.list_dataGridView.Columns["DAXOA"].Visible = false;
        }
    }

}
