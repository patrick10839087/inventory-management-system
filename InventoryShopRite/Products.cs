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
using System.Xml.Linq;

namespace InventoryShopRite
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            comboFill();
            curData();
        }
        // establishing database connection
        public static string connectionString = "server=localhost;database=inventory-management-system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        //fill combo box
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
                comboCat.ValueMember = "catName";
                comboCat.DataSource = dTable;
                comboSearch.ValueMember = "catName";
                comboSearch.DataSource = dTable;
                connection.Close();

            }
            catch
            {

            }
        }
       
        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user1 = new Users();
            user1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products product = new Products();
            product.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories cat = new Categories();
            cat.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void curData()
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM products WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }
        void filterByCategory()
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM products WHERE proCategory = '"+comboSearch.SelectedValue.ToString()+"'", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            /**if (proID.Text == "" & proName.Text == "" & proQuantity.Text == "" & proPrice.Text == "" & comboCat.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please fill out fields");
            }*/
            try
            {
                string query = "INSERT INTO products(proID, proName, proQuantity, proPrice, proCategory) VALUES ('" + proID.Text + "','" + proName.Text + "','" + proQuantity.Text + "' ,'" + proPrice.Text + "','" + comboCat.SelectedValue.ToString() + "')";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Product Added Succesfully");
                connection.Close();
                proID.Text = String.Empty;
                proName.Text = String.Empty;
                proQuantity.Text = String.Empty;
                proPrice.Text = String.Empty;
                proID.Focus();
                curData();
            }
            catch
            {

            }
            
        }

        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userShow.Rows[e.RowIndex];
                proID.Text = row.Cells[0].Value.ToString();
                proName.Text = row.Cells[1].Value.ToString();
                proQuantity.Text = row.Cells[2].Value.ToString();
                proPrice.Text = row.Cells[3].Value.ToString();
                comboCat.SelectedValue = row.Cells[4].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (proID.Text == "")
            {
                MessageBox.Show("ENTER PRODUCT ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "DELETE FROM products WHERE proID = '" + proID.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("PRODUCT DELETED");
                connection.Close();
                curData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (proID.Text == "")
            {
                MessageBox.Show("ENTER PRODUCT ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "UPDATE products SET proID = '" + this.proID.Text + "', proName= '" + this.proName.Text + "', proQuantity = '" + this.proQuantity.Text + "', proPrice='" + this.proPrice.Text + "', proCategory='"+ this.comboCat.SelectedValue+"' where proID='" + this.proID.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("PRODUCT UPDATED");
                connection.Close();
                curData();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            curData();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
