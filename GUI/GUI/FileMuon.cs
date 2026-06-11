using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
    public partial class FileMuon : Form
    {
        public FileMuon()
        {
            InitializeComponent();
        }

        private void dgv_muon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void exprot2Excel(DataGridView g, string duongdan, string tentap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < g.Rows.Count; i++) {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void FileMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienEautDataSet1.Phieu' table. You can move, or remove it, as needed.
            this.phieuTableAdapter.Fill(this.quanLyThuVienEautDataSet1.Phieu);

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            exprot2Excel(dgv_muon, @"D:\", "xuatfileMuonSach");
        }
    }
}
