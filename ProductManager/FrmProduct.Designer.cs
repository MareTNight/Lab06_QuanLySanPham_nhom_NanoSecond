namespace ProductManager
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tslTuKhoa = new System.Windows.Forms.ToolStripLabel();
            this.txtTuKhoa = new System.Windows.Forms.ToolStripTextBox();
            this.tsbTimKiem = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblNhomUngDung = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblDuongDanAnh = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSua = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHint = new System.Windows.Forms.Label();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuQuanLy,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLamMoi,
            this.fileSeparator,
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuLamMoi
            // 
            this.mnuLamMoi.Name = "mnuLamMoi";
            this.mnuLamMoi.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuLamMoi.Size = new System.Drawing.Size(183, 26);
            this.mnuLamMoi.Text = "Làm mới";
            this.mnuLamMoi.Click += new System.EventHandler(this.Reset_Click);
            // 
            // fileSeparator
            // 
            this.fileSeparator.Name = "fileSeparator";
            this.fileSeparator.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuThoat.Size = new System.Drawing.Size(183, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.Exit_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThem,
            this.mnuSua,
            this.mnuXoa,
            this.mnuTimKiem});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(73, 24);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuThem
            // 
            this.mnuThem.Name = "mnuThem";
            this.mnuThem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.mnuThem.Size = new System.Drawing.Size(202, 26);
            this.mnuThem.Text = "Thêm";
            this.mnuThem.Click += new System.EventHandler(this.Add_Click);
            // 
            // mnuSua
            // 
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSua.Size = new System.Drawing.Size(202, 26);
            this.mnuSua.Text = "Sửa";
            this.mnuSua.Click += new System.EventHandler(this.Update_Click);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuXoa.Size = new System.Drawing.Size(202, 26);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.Delete_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuTimKiem.Size = new System.Drawing.Size(202, 26);
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.Search_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuGioiThieu});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(78, 24);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(224, 26);
            this.mnuHuongDan.Text = "Hướng dẫn sử dụng";
            this.mnuHuongDan.Click += new System.EventHandler(this.Help_Click);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(224, 26);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLamMoi,
            this.toolSeparator,
            this.tslTuKhoa,
            this.txtTuKhoa,
            this.tsbTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.toolStrip1.Size = new System.Drawing.Size(1184, 33);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbThem
            // 
            this.tsbThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbThem.Size = new System.Drawing.Size(66, 24);
            this.tsbThem.Text = "Thêm";
            this.tsbThem.Click += new System.EventHandler(this.Add_Click);
            // 
            // tsbSua
            // 
            this.tsbSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbSua.Size = new System.Drawing.Size(54, 24);
            this.tsbSua.Text = "Sửa";
            this.tsbSua.Click += new System.EventHandler(this.Update_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbXoa.Size = new System.Drawing.Size(55, 24);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tsbLamMoi
            // 
            this.tsbLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLamMoi.Name = "tsbLamMoi";
            this.tsbLamMoi.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbLamMoi.Size = new System.Drawing.Size(87, 24);
            this.tsbLamMoi.Text = "Làm mới";
            this.tsbLamMoi.Click += new System.EventHandler(this.Reset_Click);
            // 
            // toolSeparator
            // 
            this.toolSeparator.Name = "toolSeparator";
            this.toolSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // tslTuKhoa
            // 
            this.tslTuKhoa.Name = "tslTuKhoa";
            this.tslTuKhoa.Size = new System.Drawing.Size(68, 24);
            this.tslTuKhoa.Text = "Mã / tên:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.AutoSize = false;
            this.txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(210, 27);
            this.txtTuKhoa.ToolTipText = "Tìm theo mã hoặc tên; nhấn Enter để tìm";
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // tsbTimKiem
            // 
            this.tsbTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTimKiem.Name = "tsbTimKiem";
            this.tsbTimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbTimKiem.Size = new System.Drawing.Size(90, 24);
            this.tsbTimKiem.Text = "Tìm kiếm";
            this.tsbTimKiem.Click += new System.EventHandler(this.Search_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.statusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 30);
            this.statusStrip1.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(905, 24);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Sẵn sàng";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            this.lblCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblCount.Name = "lblCount";
            this.lblCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCount.Size = new System.Drawing.Size(264, 24);
            this.lblCount.Text = "Tổng sản phẩm: 0  |  Đang hiển thị: 0";
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.pnlTieuDe, 0, 0);
            this.layoutMain.Controls.Add(this.grpThongTin, 0, 1);
            this.layoutMain.Controls.Add(this.grpDanhSach, 0, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 61);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(12);
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1184, 669);
            this.layoutMain.TabIndex = 2;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblMoTa);
            this.pnlTieuDe.Controls.Add(this.lblNhomUngDung);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTieuDe.Location = new System.Drawing.Point(12, 12);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1160, 58);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(10, 3);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(620, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // lblMoTa
            // 
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMoTa.Location = new System.Drawing.Point(12, 38);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(730, 20);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Nhập thông tin sản phẩm hoặc chọn một dòng trong danh sách để chỉnh sửa.";
            // 
            // lblNhomUngDung
            // 
            this.lblNhomUngDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhomUngDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblNhomUngDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhomUngDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblNhomUngDung.Location = new System.Drawing.Point(930, 10);
            this.lblNhomUngDung.Name = "lblNhomUngDung";
            this.lblNhomUngDung.Size = new System.Drawing.Size(210, 26);
            this.lblNhomUngDung.TabIndex = 2;
            this.lblNhomUngDung.Text = "QUẢN LÝ CỬA HÀNG";
            this.lblNhomUngDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhomUngDung.Click += new System.EventHandler(this.lblNhomUngDung_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Controls.Add(this.lblMaSP);
            this.grpThongTin.Controls.Add(this.lblTenSP);
            this.grpThongTin.Controls.Add(this.lblLoaiSP);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.lblNgayNhap);
            this.grpThongTin.Controls.Add(this.lblDuongDanAnh);
            this.grpThongTin.Controls.Add(this.lblAnh);
            this.grpThongTin.Controls.Add(this.txtMaSP);
            this.grpThongTin.Controls.Add(this.txtTenSP);
            this.grpThongTin.Controls.Add(this.cboLoaiSP);
            this.grpThongTin.Controls.Add(this.numDonGia);
            this.grpThongTin.Controls.Add(this.numSoLuong);
            this.grpThongTin.Controls.Add(this.dtpNgayNhap);
            this.grpThongTin.Controls.Add(this.chkConKinhDoanh);
            this.grpThongTin.Controls.Add(this.txtDuongDanAnh);
            this.grpThongTin.Controls.Add(this.picAnh);
            this.grpThongTin.Controls.Add(this.btnChonAnh);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Location = new System.Drawing.Point(12, 76);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1160, 290);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblMaSP.Location = new System.Drawing.Point(22, 35);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(100, 22);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblTenSP
            // 
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTenSP.Location = new System.Drawing.Point(22, 75);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(100, 22);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLoaiSP.Location = new System.Drawing.Point(22, 115);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(100, 22);
            this.lblLoaiSP.TabIndex = 2;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblDonGia
            // 
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDonGia.Location = new System.Drawing.Point(400, 35);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(100, 22);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn giá (đ)";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSoLuong.Location = new System.Drawing.Point(400, 75);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 22);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNgayNhap.Location = new System.Drawing.Point(400, 115);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(100, 22);
            this.lblNgayNhap.TabIndex = 5;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblDuongDanAnh
            // 
            this.lblDuongDanAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDuongDanAnh.Location = new System.Drawing.Point(22, 195);
            this.lblDuongDanAnh.Name = "lblDuongDanAnh";
            this.lblDuongDanAnh.Size = new System.Drawing.Size(102, 22);
            this.lblDuongDanAnh.TabIndex = 6;
            this.lblDuongDanAnh.Text = "Đường dẫn ảnh";
            // 
            // lblAnh
            // 
            this.lblAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblAnh.Location = new System.Drawing.Point(920, 28);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(205, 22);
            this.lblAnh.TabIndex = 7;
            this.lblAnh.Text = "Ảnh sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Location = new System.Drawing.Point(128, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(250, 27);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Location = new System.Drawing.Point(128, 71);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(250, 27);
            this.txtTenSP.TabIndex = 1;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(128, 111);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(250, 28);
            this.cboLoaiSP.TabIndex = 2;
            // 
            // numDonGia
            // 
            this.numDonGia.DecimalPlaces = 2;
            this.numDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDonGia.Location = new System.Drawing.Point(510, 31);
            this.numDonGia.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(220, 27);
            this.numDonGia.TabIndex = 3;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(510, 71);
            this.numSoLuong.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(220, 27);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.ThousandsSeparator = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(510, 111);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(220, 27);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // chkConKinhDoanh
            // 
            this.chkConKinhDoanh.Checked = true;
            this.chkConKinhDoanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConKinhDoanh.Location = new System.Drawing.Point(128, 152);
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Size = new System.Drawing.Size(250, 27);
            this.chkConKinhDoanh.TabIndex = 6;
            this.chkConKinhDoanh.Text = "Còn kinh doanh";
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuongDanAnh.Location = new System.Drawing.Point(128, 192);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(602, 27);
            this.txtDuongDanAnh.TabIndex = 7;
            this.txtDuongDanAnh.TabStop = false;
            // 
            // picAnh
            // 
            this.picAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnh.BackColor = System.Drawing.Color.White;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(920, 52);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(205, 150);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 8;
            this.picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnChonAnh.Location = new System.Drawing.Point(920, 210);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(205, 32);
            this.btnChonAnh.TabIndex = 8;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(128, 238);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 34);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSua.Location = new System.Drawing.Point(244, 238);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 34);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnXoa.Location = new System.Drawing.Point(360, 238);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 34);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.Location = new System.Drawing.Point(476, 238);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(106, 34);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.Reset_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.BackColor = System.Drawing.Color.White;
            this.grpDanhSach.Controls.Add(this.dgvProducts);
            this.grpDanhSach.Controls.Add(this.lblHint);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(12, 376);
            this.grpDanhSach.Margin = new System.Windows.Forms.Padding(0);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10, 24, 10, 10);
            this.grpDanhSach.Size = new System.Drawing.Size(1160, 281);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách sản phẩm";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ContextMenuStrip = this.cmsProducts;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvProducts.Location = new System.Drawing.Point(10, 44);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1140, 203);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            this.dgvProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseDown);
            // 
            // cmsProducts
            // 
            this.cmsProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSua,
            this.cmsXoa,
            this.cmsChiTiet});
            this.cmsProducts.Name = "cmsProducts";
            this.cmsProducts.Size = new System.Drawing.Size(158, 76);
            this.cmsProducts.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProducts_Opening);
            // 
            // cmsSua
            // 
            this.cmsSua.Name = "cmsSua";
            this.cmsSua.Size = new System.Drawing.Size(157, 24);
            this.cmsSua.Text = "Sửa";
            this.cmsSua.Click += new System.EventHandler(this.EditFromContext_Click);
            // 
            // cmsXoa
            // 
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(157, 24);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.Delete_Click);
            // 
            // cmsChiTiet
            // 
            this.cmsChiTiet.Name = "cmsChiTiet";
            this.cmsChiTiet.Size = new System.Drawing.Size(157, 24);
            this.cmsChiTiet.Text = "Xem chi tiết";
            this.cmsChiTiet.Click += new System.EventHandler(this.Details_Click);
            // 
            // lblHint
            // 
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(10, 247);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(1140, 24);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Chọn dòng để sửa / xóa. Chuột phải mở menu; nhấp đúp xem chi tiết.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả file (" +
    "*.*)|*.*";
            this.dlgOpenImage.Title = "Chọn ảnh sản phẩm";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 760);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1060, 700);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduct_FormClosed);
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuLamMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuThem;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripSeparator fileSeparator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbLamMoi;
        private System.Windows.Forms.ToolStripButton tsbTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolSeparator;
        private System.Windows.Forms.ToolStripLabel tslTuKhoa;
        private System.Windows.Forms.ToolStripTextBox txtTuKhoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblNhomUngDung;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblDuongDanAnh;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ContextMenuStrip cmsProducts;
        private System.Windows.Forms.ToolStripMenuItem cmsSua;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private System.Windows.Forms.ToolStripMenuItem cmsChiTiet;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
    }
}
