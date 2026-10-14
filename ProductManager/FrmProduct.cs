using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        private readonly BindingList<Product> _products = new BindingList<Product>();
        private string _searchKeyword = string.Empty;
        private bool _refreshing;

        public FrmProduct()
        {
            InitializeComponent();
        }

        #region Nhóm 1 - Khởi tạo dữ liệu và hiển thị bảng
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboLoaiSP.Items.Clear();
            cboLoaiSP.Items.AddRange(new object[]
            {
                "Điện tử", "Văn phòng", "Gia dụng", "Thời trang"
            });

            ConfigureGrid();
            _products.Add(new Product
            {
                MaSP = "SP001", TenSP = "Chuột không dây", LoaiSP = "Điện tử",
                DonGia = 250000M, SoLuong = 15, NgayNhap = DateTime.Today.AddDays(-2),
                ConKinhDoanh = true, DuongDanAnh = string.Empty
            });
            _products.Add(new Product
            {
                MaSP = "SP002", TenSP = "Sổ tay A5", LoaiSP = "Văn phòng",
                DonGia = 35000M, SoLuong = 50, NgayNhap = DateTime.Today.AddDays(-1),
                ConKinhDoanh = true, DuongDanAnh = string.Empty
            });
            _products.Add(new Product
            {
                MaSP = "SP003", TenSP = "Bình giữ nhiệt", LoaiSP = "Gia dụng",
                DonGia = 180000M, SoLuong = 0, NgayNhap = DateTime.Today,
                ConKinhDoanh = false, DuongDanAnh = string.Empty
            });

            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã tải 3 sản phẩm mẫu. Dữ liệu được lưu trong bộ nhớ.");
        }

        private void ConfigureGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            AddTextColumn("colMaSP", "MaSP", "Mã SP", 24);
            AddTextColumn("colTenSP", "TenSP", "Tên sản phẩm", 48);
            AddTextColumn("colLoaiSP", "LoaiSP", "Loại", 30);
            AddTextColumn("colDonGia", "DonGia", "Đơn giá (đ)", 32, "N2");
            AddTextColumn("colSoLuong", "SoLuong", "Số lượng", 24, "N0");
            AddTextColumn("colNgayNhap", "NgayNhap", "Ngày nhập", 30, "dd/MM/yyyy");

            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colConKinhDoanh", DataPropertyName = "ConKinhDoanh",
                HeaderText = "Còn kinh doanh", FillWeight = 30,
                MinimumWidth = 90, SortMode = DataGridViewColumnSortMode.NotSortable
            });
            AddTextColumn("colDuongDanAnh", "DuongDanAnh", "Đường dẫn ảnh", 48);
            dgvProducts.Columns["colDonGia"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns["colSoLuong"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvProducts.DataSource = bsProducts;
        }

        private void AddTextColumn(string name, string property, string title,
            float weight, string format = "")
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name, DataPropertyName = property, HeaderText = title,
                FillWeight = weight, MinimumWidth = 65,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            column.DefaultCellStyle.Format = format;
            dgvProducts.Columns.Add(column);
        }

        private void RefreshGrid()
        {
            _refreshing = true;
            try
            {
                // Lọc danh sách hiển thị, giữ nguyên danh sách gốc _products.
                var result = _products.Where(p => _searchKeyword.Length == 0 ||
                    p.MaSP.IndexOf(_searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenSP.IndexOf(_searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0);
                bsProducts.DataSource = new BindingList<Product>(result.ToList());
                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
            }
            finally
            {
                _refreshing = false;
            }
        }
        #endregion

        #region Nhóm 2 - Chọn dòng, nhập liệu và kiểm tra dữ liệu
        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count == 0)
                return null;
            return dgvProducts.SelectedRows[0].DataBoundItem as Product;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (_refreshing) return;
            Product product = GetSelectedProduct();
            if (product == null) return;
            LoadProductToForm(product);
            UpdateStatus("Đã chọn " + product.MaSP + ". Chỉnh thông tin rồi nhấn Sửa để lưu.");
        }

        private void LoadProductToForm(Product product)
        {
            errorProvider1.Clear();
            txtMaSP.Text = product.MaSP;
            txtTenSP.Text = product.TenSP;
            cboLoaiSP.SelectedItem = product.LoaiSP;
            numDonGia.Value = product.DonGia;
            numSoLuong.Value = product.SoLuong;
            dtpNgayNhap.Value = product.NgayNhap;
            chkConKinhDoanh.Checked = product.ConKinhDoanh;
            txtDuongDanAnh.Text = product.DuongDanAnh;
            ReplacePreviewImage(null);

            if (!string.IsNullOrWhiteSpace(product.DuongDanAnh))
            {
                string error;
                if (!TryLoadPreview(product.DuongDanAnh, out error))
                    errorProvider1.SetError(picAnh, "Không tải được ảnh: " + error);
            }
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = cboLoaiSP.Items.Count > 0 ? 0 : -1;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            txtDuongDanAnh.Clear();
            ReplacePreviewImage(null);
            errorProvider1.Clear();
            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
            txtMaSP.Focus();
        }

        private bool ValidateInput(Product editingProduct = null)
        {
            errorProvider1.Clear();
            Control firstInvalid = null;
            string code = txtMaSP.Text.Trim();

            if (code.Length == 0)
                MarkInvalid(txtMaSP, "Mã sản phẩm không được để trống.", ref firstInvalid);
            else if (_products.Any(p => !ReferenceEquals(p, editingProduct) &&
                string.Equals(p.MaSP, code, StringComparison.OrdinalIgnoreCase)))
                MarkInvalid(txtMaSP, "Mã sản phẩm đã tồn tại.", ref firstInvalid);

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                MarkInvalid(txtTenSP, "Tên sản phẩm không được để trống.", ref firstInvalid);
            if (cboLoaiSP.SelectedIndex < 0)
                MarkInvalid(cboLoaiSP, "Hãy chọn loại sản phẩm.", ref firstInvalid);
            if (numDonGia.Value <= 0)
                MarkInvalid(numDonGia, "Đơn giá phải lớn hơn 0.", ref firstInvalid);
            if (numSoLuong.Value < 0)
                MarkInvalid(numSoLuong, "Số lượng không được âm.", ref firstInvalid);
            if (dtpNgayNhap.Value.Date > DateTime.Today)
                MarkInvalid(dtpNgayNhap, "Ngày nhập không được sau ngày hiện tại.", ref firstInvalid);

            if (firstInvalid == null) return true;
            firstInvalid.Focus();
            UpdateStatus("Dữ liệu chưa hợp lệ. Sửa các ô có biểu tượng lỗi.");
            return false;
        }

        private void MarkInvalid(Control control, string message, ref Control firstInvalid)
        {
            errorProvider1.SetError(control, message);
            if (firstInvalid == null) firstInvalid = control;
        }

        private void ReadInputInto(Product product)
        {
            product.MaSP = txtMaSP.Text.Trim();
            product.TenSP = txtTenSP.Text.Trim();
            product.LoaiSP = cboLoaiSP.SelectedItem.ToString();
            product.DonGia = numDonGia.Value;
            product.SoLuong = (int)numSoLuong.Value;
            product.NgayNhap = dtpNgayNhap.Value.Date;
            product.ConKinhDoanh = chkConKinhDoanh.Checked;
            product.DuongDanAnh = txtDuongDanAnh.Text.Trim();
        }
        #endregion

        #region Nhóm 3 - Thêm, sửa và xóa
        private void Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var product = new Product();
            ReadInputInto(product);
            _products.Add(product);
            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã thêm " + product.MaSP + ".");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null)
            {
                ShowSelectionWarning("sửa");
                return;
            }
            // Bỏ qua chính sản phẩm đang sửa khi kiểm tra mã trùng.
            if (!ValidateInput(product)) return;
            ReadInputInto(product);
            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã cập nhật " + product.MaSP + ".");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null)
            {
                ShowSelectionWarning("xóa");
                return;
            }

            DialogResult answer = MessageBox.Show(this,
                "Xóa sản phẩm " + product.MaSP + " - " + product.TenSP + "?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes)
            {
                UpdateStatus("Đã hủy thao tác xóa.");
                return;
            }

            _products.Remove(product);
            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã xóa " + product.MaSP + ".");
        }

        private void ShowSelectionWarning(string action)
        {
            string message = "Hãy chọn một dòng sản phẩm trước khi " + action + ".";
            MessageBox.Show(this, message, "Chưa chọn sản phẩm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus(message);
        }
        #endregion

        #region Nhóm 4 - Tìm kiếm và làm mới
        private void Search_Click(object sender, EventArgs e)
        {
            _searchKeyword = txtTuKhoa.Text.Trim();
            RefreshGrid();
            ClearInput();
            UpdateStatus(_searchKeyword.Length == 0
                ? "Đang hiển thị toàn bộ sản phẩm."
                : "Tìm \"" + _searchKeyword + "\": " + bsProducts.Count + " kết quả.");
            txtTuKhoa.Focus();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            _searchKeyword = string.Empty;
            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã làm mới ô nhập và hiển thị toàn bộ danh sách.");
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            Search_Click(sender, EventArgs.Empty);
            e.SuppressKeyPress = true;
        }
        #endregion

        #region Nhóm 5 - Chọn và xem ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog(this) != DialogResult.OK) return;
            string error;
            if (!TryLoadPreview(dlgOpenImage.FileName, out error))
            {
                MessageBox.Show(this, "Không thể mở ảnh: " + error,
                    "Ảnh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateStatus("Chọn ảnh thất bại.");
                return;
            }
            txtDuongDanAnh.Text = dlgOpenImage.FileName;
            errorProvider1.SetError(picAnh, string.Empty);
            UpdateStatus("Đã chọn ảnh. Nhấn Thêm hoặc Sửa để lưu vào sản phẩm.");
        }

        private bool TryLoadPreview(string path, out string error)
        {
            error = string.Empty;
            try
            {
                // Sao chép ảnh để không giữ khóa file gốc sau khi đọc.
                using (var stream = new FileStream(path, FileMode.Open,
                    FileAccess.Read, FileShare.ReadWrite))
                using (Image original = Image.FromStream(stream))
                {
                    ReplacePreviewImage(new Bitmap(original));
                }
                return true;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException ||
                ex is ArgumentException || ex is ExternalException || ex is OutOfMemoryException)
            {
                error = "File không tồn tại, không đọc được hoặc không phải ảnh hợp lệ.";
                return false;
            }
        }

        private void ReplacePreviewImage(Image image)
        {
            Image oldImage = picAnh.Image;
            picAnh.Image = image;
            if (oldImage != null) oldImage.Dispose();
        }

        private void FrmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReplacePreviewImage(null);
            dlgOpenImage.Dispose();
        }
        #endregion

        #region Nhóm 6 - Chuột phải, chi tiết, phím tắt và thanh trạng thái
        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var hit = dgvProducts.HitTest(e.X, e.Y);
            dgvProducts.ClearSelection();
            if (hit.RowIndex < 0)
            {
                dgvProducts.CurrentCell = null;
                ClearInput();
                UpdateStatus("Chưa chọn sản phẩm.");
                return;
            }
            // Chọn đúng dòng đang nhấn chuột phải, kể cả khi dòng khác đã được chọn.
            dgvProducts.CurrentCell = dgvProducts.Rows[hit.RowIndex].Cells[0];
            dgvProducts.Rows[hit.RowIndex].Selected = true;
        }

        private void cmsProducts_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = GetSelectedProduct() == null;
        }

        private void EditFromContext_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null) { ShowSelectionWarning("sửa"); return; }
            LoadProductToForm(product);
            txtTenSP.Focus();
            txtTenSP.SelectAll();
            UpdateStatus("Chỉnh thông tin " + product.MaSP + ", rồi nhấn Sửa để lưu.");
        }

        private void Details_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null) { ShowSelectionWarning("xem chi tiết"); return; }
            var detail = new StringBuilder();
            detail.AppendLine("Mã sản phẩm: " + product.MaSP);
            detail.AppendLine("Tên sản phẩm: " + product.TenSP);
            detail.AppendLine("Loại: " + product.LoaiSP);
            detail.AppendLine("Đơn giá: " + product.DonGia.ToString("N2") + " đ");
            detail.AppendLine("Số lượng: " + product.SoLuong);
            detail.AppendLine("Ngày nhập: " + product.NgayNhap.ToString("dd/MM/yyyy"));
            detail.AppendLine("Trạng thái: " + (product.ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh"));
            detail.AppendLine("Ảnh: " + (string.IsNullOrWhiteSpace(product.DuongDanAnh)
                ? "Chưa chọn" : product.DuongDanAnh));
            MessageBox.Show(this, detail.ToString(), "Chi tiết sản phẩm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus("Đã xem chi tiết " + product.MaSP + ".");
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Details_Click(sender, EventArgs.Empty);
        }

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
            {
                Reset_Click(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.None && dgvProducts.ContainsFocus)
            {
                Delete_Click(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            lblCount.Text = "Tổng sản phẩm: " + _products.Count +
                "  |  Đang hiển thị: " + bsProducts.Count;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "1. Nhập thông tin rồi nhấn Thêm.\n" +
                "2. Chọn dòng, chỉnh thông tin rồi nhấn Sửa để lưu.\n" +
                "3. Chọn dòng rồi nhấn Xóa và xác nhận.\n" +
                "4. Nhập từ khóa trên toolbar, nhấn Tìm kiếm hoặc Enter.\n" +
                "5. Nhấn Làm mới để bỏ lọc và xóa ô nhập.\n\n" +
                "Ctrl+Insert: Thêm; Ctrl+S: Sửa; Ctrl+Delete: Xóa.\n" +
                "Ctrl+F: Tìm; F5 / Esc: Làm mới; Ctrl+Q: Thoát.\n" +
                "Chuột phải trên một dòng để Sửa, Xóa hoặc Xem chi tiết.\n\n" +
                "Dữ liệu chỉ nằm trong bộ nhớ và được khởi tạo lại khi mở ứng dụng.",
                "Hướng dẫn sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus("Đã mở hướng dẫn sử dụng.");
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "ProductManager - Quản lý sản phẩm\n" +
                "COMP1019 - Lập trình trên Windows\n" +
                "C# Windows Forms - .NET Framework 4.8",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus("Đã mở thông tin ứng dụng.");
        }
        #endregion

        private void lblNhomUngDung_Click(object sender, EventArgs e)
        {

        }
    }
}
