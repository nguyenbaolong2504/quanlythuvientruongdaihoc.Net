namespace GUI
{
    partial class XuatFileTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tra = new System.Windows.Forms.DataGridView();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienEautDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienEautDataSet1 = new GUI.QuanLyThuVienEautDataSet1();
            this.btn_Tra = new System.Windows.Forms.Button();
            this.phieuTableAdapter = new GUI.QuanLyThuVienEautDataSet1TableAdapters.PhieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuat File Tra";
            // 
            // dgv_tra
            // 
            this.dgv_tra.AutoGenerateColumns = false;
            this.dgv_tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.maSVDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.dgv_tra.DataSource = this.phieuBindingSource;
            this.dgv_tra.Location = new System.Drawing.Point(12, 252);
            this.dgv_tra.Name = "dgv_tra";
            this.dgv_tra.RowHeadersWidth = 51;
            this.dgv_tra.RowTemplate.Height = 24;
            this.dgv_tra.Size = new System.Drawing.Size(1003, 198);
            this.dgv_tra.TabIndex = 1;
            this.dgv_tra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tra_CellContentClick);
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            this.maPhieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Sdt";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuBindingSource
            // 
            this.phieuBindingSource.DataMember = "Phieu";
            this.phieuBindingSource.DataSource = this.quanLyThuVienEautDataSet1BindingSource;
            // 
            // quanLyThuVienEautDataSet1BindingSource
            // 
            this.quanLyThuVienEautDataSet1BindingSource.DataSource = this.quanLyThuVienEautDataSet1;
            this.quanLyThuVienEautDataSet1BindingSource.Position = 0;
            // 
            // quanLyThuVienEautDataSet1
            // 
            this.quanLyThuVienEautDataSet1.DataSetName = "QuanLyThuVienEautDataSet1";
            this.quanLyThuVienEautDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Tra
            // 
            this.btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tra.Location = new System.Drawing.Point(441, 124);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(150, 53);
            this.btn_Tra.TabIndex = 2;
            this.btn_Tra.Text = "XuatFileTra";
            this.btn_Tra.UseVisualStyleBackColor = true;
            this.btn_Tra.Click += new System.EventHandler(this.btn_Tra_Click);
            // 
            // phieuTableAdapter
            // 
            this.phieuTableAdapter.ClearBeforeFill = true;
            // 
            // XuatFileTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.btn_Tra);
            this.Controls.Add(this.dgv_tra);
            this.Controls.Add(this.label1);
            this.Name = "XuatFileTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuatFileTra";
            this.Load += new System.EventHandler(this.XuatFileTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tra;
        private System.Windows.Forms.Button btn_Tra;
        private System.Windows.Forms.BindingSource quanLyThuVienEautDataSet1BindingSource;
        private QuanLyThuVienEautDataSet1 quanLyThuVienEautDataSet1;
        private System.Windows.Forms.BindingSource phieuBindingSource;
        private QuanLyThuVienEautDataSet1TableAdapters.PhieuTableAdapter phieuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
    }
}