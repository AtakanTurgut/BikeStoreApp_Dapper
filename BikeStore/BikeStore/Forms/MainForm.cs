using BikeStore.Models.ViewModel;
using BikeStore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore.Forms
{
    public partial class MainForm : Form
    {
         public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void GetAllProducts()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                dgvProducts.DataSource = productRepository.GetAllDataList();
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int product_id = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
            Forms.UpdateProductForm updateProductForm = new UpdateProductForm(product_id);
            updateProductForm.ShowDialog(this);
        }

        private void ptnNewProduct_Click(object sender, EventArgs e)
        {
            InsertProductForm insertProductForm = new InsertProductForm();
            insertProductForm.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }
    }
}
