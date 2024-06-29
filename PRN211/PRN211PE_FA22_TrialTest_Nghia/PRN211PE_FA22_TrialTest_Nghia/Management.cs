using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_FA22_TrialTest_Nghia
{
    public partial class Management : Form
    {
        private ElectricStoreDBContext _context;
        private ProductsServices _productsServices;
        public Management()
        {
            InitializeComponent();
            _context = new ElectricStoreDBContext();
            _productsServices = new ProductsServices(_context);

            var listAll = _productsServices.GetProducts();

            // Set the data source of the DataGridView
            dgvAdministrator.DataSource = new BindingSource() { DataSource = listAll };
        }

        private void LoadProductData()
        {
            var productList = _productsServices.GetProducts();
            dgvAdministrator.DataSource = new BindingSource { DataSource = productList };
        }

        private void ClearTextBoxes()
        {
            txtID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDateCreate.Text = string.Empty;
            txtProductCode.Text = string.Empty;

            // Set the necessary text boxes to read-only
            txtDateCreate.ReadOnly = true;
            txtCategoryID.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtProductName.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text.Trim();
            LoadProductData();

            if (string.IsNullOrEmpty(productCode))
            {
                MessageBox.Show("Please enter a product code to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = _productsServices.GetProductByCode(productCode);

            if (product != null)
            {
                txtID.Text = product.Id.ToString();
                txtProductName.Text = product.ProductName;
                txtCategoryID.Text = product.CategoryId.ToString();
                txtPrice.Text = product.Price.ToString();
                txtDateCreate.Text = product.DateCreate?.ToString("yyyy-MM-dd") ?? string.Empty;
                txtProductCode.Text = product.ProductCode.ToString();

                // Make the necessary text boxes editable
                txtDateCreate.ReadOnly = false;
                txtCategoryID.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtProductName.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Product not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Set the txtID textbox to read-only
            txtID.ReadOnly = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            int categoryId = int.Parse(txtCategoryID.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime dateCreate = DateTime.Today; // Set the DateCreate to today's date
            string productCode = txtProductCode.Text.Trim().ToUpper(); // Convert to uppercase

            // Validate Price
            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Products object with the entered data
            var newProduct = new Products
            {
                ProductName = productName,
                CategoryId = categoryId,
                Price = price,
                DateCreate = dateCreate,
                ProductCode = productCode
            };

            // Add the new product to the database
            _productsServices.AddProduct(newProduct);

            // Refresh the data in the DataGridView
            LoadProductData();

            // Clear the textboxes
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtID.Text);
            string productName = txtProductName.Text.Trim();
            int categoryId = int.Parse(txtCategoryID.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime dateCreate = DateTime.Parse(txtDateCreate.Text);
            string productCode = txtProductCode.Text.Trim().ToUpper(); // Convert to uppercase

            // Find the product to update
            var productToUpdate = _productsServices.GetProductByCode(productCode);

            if (productToUpdate != null)
            {
                // Check if the DateCreate is being changed
                if (dateCreate != productToUpdate.DateCreate)
                {
                    MessageBox.Show("DateCreate cannot be changed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Price
                if (price <= 0)
                {
                    MessageBox.Show("Price must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the product properties
                productToUpdate.ProductName = productName;
                productToUpdate.CategoryId = categoryId;
                productToUpdate.Price = price;
                productToUpdate.DateCreate = dateCreate;
                productToUpdate.ProductCode = productCode;

                // Save the changes to the database
                _productsServices.UpdateProduct(productToUpdate);

                // Refresh the data in the DataGridView
                LoadProductData();

                // Clear the textboxes
                ClearTextBoxes();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text.Trim();

            // Find the product to delete
            var productToDelete = _productsServices.GetProductByCode(productCode);

            if (productToDelete != null)
            {
                // Delete the product from the database
                _productsServices.DeleteProduct(productToDelete);

                // Refresh the data in the DataGridView
                LoadProductData();

                // Clear the textboxes
                ClearTextBoxes();
            }
        }
    }
}
