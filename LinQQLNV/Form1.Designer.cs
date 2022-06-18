using System.Windows.Forms;

namespace QuanLyNhanSuADO
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.system_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manage_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.department_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relative_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistics_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 480);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.system_ToolStripMenuItem,
            this.manage_ToolStripMenuItem,
            this.statistics_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // system_ToolStripMenuItem
            // 
            this.system_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.system_ToolStripMenuItem.Name = "system_ToolStripMenuItem";
            this.system_ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.system_ToolStripMenuItem.Text = "Hệ thống";
            // 
            // manage_ToolStripMenuItem
            // 
            this.manage_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.department_ToolStripMenuItem,
            this.employee_ToolStripMenuItem,
            this.relative_ToolStripMenuItem});
            this.manage_ToolStripMenuItem.Name = "manage_ToolStripMenuItem";
            this.manage_ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.manage_ToolStripMenuItem.Text = "Quản lý";
            // 
            // department_ToolStripMenuItem
            // 
            this.department_ToolStripMenuItem.Name = "department_ToolStripMenuItem";
            this.department_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.department_ToolStripMenuItem.Text = "Phòng ban";
            this.department_ToolStripMenuItem.Click += new System.EventHandler(this.department_ToolStripMenuItem_Click);
            // 
            // employee_ToolStripMenuItem
            // 
            this.employee_ToolStripMenuItem.Name = "employee_ToolStripMenuItem";
            this.employee_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.employee_ToolStripMenuItem.Text = "Nhân viên";
            this.employee_ToolStripMenuItem.Click += new System.EventHandler(this.employee_ToolStripMenuItem_Click);
            // 
            // relative_ToolStripMenuItem
            // 
            this.relative_ToolStripMenuItem.Name = "relative_ToolStripMenuItem";
            this.relative_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.relative_ToolStripMenuItem.Text = "Thân nhân";
            this.relative_ToolStripMenuItem.Click += new System.EventHandler(this.relative_ToolStripMenuItem_Click);
            // 
            // statistics_ToolStripMenuItem
            // 
            this.statistics_ToolStripMenuItem.Name = "statistics_ToolStripMenuItem";
            this.statistics_ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.statistics_ToolStripMenuItem.Text = "Thống kê";
            this.statistics_ToolStripMenuItem.Click += new System.EventHandler(this.statistics_ToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem system_ToolStripMenuItem;
        private ToolStripMenuItem manage_ToolStripMenuItem;
        private ToolStripMenuItem department_ToolStripMenuItem;
        private ToolStripMenuItem employee_ToolStripMenuItem;
        private ToolStripMenuItem relative_ToolStripMenuItem;
        private ToolStripMenuItem statistics_ToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}