namespace GUI
{
    partial class FileMuon
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
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.quanLyThuVienEautDataSet1 = new GUI.QuanLyThuVienEautDataSet1();
            this.phieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuTableAdapter = new GUI.QuanLyThuVienEautDataSet1TableAdapters.PhieuTableAdapter();
            this.dgv_muon = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuat File Muon";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(436, 195);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(164, 43);
            this.btnXuatFile.TabIndex = 2;
            this.btnXuatFile.Text = "XuatFileMuon";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyThuVienEautDataSet1
            // 
            this.quanLyThuVienEautDataSet1.DataSetName = "QuanLyThuVienEautDataSet1";
            this.quanLyThuVienEautDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuBindingSource
            // 
            this.phieuBindingSource.DataMember = "Phieu";
            this.phieuBindingSource.DataSource = this.quanLyThuVienEautDataSet1;
            // 
            // phieuTableAdapter
            // 
            this.phieuTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_muon
            // 
            this.dgv_muon.AutoGenerateColumns = false;
            this.dgv_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.maPhieuDataGridViewTextBoxColumn,
            this.TrangThai});
            this.dgv_muon.DataSource = this.phieuBindingSource1;
            this.dgv_muon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_muon.Location = new System.Drawing.Point(0, 260);
            this.dgv_muon.Name = "dgv_muon";
            this.dgv_muon.RowHeadersWidth = 51;
            this.dgv_muon.RowTemplate.Height = 24;
            this.dgv_muon.Size = new System.Drawing.Size(1075, 190);
            this.dgv_muon.TabIndex = 1;
            this.dgv_muon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muon_CellContentClick);
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
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Sdt";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            this.maPhieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // phieuBindingSource1
            // 
            this.phieuBindingSource1.DataMember = "Phieu";
            this.phieuBindingSource1.DataSource = this.quanLyThuVienEautDataSet1;
            // 
            // FileMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgv_muon);
            this.Controls.Add(this.label1);
            this.Name = "FileMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMuon";
            this.Load += new System.EventHandler(this.FileMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatFile;
        private QuanLyThuVienEautDataSet1 quanLyThuVienEautDataSet1;
        private System.Windows.Forms.BindingSource phieuBindingSource;
        private QuanLyThuVienEautDataSet1TableAdapters.PhieuTableAdapter phieuTableAdapter;
        private System.Windows.Forms.DataGridView dgv_muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.BindingSource phieuBindingSource1;
    }
}