namespace WindowsFormsApp1
{
    partial class frmChuyenNganh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenNganh));
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCorrect = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dgvCN = new System.Windows.Forms.DataGridView();
            this.txtChuyenNganh = new System.Windows.Forms.TextBox();
            this.oPENLIBRARYDataSet = new WindowsFormsApp1.OPENLIBRARYDataSet();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYENNGANHTableAdapter = new WindowsFormsApp1.OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter();
            this.maCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(192, 71);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(95, 16);
            this.lblChuyenNganh.TabIndex = 0;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(195, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrect.ImageOptions.Image")));
            this.btnCorrect.Location = new System.Drawing.Point(345, 120);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(122, 65);
            this.btnCorrect.TabIndex = 2;
            this.btnCorrect.Text = "Sửa";
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(498, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 63);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCN
            // 
            this.dgvCN.AutoGenerateColumns = false;
            this.dgvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCNDataGridViewTextBoxColumn,
            this.tenCNDataGridViewTextBoxColumn});
            this.dgvCN.DataSource = this.cHUYENNGANHBindingSource;
            this.dgvCN.Location = new System.Drawing.Point(195, 221);
            this.dgvCN.Name = "dgvCN";
            this.dgvCN.RowHeadersWidth = 51;
            this.dgvCN.RowTemplate.Height = 24;
            this.dgvCN.Size = new System.Drawing.Size(416, 252);
            this.dgvCN.TabIndex = 4;
            this.dgvCN.SelectionChanged += new System.EventHandler(this.dgvCN_SelectionChanged);
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Location = new System.Drawing.Point(293, 68);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(318, 22);
            this.txtChuyenNganh.TabIndex = 5;
            // 
            // oPENLIBRARYDataSet
            // 
            this.oPENLIBRARYDataSet.DataSetName = "OPENLIBRARYDataSet";
            this.oPENLIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataMember = "CHUYENNGANH";
            this.cHUYENNGANHBindingSource.DataSource = this.oPENLIBRARYDataSet;
            // 
            // cHUYENNGANHTableAdapter
            // 
            this.cHUYENNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // maCNDataGridViewTextBoxColumn
            // 
            this.maCNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maCNDataGridViewTextBoxColumn.DataPropertyName = "MaCN";
            this.maCNDataGridViewTextBoxColumn.FillWeight = 150F;
            this.maCNDataGridViewTextBoxColumn.HeaderText = "Mã chuyên ngành";
            this.maCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCNDataGridViewTextBoxColumn.Name = "maCNDataGridViewTextBoxColumn";
            this.maCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCNDataGridViewTextBoxColumn.Width = 129;
            // 
            // tenCNDataGridViewTextBoxColumn
            // 
            this.tenCNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenCNDataGridViewTextBoxColumn.DataPropertyName = "TenCN";
            this.tenCNDataGridViewTextBoxColumn.FillWeight = 150F;
            this.tenCNDataGridViewTextBoxColumn.HeaderText = "Tên chuyên nghành";
            this.tenCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenCNDataGridViewTextBoxColumn.Name = "tenCNDataGridViewTextBoxColumn";
            this.tenCNDataGridViewTextBoxColumn.Width = 140;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 500);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.dgvCN);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblChuyenNganh);
            this.Name = "frmChuyenNganh";
            this.Text = "frmChuyenNganh";
            this.Load += new System.EventHandler(this.frmChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuyenNganh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCorrect;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridView dgvCN;
        private System.Windows.Forms.TextBox txtChuyenNganh;
        private OPENLIBRARYDataSet oPENLIBRARYDataSet;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter cHUYENNGANHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}