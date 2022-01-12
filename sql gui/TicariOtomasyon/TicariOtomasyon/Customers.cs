using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TicariOtomasyon
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        MyConnection connectionCS = new MyConnection();
        GridView gridcs = new GridView();
        private void CustomerList() /* Müşteri Listeleme */
        {
            connectionCS.cmd = new SqlCommand("MusteriList", connectionCS.Connect());
            connectionCS.da = new SqlDataAdapter(connectionCS.cmd);
            connectionCS.ds = new DataSet();
            connectionCS.da.Fill(connectionCS.ds);
            customersGrid.DataSource = connectionCS.ds.Tables[0];
            customersGrid.RowHeadersVisible = false;
            customersGrid.Columns[0].Visible = false;
            for (int i = 1; i < 6; i++)
                customersGrid.Columns[i].Width = 138;
            gridcs.GridDesigner(customersGrid);
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }
        string id;
        private void customersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = customersGrid.CurrentRow.Index;
            id = customersGrid.Rows[row].Cells[0].Value.ToString();
            txtTC.Text = customersGrid.Rows[row].Cells[1].Value.ToString();
            txtName.Text = customersGrid.Rows[row].Cells[2].Value.ToString();
            txtSurname.Text = customersGrid.Rows[row].Cells[3].Value.ToString();
            txtContact.Text = customersGrid.Rows[row].Cells[4].Value.ToString();
            txtAdress.Text = customersGrid.Rows[row].Cells[5].Value.ToString();
        }
        private int CustomerUpdate() /* Müşteri Güncelleme*/
        {
            int resultReturn = 0;
            string proc = "MusteriGuncelle";
            connectionCS.cmd = new SqlCommand(proc, connectionCS.Connect());
            connectionCS.cmd.CommandType = CommandType.StoredProcedure;
            connectionCS.cmd.Parameters.Add("@id", id);
            connectionCS.cmd.Parameters.Add("@mTC", txtTC.Text);
            connectionCS.cmd.Parameters.Add("@mAd", txtName.Text);
            connectionCS.cmd.Parameters.Add("@mSoyad", txtSurname.Text);
            connectionCS.cmd.Parameters.Add("@mIletisim", txtContact.Text);
            connectionCS.cmd.Parameters.Add("@mAdres", txtAdress.Text);
            resultReturn = connectionCS.cmd.ExecuteNonQuery();
            CustomerList();
            connectionCS.ConnectionWizard();
            return resultReturn;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerUpdate() > 0) MessageBox.Show($"{txtName.Text} {txtSurname.Text} Kullanıcı Bilgisi Güncellendi", "BİLGİ");
        }
    }
}
