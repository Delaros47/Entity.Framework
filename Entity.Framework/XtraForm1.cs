using DevExpress.XtraEditors;
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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void ListProducts()
        {
            gcProducts.DataSource = _productDal.GetAll();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                ProductId = Convert.ToInt32(gvProducts.GetFocusedRowCellValue("ProductId")),
                ProductName = tbxUpdateProductName.Text,
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
            });
            ListProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvProducts.GetFocusedRowCellValue("ProductId"));
            _productDal.Delete(new Product { ProductId=id});
            ListProducts();
        }

        private void gvProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tbxUpdateProductName.Text = gvProducts.GetFocusedRowCellValue("ProductName").ToString();
            tbxUpdateStockAmount.Text = gvProducts.GetFocusedRowCellValue("StockAmount").ToString();
            tbxUpdateUnitPrice.Text = gvProducts.GetFocusedRowCellValue("UnitPrice").ToString();

        }

        private void tbxSearchProduct_EditValueChanged(object sender, EventArgs e)
        {
            gcProducts.DataSource = _productDal.GetByProductName(tbxSearchProduct.Text);
        }
    }
}