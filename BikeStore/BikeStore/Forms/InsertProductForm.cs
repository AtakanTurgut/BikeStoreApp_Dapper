using BikeStore.Models.StoreProcedure;
using BikeStore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore.Forms
{
    public partial class InsertProductForm : Form
    {
        public InsertProductForm()
        {
            InitializeComponent();
        }

        private void InsertProductForm_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
        }

        void GetBrands()
        {
            using (BrandRepository brandRepository = new BrandRepository())
            {
                cmbSaveBrands.DisplayMember = "brand_name";
                cmbSaveBrands.ValueMember = "brand_id";
                cmbSaveBrands.DataSource = brandRepository.GetAllData();
            }
        }

        void GetCategories()
        {
            using (CategoryRepository categoryRepository = new CategoryRepository())
            {
                cmbSaveCategories.DisplayMember = "category_name";
                cmbSaveCategories.ValueMember = "category_id";
                cmbSaveCategories.DataSource = categoryRepository.GetAllData();
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSP dataItem =new UpdateProductSP();
                dataItem.product_name = txtSaveProductName.Text;
                dataItem.model_year = int.Parse(txtSaveModelYear.Text);
                dataItem.list_price = decimal.Parse(txtSavePrice.Text);
                dataItem.brand_id = (int)cmbSaveBrands.SelectedValue;
                dataItem.category_id = (int)cmbSaveCategories.SelectedValue;

                int returnValue = productRepository.InsertData(dataItem);

                if (returnValue > 0) MessageBox.Show("Product Saved!", "Information");
                else MessageBox.Show("Product Failed to Save!", "Information");
            }

            this.Close();
        }
    }
}
