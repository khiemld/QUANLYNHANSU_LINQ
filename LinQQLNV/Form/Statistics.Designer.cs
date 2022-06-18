using System.Windows.Forms;

namespace QuanLyNhanSuADO.Forms
{
    partial class Statistics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nv_groupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.max_textBox = new System.Windows.Forms.TextBox();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_groupBox = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.nv_groupBox.SuspendLayout();
            this.pb_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nv_groupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_groupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3289F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nv_groupBox
            // 
            this.nv_groupBox.Controls.Add(this.button4);
            this.nv_groupBox.Controls.Add(this.button2);
            this.nv_groupBox.Controls.Add(this.label1);
            this.nv_groupBox.Controls.Add(this.max_textBox);
            this.nv_groupBox.Controls.Add(this.min_textBox);
            this.nv_groupBox.Controls.Add(this.button1);
            this.nv_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nv_groupBox.Location = new System.Drawing.Point(3, 3);
            this.nv_groupBox.Name = "nv_groupBox";
            this.nv_groupBox.Size = new System.Drawing.Size(794, 219);
            this.nv_groupBox.TabIndex = 0;
            this.nv_groupBox.TabStop = false;
            this.nv_groupBox.Text = "Thống kê nhân viên";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(486, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Thống kê nhân viên có sinh nhật trong tháng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.birthday_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(486, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thống kê nhân viên đã nghỉ hưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.retire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "< Lương <";
            // 
            // max_textBox
            // 
            this.max_textBox.Location = new System.Drawing.Point(421, 66);
            this.max_textBox.Name = "max_textBox";
            this.max_textBox.Size = new System.Drawing.Size(100, 23);
            this.max_textBox.TabIndex = 2;
            // 
            // min_textBox
            // 
            this.min_textBox.Location = new System.Drawing.Point(229, 66);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(100, 23);
            this.min_textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thống kê nhân viên có lương ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.thongKeLuong_Click);
            // 
            // pb_groupBox
            // 
            this.pb_groupBox.Controls.Add(this.button7);
            this.pb_groupBox.Controls.Add(this.button6);
            this.pb_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_groupBox.Location = new System.Drawing.Point(3, 228);
            this.pb_groupBox.Name = "pb_groupBox";
            this.pb_groupBox.Size = new System.Drawing.Size(794, 219);
            this.pb_groupBox.TabIndex = 1;
            this.pb_groupBox.TabStop = false;
            this.pb_groupBox.Text = "Thống kê phòng ban";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(486, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Thống kê tổng lương từng phòng ban";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.sumLuong_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(486, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Thống kê số nhân viên từng phòng ban";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.soNV_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.nv_groupBox.ResumeLayout(false);
            this.nv_groupBox.PerformLayout();
            this.pb_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox nv_groupBox;
        private GroupBox pb_groupBox;
        private Button button4;
        private Button button2;
        private Label label1;
        private TextBox max_textBox;
        private TextBox min_textBox;
        private Button button1;
        private Button button7;
        private Button button6;
    }
}