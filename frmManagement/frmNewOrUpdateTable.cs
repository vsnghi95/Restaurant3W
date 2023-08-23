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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmManagement
{
    public partial class frmNewOrUpdateTable : Form
    {
        public frmNewOrUpdateTable()
        {
            InitializeComponent();
        }
        public bool InsertOrUpdate { get; set; }
        ITableRepository tableRepository = new TableRepository();
        private void btInsertorUpdate_Click(object sender, EventArgs e)
        {
            bool check = ValidateForm();

            if (check == false)
            {
                ValidateForm();
            }
            else
            {   
                TablesRe tablesRe = new TablesRe()
                {   
                    Tid = int.Parse(txtTableID.Text),
                    TableName = txtTableName.Text,
                    Capacity = int.Parse(txtCapacity.Text),
                    Status = Boolean.Parse(txtStatus.Text),
                };
                if (InsertOrUpdate == false)
                {
                    ValidateTableId();
                    // Insert
                    tableRepository.tableNew(tablesRe);
                    this.Close();
                   
                }
                else
                {
                    //update
                    tableRepository.tableUpdate(tablesRe);
                    this.Close();

                }
            }








        }
        public void checkButton()
        {
            btInsertorUpdate.Text = "Update";
        }
        public void getTable(TablesRe table)
        {
            if (table != null)
            {
                txtTableID.Enabled = false;
                txtTableID.Text = table.Tid.ToString();
                txtTableName.Text = table.TableName.ToString();
                txtCapacity.Text = table.Capacity.ToString();
                txtStatus.Text = table.Status.ToString();
            }
            else
            {
                MessageBox.Show("Null index");
            }
        }

        private void txtStatus_Validating(object sender, CancelEventArgs e)
        {
            ValidateStatus();
        }

        private void txtCapacity_Validating(object sender, CancelEventArgs e)
        {
            ValidateCapacity();
        }
        private bool ValidateTableId()
        {
            bool bStatus = true;
            if (txtTableID.Text == "")
            {
                errorProvider.SetError(txtTableID, "Please enter your Table Id");
                bStatus = false;
            }
            else
            {
                int temp = int.Parse(txtTableID.Text);
                errorProvider.SetError(txtTableID, "");
                if (tableRepository.checkAlreadyId(int.Parse(txtTableID.Text)) != null)
                {
                    errorProvider.SetError(txtTableID, "Id already exists");
                    bStatus = false;
                }
                else if (temp <= 0)
                {
                    errorProvider.SetError(txtTableID, "Id must be number");
                    bStatus = false;
                }
                else
                {
                    errorProvider.SetError(txtTableID, "");
                }
            }
            return bStatus;
        }

        private bool ValidateCapacity()
        {
            bool bStatus = true;
            if (txtCapacity.Text == "")
            {
                errorProvider.SetError(txtCapacity, "Please enter your Capacity");
                bStatus = false;
            }
            else
            {
                int temp = int.Parse(txtCapacity.Text);
                errorProvider.SetError(txtCapacity, "");
                if (temp > 13 || temp < 1)
                {
                    errorProvider.SetError(txtCapacity, "Capacity must be <= 12 and >= 1");
                    bStatus = false;
                }
                else
                {
                    errorProvider.SetError(txtCapacity, "");
                }
            }
            return bStatus;
        }
        private bool ValidateStatus()
        {
            bool bStatus = true;
            if (txtStatus.Text == "")
            {
                errorProvider.SetError(txtStatus, "Please enter status");
                bStatus = false;
            }
            else if (txtStatus.Text != "True" && txtStatus.Text != "False")
            {
                errorProvider.SetError(txtStatus, "Please enter True or False!");
                bStatus = false;
            }
            else
                errorProvider.SetError(txtStatus, "");
            return bStatus;
        }
        private bool ValidateForm()
        {
            bool check = true;
            bool bValiCapacity = ValidateCapacity();
            bool bValidStatus = ValidateStatus();
            /*bool bValiId = ValidateTableId();*/
            bool bvalidName = ValidateName();
            if (bValiCapacity == true && bValidStatus == true /*&& bValiId == true*/ && bvalidName == true)
            {
                MessageBox.Show("Susscessfully");
                check = true;
            }

            else
            {
                MessageBox.Show("Please enter valid data");
                check = false;
            }
            return check;

        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtTableName.Text == "")
            {
                errorProvider.SetError(txtTableName, "Please enter your table name");
                bStatus = false;
            }
            else
            {
                errorProvider.SetError(txtCapacity, "");
            }
            return bStatus;

           
        }

        private void frmNewOrUpdateTable_Load(object sender, EventArgs e)
        {

        }

        private void txtTableID_Validating(object sender, CancelEventArgs e)
        {
            ValidateTableId();
        }

        private void txtTableName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
    }
}
