namespace GUI
{
    partial class TimKiemSach
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_QuanLyMuonTra = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienEautDataSet = new GUI.QuanLyThuVienEautDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sachTableAdapter = new GUI.QuanLyThuVienEautDataSetTableAdapters.SachTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(424, 361);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(179, 49);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "TimKiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(324, 153);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(328, 22);
            this.txtTimKiem.TabIndex = 8;
            // 
            // dgv_QuanLyMuonTra
            // 
            this.dgv_QuanLyMuonTra.AutoGenerateColumns = false;
            this.dgv_QuanLyMuonTra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_QuanLyMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.tacGiaDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgv_QuanLyMuonTra.DataSource = this.sachBindingSource;
            this.dgv_QuanLyMuonTra.Location = new System.Drawing.Point(199, 195);
            this.dgv_QuanLyMuonTra.Name = "dgv_QuanLyMuonTra";
            this.dgv_QuanLyMuonTra.RowHeadersWidth = 51;
            this.dgv_QuanLyMuonTra.RowTemplate.Height = 24;
            this.dgv_QuanLyMuonTra.Size = new System.Drawing.Size(622, 150);
            this.dgv_QuanLyMuonTra.TabIndex = 7;
            this.dgv_QuanLyMuonTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuanLyMuonTra_CellContentClick);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tacGiaDataGridViewTextBoxColumn
            // 
            this.tacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.HeaderText = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tacGiaDataGridViewTextBoxColumn.Name = "tacGiaDataGridViewTextBoxColumn";
            this.tacGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "NamXB";
            this.namXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.quanLyThuVienEautDataSet;
            // 
            // quanLyThuVienEautDataSet
            // 
            this.quanLyThuVienEautDataSet.DataSetName = "QuanLyThuVienEautDataSet";
            this.quanLyThuVienEautDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tim Kiem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tim Kiem Sach";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dgv_QuanLyMuonTra);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 518);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 518);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemSach";
            this.Load += new System.EventHandler(this.TimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienEautDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgv_QuanLyMuonTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanLyThuVienEautDataSet quanLyThuVienEautDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QuanLyThuVienEautDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}