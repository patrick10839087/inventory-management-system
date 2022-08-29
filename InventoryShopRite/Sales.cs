using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryShopRite
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            curData();
        }
        DataTable table = new DataTable();
        // establishing database connection
        public static string connectionString = "server=localhost;database=inventory-management-system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        void curData()
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM products WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }
        int num = 0;
        string product;
        int quantity, uPrice, totPrice;
        void comboFill()
        {
            string query = "SELECT * FROM categories";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            try
            {
                connection.Open();
                DataTable dTable = new DataTable();
                dTable.Columns.Add("catName", typeof(string));
                reader = command.ExecuteReader();
                dTable.Load(reader);
                //comboCat.ValueMember = "catName";
                //comboCat.DataSource = dTable;
                comboSearch.ValueMember = "catName";
                comboSearch.DataSource = dTable;
                connection.Close();

            }
            catch
            {

            }
        }
        int flag = 0;
        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userShow.Rows[e.RowIndex];
                //num = Convert.ToInt32(row.Cells[0].Value.ToString());
                product = row.Cells[1].Value.ToString();
                //quantity = Convert.ToInt32(quantityBox.Text);
                uPrice = Convert.ToInt32(row.Cells[3].Value.ToString());
                //totPrice = quantity * uPrice;
                flag = 1;
            }
        }

        private void userShow1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dTable = new DataTable();

            userShow1.DataSource = dTable;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (quantityBox.Text == "")
                MessageBox.Show("ENTER THE NUMBER OF PRODUCTS");
            else if (flag == 0)
                MessageBox.Show("SELECT THE PRODUCT");
            else
            {
                num += 1;
                quantity = Convert.ToInt32(quantityBox.Text);
                totPrice = quantity * uPrice;
                table.Rows.Add(num, product, quantity, uPrice, totPrice);
                userShow1.DataSource = table;
                flag = 0;
            }
            sum = sum + totPrice;
            TotAmount.Text = "GHS " + sum.ToString();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM products WHERE proCategory = '" + comboSearch.SelectedValue.ToString() + "'", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            comboFill();

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Unit Price", typeof(int));
            table.Columns.Add("Total Price", typeof(int));

            userShow1.DataSource = table;
        }
    }
}
