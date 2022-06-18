using System.Windows.Forms;

namespace QuanLyNhanSuADO.Forms
{
    partial class AddNewEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phongBan_comboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chucVu_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phuCap_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.luong_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maNV_textBox = new System.Windows.Forms.TextBox();
            this.trangThai_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gioiTinh_groupBox = new System.Windows.Forms.GroupBox();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ngaySinh_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sdt_textBox = new System.Windows.Forms.TextBox();
            this.chuyenMon_label = new System.Windows.Forms.Label();
            this.chuyenMon_textBox = new System.Windows.Forms.TextBox();
            this.diaChi_label = new System.Windows.Forms.Label();
            this.diaChi_textBox = new System.Windows.Forms.TextBox();
            this.hoten_label = new System.Windows.Forms.Label();
            this.hoTen_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gioiTinh_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 480);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cancel_button);
            this.panel2.Controls.Add(this.submit_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Các mục (*) là bắt buộc";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(647, 15);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Hủy";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(566, 15);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 0;
            this.submit_button.Text = "Thêm";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phongBan_comboBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.chucVu_comboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.phuCap_textBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.luong_textBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.maNV_textBox);
            this.groupBox2.Controls.Add(this.trangThai_comboBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hợp đồng";
            // 
            // phongBan_comboBox
            // 
            this.phongBan_comboBox.FormattingEnabled = true;
            this.phongBan_comboBox.Location = new System.Drawing.Point(522, 40);
            this.phongBan_comboBox.Name = "phongBan_comboBox";
            this.phongBan_comboBox.Size = new System.Drawing.Size(200, 24);
            this.phongBan_comboBox.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(406, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "(*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(406, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "(*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(24, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "(*)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(24, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(24, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "(*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Chức vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Trạng thái";
            // 
            // chucVu_comboBox
            // 
            this.chucVu_comboBox.FormattingEnabled = true;
            this.chucVu_comboBox.Location = new System.Drawing.Point(165, 127);
            this.chucVu_comboBox.Name = "chucVu_comboBox";
            this.chucVu_comboBox.Size = new System.Drawing.Size(200, 24);
            this.chucVu_comboBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phụ cấp";
            // 
            // phuCap_textBox
            // 
            this.phuCap_textBox.Location = new System.Drawing.Point(522, 85);
            this.phuCap_textBox.Name = "phuCap_textBox";
            this.phuCap_textBox.Size = new System.Drawing.Size(200, 23);
            this.phuCap_textBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phòng ban";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Lương";
            // 
            // luong_textBox
            // 
            this.luong_textBox.Location = new System.Drawing.Point(165, 85);
            this.luong_textBox.Name = "luong_textBox";
            this.luong_textBox.Size = new System.Drawing.Size(200, 23);
            this.luong_textBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mã nhân viên";
            // 
            // maNV_textBox
            // 
            this.maNV_textBox.Location = new System.Drawing.Point(165, 41);
            this.maNV_textBox.Name = "maNV_textBox";
            this.maNV_textBox.Size = new System.Drawing.Size(200, 23);
            this.maNV_textBox.TabIndex = 12;
            // 
            // trangThai_comboBox
            // 
            this.trangThai_comboBox.FormattingEnabled = true;
            this.trangThai_comboBox.Location = new System.Drawing.Point(522, 130);
            this.trangThai_comboBox.Name = "trangThai_comboBox";
            this.trangThai_comboBox.Size = new System.Drawing.Size(200, 24);
            this.trangThai_comboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gioiTinh_groupBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ngaySinh_dateTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.email_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sdt_textBox);
            this.groupBox1.Controls.Add(this.chuyenMon_label);
            this.groupBox1.Controls.Add(this.chuyenMon_textBox);
            this.groupBox1.Controls.Add(this.diaChi_label);
            this.groupBox1.Controls.Add(this.diaChi_textBox);
            this.groupBox1.Controls.Add(this.hoten_label);
            this.groupBox1.Controls.Add(this.hoTen_textBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "(*)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(406, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(406, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "(*)";
            // 
            // gioiTinh_groupBox
            // 
            this.gioiTinh_groupBox.Controls.Add(this.female_radioButton);
            this.gioiTinh_groupBox.Controls.Add(this.male_radioButton);
            this.gioiTinh_groupBox.Location = new System.Drawing.Point(59, 162);
            this.gioiTinh_groupBox.Name = "gioiTinh_groupBox";
            this.gioiTinh_groupBox.Size = new System.Drawing.Size(141, 51);
            this.gioiTinh_groupBox.TabIndex = 14;
            this.gioiTinh_groupBox.TabStop = false;
            this.gioiTinh_groupBox.Text = "Giới tính";
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(69, 24);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(41, 20);
            this.female_radioButton.TabIndex = 1;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Nữ";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(12, 23);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(51, 20);
            this.male_radioButton.TabIndex = 0;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Nam";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày sinh";
            // 
            // ngaySinh_dateTimePicker
            // 
            this.ngaySinh_dateTimePicker.Location = new System.Drawing.Point(522, 124);
            this.ngaySinh_dateTimePicker.Name = "ngaySinh_dateTimePicker";
            this.ngaySinh_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.ngaySinh_dateTimePicker.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(522, 77);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(200, 23);
            this.email_textBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Di động";
            // 
            // sdt_textBox
            // 
            this.sdt_textBox.Location = new System.Drawing.Point(522, 37);
            this.sdt_textBox.Name = "sdt_textBox";
            this.sdt_textBox.Size = new System.Drawing.Size(200, 23);
            this.sdt_textBox.TabIndex = 6;
            // 
            // chuyenMon_label
            // 
            this.chuyenMon_label.AutoSize = true;
            this.chuyenMon_label.Location = new System.Drawing.Point(59, 128);
            this.chuyenMon_label.Name = "chuyenMon_label";
            this.chuyenMon_label.Size = new System.Drawing.Size(78, 16);
            this.chuyenMon_label.TabIndex = 5;
            this.chuyenMon_label.Text = "Chuyên môn";
            // 
            // chuyenMon_textBox
            // 
            this.chuyenMon_textBox.Location = new System.Drawing.Point(153, 125);
            this.chuyenMon_textBox.Name = "chuyenMon_textBox";
            this.chuyenMon_textBox.Size = new System.Drawing.Size(200, 23);
            this.chuyenMon_textBox.TabIndex = 4;
            // 
            // diaChi_label
            // 
            this.diaChi_label.AutoSize = true;
            this.diaChi_label.Location = new System.Drawing.Point(59, 84);
            this.diaChi_label.Name = "diaChi_label";
            this.diaChi_label.Size = new System.Drawing.Size(46, 16);
            this.diaChi_label.TabIndex = 3;
            this.diaChi_label.Text = "Địa chỉ";
            // 
            // diaChi_textBox
            // 
            this.diaChi_textBox.Location = new System.Drawing.Point(153, 81);
            this.diaChi_textBox.Name = "diaChi_textBox";
            this.diaChi_textBox.Size = new System.Drawing.Size(200, 23);
            this.diaChi_textBox.TabIndex = 2;
            // 
            // hoten_label
            // 
            this.hoten_label.AutoSize = true;
            this.hoten_label.Location = new System.Drawing.Point(59, 44);
            this.hoten_label.Name = "hoten_label";
            this.hoten_label.Size = new System.Drawing.Size(44, 16);
            this.hoten_label.TabIndex = 1;
            this.hoten_label.Text = "Họ tên";
            // 
            // hoTen_textBox
            // 
            this.hoTen_textBox.Location = new System.Drawing.Point(153, 41);
            this.hoTen_textBox.Name = "hoTen_textBox";
            this.hoTen_textBox.Size = new System.Drawing.Size(200, 23);
            this.hoTen_textBox.TabIndex = 0;
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên mới";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gioiTinh_groupBox.ResumeLayout(false);
            this.gioiTinh_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected Panel panel1;
        protected GroupBox groupBox2;
        protected GroupBox groupBox1;
        protected Label label7;
        protected DateTimePicker ngaySinh_dateTimePicker;
        protected Label label5;
        protected TextBox email_textBox;
        protected Label label6;
        protected TextBox sdt_textBox;
        protected Label chuyenMon_label;
        protected TextBox chuyenMon_textBox;
        protected Label diaChi_label;
        protected TextBox diaChi_textBox;
        protected Label hoten_label;
        protected TextBox hoTen_textBox;
        protected ComboBox trangThai_comboBox;
        protected GroupBox gioiTinh_groupBox;
        protected RadioButton female_radioButton;
        protected RadioButton male_radioButton;
        protected Label label13;
        protected Label label12;
        protected ComboBox chucVu_comboBox;
        protected Label label8;
        protected TextBox phuCap_textBox;
        protected Label label9;
        protected Label label10;
        protected TextBox luong_textBox;
        protected Label label11;
        protected TextBox maNV_textBox;
        protected Panel panel2;
        protected Label label20;
        protected Button cancel_button;
        protected Button submit_button;
        protected Label label19;
        protected Label label18;
        protected Label label17;
        protected Label label14;
        protected Label label16;
        protected Label label3;
        protected Label label15;
        protected Label label4;
        protected Label label2;
        protected Label label1;
        protected ComboBox phongBan_comboBox;
    }
}