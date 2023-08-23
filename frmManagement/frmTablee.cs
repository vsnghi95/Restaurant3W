using BussinessObject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class frmTablee : Form
    {
        public frmTablee()
        {
            InitializeComponent();
        }
        public BindingSource source;
        ITableRepository tableRepository = new TableRepository();
        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loaddgvTable()
        {
            var listTable = tableRepository.getListTable();
            try
            {
                source = new BindingSource();
                source.DataSource = listTable;
                frmTablee frm = new frmTablee();
                dgvTable.DataSource = null;
                dgvTable.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list Table failed");
            }
        }

        private void frmTablee_Load(object sender, EventArgs e)
        {
            loaddgvTable();
        }

        private void btCancel_Click(object sender, EventArgs e) => this.Close();

        private void btDeleteTable_Click(object sender, EventArgs e)
        {
            int index = dgvTable.CurrentCell.RowIndex;
            if (index >= 0)
            {
                var table = tableRepository.getTableByIndex(index);
                tableRepository.tableDelete(table);
                loaddgvTable();
            }
            else
            {
                MessageBox.Show("Not select to delete");

            }


        }

        private void btAddTable_Click(object sender, EventArgs e)
        {
            frmNewOrUpdateTable frm = new frmNewOrUpdateTable()
            {
                Text = "New Table",
                InsertOrUpdate = false,
            };

            frm.ShowDialog();
            this.loaddgvTable();


        }

        private void dgvTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTable.CurrentCell.RowIndex;
            if (index > 0)
            {
                var table = tableRepository.getTableByIndex(index);
                // tableRepository.tableUpdate(table);
                frmNewOrUpdateTable frm = new frmNewOrUpdateTable()
                {
                    Text = "Update table",
                    InsertOrUpdate = true,
                };
                frm.getTable(table);
                frm.checkButton();
                frm.ShowDialog();
                this.loaddgvTable();
            }
        }

        private void btUpdateTable_Click(object sender, EventArgs e)
        {
            int Index = dgvTable.CurrentCell.RowIndex;
           
            if (Index > 0)
            {
                var table = tableRepository.getTableByIndex(Index);
                
                frmNewOrUpdateTable frm = new frmNewOrUpdateTable()
                {
                    Text = "Update table",
                    InsertOrUpdate = true,
                };
                frm.getTable(table);
                frm.checkButton();
                frm.ShowDialog();
                this.loaddgvTable();
            }
        }
    }
}
