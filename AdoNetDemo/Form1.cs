using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
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

            getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Length > 0 && txtPrice.Text.Length > 0 && txtAmount.Text.Length > 0)
            {
                string name = txtName.Text;
                string unitPrice = txtPrice.Text;
                int stockAmount = Convert.ToInt32(txtAmount.Text);
                _productDal.Add(new Product(name, unitPrice, stockAmount));
                
                getList();
                MessageBox.Show("All Okey");
            }
            else
            {
                MessageBox.Show("Alanlar boş olmamalı");
            }

        }

        public void getList()
        {
            dgwProducts.DataSource = _productDal.GetAlls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNameU.Text.Length > 0 && txtPriceU.Text.Length > 0 && txtAmountU.Text.Length > 0)
            {
                int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
                string name = txtNameU.Text;
                string unitPrice = txtPriceU.Text;
                int stockAmount = Convert.ToInt32(txtAmountU.Text);

                _productDal.Update(new Product(id, name, unitPrice, stockAmount));

                getList();
                MessageBox.Show("All Okey");
            }
            else
            {
                MessageBox.Show("Row seçili değil");
            }
        }


        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameU.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtPriceU.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString(); ;
            txtAmountU.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString(); ;
        }

        private void dgwProducts_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            getList();
            MessageBox.Show("Silindi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            getList();
            MessageBox.Show("Silindi");
        }
    }
}
