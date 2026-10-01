using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace dinhquangnhat2006_24810320253
{
    public partial class Form1 : Form
    {
        private BindingList<Product> masterList = new BindingList<Product>();
        public Form1()
        {
            InitializeComponent();
            InitializeRuntime();
        }

        private void InitializeRuntime()
        {
            // categories
            cboCategory.Items.AddRange(new[] { "Điện thoại", "Laptop", "Phụ kiện" });
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // binding
            bsProducts.DataSource = masterList;
            dgvProducts.DataSource = bsProducts;

            // setup DGV columns
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ProductId", HeaderText = "Mã SP" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ProductName", HeaderText = "Tên SP", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Danh Mục" });
            var priceCol = new DataGridViewTextBoxColumn() { DataPropertyName = "UnitPrice", HeaderText = "Đơn Giá" };
            priceCol.DefaultCellStyle.Format = "N0";
            dgvProducts.Columns.Add(priceCol);
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Quantity", HeaderText = "Số Lượng" });

            // events
            btnChooseImage.Click += BtnChooseImage_Click;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            exportCsvToolStripMenuItem.Click += ExportCsvToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += (s, e) => Close();

            masterList.ListChanged += MasterList_ListChanged;
            UpdateTotalStatus();
        }

        private void MasterList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            UpdateTotalStatus();
        }

        private void UpdateTotalStatus()
        {
            tslTotal.Text = $"Tổng số sản phẩm: {masterList.Count}";
        }

        private void BtnChooseImage_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picAvatar.Image?.Dispose();
                    picAvatar.Image = Image.FromFile(dlg.FileName);
                    picAvatar.Tag = dlg.FileName;
                }
                catch
                {
                    MessageBox.Show("Không thể nạp ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Tên SP không được để trống");
                ok = false;
            }
            if (!decimal.TryParse(txtUnitPrice.Text, out var price) || price <= 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá phải > 0");
                ok = false;
            }
            if (!int.TryParse(txtQuantity.Text, out var qty) || qty < 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải >= 0");
                ok = false;
            }
            return ok;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            var p = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.SelectedItem?.ToString() ?? string.Empty,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImagePath = picAvatar.Tag as string ?? string.Empty
            };
            masterList.Add(p);
            ClearInputs();
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInputs()) return;
            var sel = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (sel == null) return;
            sel.ProductId = txtProductId.Text.Trim();
            sel.ProductName = txtProductName.Text.Trim();
            sel.Category = cboCategory.SelectedItem?.ToString() ?? string.Empty;
            sel.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            sel.Quantity = int.Parse(txtQuantity.Text);
            sel.ImagePath = picAvatar.Tag as string ?? string.Empty;
            // notify list change
            var idx = masterList.IndexOf(sel);
            if (idx >= 0) masterList.ResetItem(idx);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            var sel = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (sel == null) return;
            var res = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                masterList.Remove(sel);
            }
        }

        private void DgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            var sel = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (sel == null) return;
            txtProductId.Text = sel.ProductId;
            txtProductName.Text = sel.ProductName;
            txtUnitPrice.Text = sel.UnitPrice.ToString();
            txtQuantity.Text = sel.Quantity.ToString();
            if (!string.IsNullOrEmpty(sel.Category))
            {
                var idx = cboCategory.FindStringExact(sel.Category);
                if (idx >= 0) cboCategory.SelectedIndex = idx;
            }
            if (!string.IsNullOrEmpty(sel.ImagePath) && File.Exists(sel.ImagePath))
            {
                try
                {
                    picAvatar.Image?.Dispose();
                    picAvatar.Image = Image.FromFile(sel.ImagePath);
                    picAvatar.Tag = sel.ImagePath;
                }
                catch { }
            }
            else
            {
                picAvatar.Image = null;
                picAvatar.Tag = null;
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q))
            {
                bsProducts.DataSource = masterList;
            }
            else
            {
                var filtered = masterList.Where(p => p.ProductName.Contains(q, StringComparison.CurrentCultureIgnoreCase)).ToList();
                bsProducts.DataSource = new BindingList<Product>(filtered);
            }
            dgvProducts.Refresh();
        }

        private void ExportCsvToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog();
            dlg.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dlg.FileName = "products.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CsvExporter.ExportToCsv(masterList.ToList(), dlg.FileName);
                    MessageBox.Show("Export thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            picAvatar.Image = null;
            picAvatar.Tag = null;
        }
    }
}
