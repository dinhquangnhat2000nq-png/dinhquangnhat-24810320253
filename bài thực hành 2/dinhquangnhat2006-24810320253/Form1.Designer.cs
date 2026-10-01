namespace dinhquangnhat2006_24810320253
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flButtons;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTotal;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelLeft = new TableLayoutPanel();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            flButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            rightPanel = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslTotal = new ToolStripStatusLabel();
            bsProducts = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            flButtons.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutPanelMain.Controls.Add(rightPanel, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 28);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(800, 396);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 2;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Controls.Add(lblProductId, 0, 0);
            tableLayoutPanelLeft.Controls.Add(txtProductId, 1, 0);
            tableLayoutPanelLeft.Controls.Add(lblProductName, 0, 1);
            tableLayoutPanelLeft.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanelLeft.Controls.Add(lblUnitPrice, 0, 2);
            tableLayoutPanelLeft.Controls.Add(txtUnitPrice, 1, 2);
            tableLayoutPanelLeft.Controls.Add(lblQuantity, 0, 3);
            tableLayoutPanelLeft.Controls.Add(txtQuantity, 1, 3);
            tableLayoutPanelLeft.Controls.Add(lblCategory, 0, 4);
            tableLayoutPanelLeft.Controls.Add(cboCategory, 1, 4);
            tableLayoutPanelLeft.Controls.Add(picAvatar, 0, 5);
            tableLayoutPanelLeft.Controls.Add(btnChooseImage, 1, 5);
            tableLayoutPanelLeft.Controls.Add(flButtons, 0, 6);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(3, 3);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 7;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Size = new Size(274, 390);
            tableLayoutPanelLeft.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.Dock = DockStyle.Fill;
            lblProductId.Location = new Point(3, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(74, 30);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            lblProductId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductId
            // 
            txtProductId.Dock = DockStyle.Fill;
            txtProductId.Location = new Point(83, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(188, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(3, 30);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(74, 30);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(83, 33);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(188, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Location = new Point(3, 60);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(74, 30);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Đơn giá:";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(83, 63);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(188, 27);
            txtUnitPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(3, 90);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(74, 30);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(83, 93);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(188, 27);
            txtQuantity.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 30);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục:";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboCategory
            // 
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(83, 123);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(188, 28);
            cboCategory.TabIndex = 9;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(3, 153);
            picAvatar.MinimumSize = new Size(80, 80);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(80, 80);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 10;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Dock = DockStyle.Fill;
            btnChooseImage.Location = new Point(83, 153);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(188, 134);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.Text = "Chọn Ảnh";
            // 
            // flButtons
            // 
            tableLayoutPanelLeft.SetColumnSpan(flButtons, 2);
            flButtons.Controls.Add(btnAdd);
            flButtons.Controls.Add(btnUpdate);
            flButtons.Controls.Add(btnDelete);
            flButtons.Dock = DockStyle.Fill;
            flButtons.Location = new Point(3, 293);
            flButtons.Name = "flButtons";
            flButtons.Size = new Size(268, 94);
            flButtons.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Cập nhật";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            // 
            // rightPanel
            // 
            rightPanel.ColumnCount = 2;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            rightPanel.Controls.Add(lblSearch, 0, 0);
            rightPanel.Controls.Add(txtSearch, 1, 0);
            rightPanel.Controls.Add(dgvProducts, 0, 1);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(283, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 2;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightPanel.Size = new Size(514, 390);
            rightPanel.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.Dock = DockStyle.Top;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(122, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm tên:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(131, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 27);
            txtSearch.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeight = 29;
            rightPanel.SetColumnSpan(dgvProducts, 2);
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 33);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(508, 354);
            dgvProducts.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCsvToolStripMenuItem
            // 
            exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            exportCsvToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportCsvToolStripMenuItem.Size = new Size(215, 26);
            exportCsvToolStripMenuItem.Text = "Export CSV";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(215, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslTotal });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            // 
            // tslTotal
            // 
            tslTotal.Name = "tslTotal";
            tslTotal.Size = new Size(145, 20);
            tslTotal.Text = "Tổng số sản phẩm: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "TechMart Product Manager";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            flButtons.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel rightPanel;
    }
}
