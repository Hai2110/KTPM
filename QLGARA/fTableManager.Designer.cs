namespace QLGARA
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            panel3 = new Panel();
            cbSwitch = new ComboBox();
            btnSwitch = new Button();
            nmDisscount = new NumericUpDown();
            btnDisscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            numericUpDown1 = new NumericUpDown();
            btnAdd = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            flpCal = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(558, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 375);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(376, 372);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.List;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitch);
            panel3.Controls.Add(btnSwitch);
            panel3.Controls.Add(nmDisscount);
            panel3.Controls.Add(btnDisscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(558, 489);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 69);
            panel3.TabIndex = 3;
            // 
            // cbSwitch
            // 
            cbSwitch.FormattingEnabled = true;
            cbSwitch.Location = new Point(6, 34);
            cbSwitch.Name = "cbSwitch";
            cbSwitch.Size = new Size(97, 28);
            cbSwitch.TabIndex = 7;
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(6, 3);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(97, 29);
            btnSwitch.TabIndex = 6;
            btnSwitch.Text = "Đổi lịch";
            btnSwitch.UseVisualStyleBackColor = true;
            // 
            // nmDisscount
            // 
            nmDisscount.Location = new Point(152, 38);
            nmDisscount.Name = "nmDisscount";
            nmDisscount.Size = new Size(97, 27);
            nmDisscount.TabIndex = 4;
            nmDisscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDisscount
            // 
            btnDisscount.Location = new Point(152, 3);
            btnDisscount.Name = "btnDisscount";
            btnDisscount.Size = new Size(97, 29);
            btnDisscount.TabIndex = 5;
            btnDisscount.Text = "Giảm giá";
            btnDisscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(282, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(97, 62);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(561, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 71);
            panel4.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(333, 22);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(231, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 62);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Đặt lịch";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 0;
            // 
            // flpCal
            // 
            flpCal.Location = new Point(12, 34);
            flpCal.Name = "flpCal";
            flpCal.Size = new Size(540, 524);
            flpCal.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 569);
            Controls.Add(flpCal);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý gara ô tô";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDisscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnAdd;
        private NumericUpDown numericUpDown1;
        private Button btnCheckOut;
        private FlowLayoutPanel flpCal;
        private Button btnDisscount;
        private NumericUpDown nmDisscount;
        private ComboBox cbSwitch;
        private Button btnSwitch;
    }
}