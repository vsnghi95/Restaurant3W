using BussinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class frmFoodManagement : Form
    {
        readonly IFoodRepository repository = new FoodRepository();
        public frmFoodManagement()
        {
            InitializeComponent();
        }

        public void LoadCategoryList()
        {
            try
            {
                var categoryList = repository.GetCategories();
                cbbCategory.DataSource = categoryList;
                cbbCategory.DisplayMember = "Catename";
                cbbCategory.ValueMember = "Cateid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }


        public void LoadFoodList()
        {
            try
            {
                var foodList = repository.GetFoods();
                BindingSource source = new BindingSource();
                source.DataSource = foodList;


                txtFoodID.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cbbCategory.DataBindings.Clear();

                txtFoodID.DataBindings.Add("Text", source, "fid");
                txtFoodName.DataBindings.Add("Text", source, "fname");
                txtPrice.DataBindings.Add("Text", source, "price");
                cbbCategory.DataBindings.Add("Text", source, "Cate.catename");


                dgvFood.DataSource = null;
                dgvFood.DataSource = source;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of foods");
            }
        }

        private void frmFoodManagement_Load(object sender, EventArgs e)
        {

            LoadCategoryList();
            LoadFoodList();
        }

        private void ClearText()
        {



            txtFoodID.Text = "";
            txtFoodName.Text = "";
            txtPrice.Text = "";
            cbbCategory.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;
                // Clear DataBinding



                txtFoodID.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cbbCategory.DataBindings.Clear();
                dgvFood.ClearSelection();

                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadFoodList();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            txtFoodID.Enabled = false;
            if (txtFoodName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("All fields are required!", "Food Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Food
                {
                   // Fid = int.Parse(txtFoodID.Text),
                    Fname = txtFoodName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Cateid = int.Parse(cbbCategory.SelectedValue.ToString()),


                };
                repository.SaveFood(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;

                LoadFoodList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Food food = new Food()
            {
                Fid = int.Parse(txtFoodID.Text),
                Fname= txtFoodName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Cateid= int.Parse(cbbCategory.SelectedValue.ToString()),



            };

            repository.UpdateFood(food);
            LoadFoodList();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this record?", "Food Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var p = new Food
                    {
                      Fid = int.Parse(txtFoodID.Text),
                    };
                    repository.DeleteFood(p);
                    LoadFoodList();
                }
            }
        }

        private void dgvFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dgvFood.CurrentCell.RowIndex;
            Food food = repository.GetFoodByIndex(Index);
            txtFoodID.Text = food.Fid.ToString();
            txtFoodName.Text = food.Fname.ToString();
            txtPrice.Text = food.Price.ToString();
            cbbCategory.Text = food.Cateid.ToString();


        }
    }
}


