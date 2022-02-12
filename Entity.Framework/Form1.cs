using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void ListProducts()
        {
            dgvProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                ProductName = tbxProductName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
            });
            ListProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value),
                ProductName = tbxUpdateProductName.Text,
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
            });
            ListProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value),
            });
            ListProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            tbxUpdateStockAmount.Text = dgvProducts.CurrentRow.Cells["StockAmount"].Value.ToString();
            tbxUpdateUnitPrice.Text = dgvProducts.CurrentRow.Cells["UnitPrice"].Value.ToString();
        }
    }
}
