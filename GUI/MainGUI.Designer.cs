namespace GUI
{
    partial class MainGUI
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýHồSơHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCánBộGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpDanhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.quảnLýĐiểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.phânCôngGiảngDạyToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(980, 24);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.CheckOnClick = true;
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Hệ Thống";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMônHọcToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.toolStripSeparator1,
            this.quảnLýHồSơHọcSinhToolStripMenuItem,
            this.quảnLýCánBộGiáoViênToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem1});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // quảnLýHồSơHọcSinhToolStripMenuItem
            // 
            this.quảnLýHồSơHọcSinhToolStripMenuItem.Name = "quảnLýHồSơHọcSinhToolStripMenuItem";
            this.quảnLýHồSơHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quảnLýHồSơHọcSinhToolStripMenuItem.Text = "Quản lý hồ sơ học sinh";
            this.quảnLýHồSơHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHồSơHọcSinhToolStripMenuItem_Click);
            // 
            // quảnLýCánBộGiáoViênToolStripMenuItem
            // 
            this.quảnLýCánBộGiáoViênToolStripMenuItem.Name = "quảnLýCánBộGiáoViênToolStripMenuItem";
            this.quảnLýCánBộGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quảnLýCánBộGiáoViênToolStripMenuItem.Text = "Quản lý cán bộ giáo viên";
            this.quảnLýCánBộGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCánBộGiáoViênToolStripMenuItem_Click);
            // 
            // phânCôngGiảngDạyToolStripMenuItem
            // 
            this.phânCôngGiảngDạyToolStripMenuItem.Name = "phânCôngGiảngDạyToolStripMenuItem";
            this.phânCôngGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.phânCôngGiảngDạyToolStripMenuItem.Text = "Phân công giảng dạy";
            this.phânCôngGiảngDạyToolStripMenuItem.Click += new System.EventHandler(this.phânCôngGiảngDạyToolStripMenuItem_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpDanhSáchHọcSinhToolStripMenuItem,
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê báo cáo";
            // 
            // lậpDanhSáchHọcSinhToolStripMenuItem
            // 
            this.lậpDanhSáchHọcSinhToolStripMenuItem.Name = "lậpDanhSáchHọcSinhToolStripMenuItem";
            this.lậpDanhSáchHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.lậpDanhSáchHọcSinhToolStripMenuItem.Text = "Lập danh sách học sinh";
            this.lậpDanhSáchHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.lậpDanhSáchHọcSinhToolStripMenuItem_Click);
            // 
            // lậpDanhSáchGiáoViênDạyToolStripMenuItem
            // 
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem.Name = "lậpDanhSáchGiáoViênDạyToolStripMenuItem";
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem.Text = "Lập danh sách giáo viên dạy";
            this.lậpDanhSáchGiáoViênDạyToolStripMenuItem.Click += new System.EventHandler(this.lậpDanhSáchGiáoViênDạyToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // stsMain
            // 
            this.stsMain.Location = new System.Drawing.Point(0, 639);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(980, 22);
            this.stsMain.TabIndex = 2;
            this.stsMain.Text = "statusStrip1";
            // 
            // quảnLýĐiểmToolStripMenuItem1
            // 
            this.quảnLýĐiểmToolStripMenuItem1.Name = "quảnLýĐiểmToolStripMenuItem1";
            this.quảnLýĐiểmToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.quảnLýĐiểmToolStripMenuItem1.Text = "Quản lý điểm";
            this.quảnLýĐiểmToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem1_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 661);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnsMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Name = "MainGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quản trị hệ thống";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHồSơHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCánBộGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpDanhSáchHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpDanhSáchGiáoViênDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}