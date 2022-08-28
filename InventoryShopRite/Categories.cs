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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            curData();
        }
        // establishing database connection
        public static string connectionString = "server=localhost;database=inventory-management-system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user1 = new Users();
            user1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products product = new Products();
            product.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories cat = new Categories();
            cat.Show();
        }
        void curData()
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM categories WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            if (catID.Text == "" & catName.Text == "" )
            {
                MessageBox.Show("Please fill out fields");
            }
            else
            {
                string query = "INSERT INTO categories(catID, catName) VALUES ('" + catID.Text + "','" + catName.Text + "')";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Category Added Succesfully");
                connection.Close();
                catName.Text = String.Empty;
                catID.Text = String.Empty;
                catID.Focus();
            }
            curData();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userShow.Rows[e.RowIndex];
                catID.Text = row.Cells[0].Value.ToString();
                catName.Text = row.Cells[1].Value.ToString();
                //surname.Text = row.Cells[2].Value.ToString();
                //password.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (catID.Text == "")
            {
                MessageBox.Show("ENTER CATEGORY ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "DELETE FROM categories WHERE catID = '" + catID.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("CATEGORY DELETED");
                connection.Close();
                curData();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (catID.Text == "")
            {
                MessageBox.Show("ENTER CATEGORY ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "UPDATE categories SET catID = '" + this.catID.Text + "', catName= '" + this.catName.Text + "' where catID='" + this.catID.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("CATEGORY UPDATED");
                connection.Close();
                curData();
            }
        }
    }
}
