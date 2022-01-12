using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void FormShow(Form form)
        {
            form.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btunCustomers_Click(object sender, EventArgs e)
        {
            Customers customerForm = new Customers();
            FormShow(customerForm);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            FormShow(productsForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            FormShow(stock);
        }

        private void btnCommission_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            FormShow(order);
        }
    }
}
