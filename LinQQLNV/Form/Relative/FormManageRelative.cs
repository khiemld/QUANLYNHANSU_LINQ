using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSuADO.ADOManagement;
using QuanLyNhanSuADO.Objects;

namespace QuanLyNhanSuADO.Forms
{
    internal class FormManageRelative : FormManagementBase
    {
        private Button button1;
        private ComboBox quanhe_comboBox;
        private Label label3;
        private TextBox ten_textBox;
        private Label label2;
        private ComboBox nv_comboBox;
        private Label label1;
        private ADOEmployeeManagement management;

        public FormManageRelative() : base()
        {
            management = new ADOEmployeeManagement();
            InitializeComponent();
            InitializeAdditionalComponent();
        }


        protected override void add_button_Click(object sender, EventArgs e)
        {
            AddNewRelative addNewRelative = new AddNewRelative();
            addNewRelative.ShowDialog();
        }

        protected override void edit_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            EditRelativeInfo editRelativeInfo = new EditRelativeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string ten = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());
            editRelativeInfo.LoadData(maNV, ten);
            editRelativeInfo.ShowDialog();
        }

        protected override void view_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            ViewRelativeInfo viewRelativeInfo = new ViewRelativeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string ten = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());
           
            viewRelativeInfo.LoadData(maNV, ten);
            viewRelativeInfo.ShowDialog();
        }

        protected override void update_button_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        protected override void delete_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string hoTen = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());
            try
            {
                if (management.RemoveThanNhan(maNV, hoTen))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        protected override void InitializeAdditionalComponent()
        {
            Utilities.ListNhanVienToComboBox(management, nv_comboBox);

            List<string> emptyString = new List<string>();
            emptyString.Add("");
            emptyString.AddRange(DanhSachChon.QuanHeVoiNV);
            quanhe_comboBox.DataSource = emptyString;
            quanhe_comboBox.SelectedIndex = 0;
        }

        protected void RefreshForm()
        {
            list_dataGridView.DataSource = management.GetAllThanNhan();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nv_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ten_textBox = new System.Windows.Forms.TextBox();
            this.quanhe_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.custom_groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // custom_groupBox
            // 
            this.custom_groupBox.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.quanhe_comboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ten_textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nv_comboBox);
            this.panel2.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // nv_comboBox
            // 
            this.nv_comboBox.FormattingEnabled = true;
            this.nv_comboBox.Location = new System.Drawing.Point(279, 21);
            this.nv_comboBox.Name = "nv_comboBox";
            this.nv_comboBox.Size = new System.Drawing.Size(407, 24);
            this.nv_comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thân nhân";
            // 
            // ten_textBox
            // 
            this.ten_textBox.Location = new System.Drawing.Point(279, 67);
            this.ten_textBox.Name = "ten_textBox";
            this.ten_textBox.Size = new System.Drawing.Size(407, 23);
            this.ten_textBox.TabIndex = 3;
            // 
            // quanhe_comboBox
            // 
            this.quanhe_comboBox.FormattingEnabled = true;
            this.quanhe_comboBox.Location = new System.Drawing.Point(279, 113);
            this.quanhe_comboBox.Name = "quanhe_comboBox";
            this.quanhe_comboBox.Size = new System.Drawing.Size(407, 24);
            this.quanhe_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quan hệ với nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_Click);
            // 
            // FormManageRelative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Name = "FormManageRelative";
            this.Load += new System.EventHandler(this.FormManageRelative_Load);
            this.custom_groupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void FormManageRelative_Load(object sender, EventArgs e)
        {
            RefreshForm();
            this.list_dataGridView.Columns[0].HeaderText = "Mã nhân viên";
            this.list_dataGridView.Columns[1].HeaderText = "Tên thân nhân";
            this.list_dataGridView.Columns[2].HeaderText = "Số điện thoại";
            this.list_dataGridView.Columns[3].HeaderText = "Quan hệ với NV";
            this.list_dataGridView.Columns["DAXOA"].Visible = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string id = Utilities.NormalizedString(((KeyValuePair<string, string>)nv_comboBox.SelectedItem).Key);
            string name = Utilities.NormalizedString(this.ten_textBox.Text);
            string relationship = Utilities.NormalizedString(this.quanhe_comboBox.Text);
            try
            {
                this.list_dataGridView.DataSource = management.SearchThanNhan(id, name, relationship);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
