using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace InventoryShopRite
{
    public partial class Users : Form
    {
        // establishing database connection
        public static string connectionString = "server=localhost;database=inventory-management-system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Users()
        {
            InitializeComponent();
            //SQL table selection
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (firstName.Text == "" & surname.Text == "" & id.Text == "" & password.Text == "")
                {
                    MessageBox.Show("Please fill out fields");
                }
                else
                {
                    string query = "INSERT INTO users(id, firstname, surname, password) VALUES ('" + id.Text + "','" + firstName.Text + "','" + surname.Text + "', '" + password.Text + "')";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("User Added Succesfully");
                    connection.Close();
                    id.Text = String.Empty;
                    surname.Text = String.Empty;
                    firstName.Text = String.Empty;
                    password.Text = String.Empty;

                    id.Focus();
                }


                MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users WHERE 1", connection);
                DataTable dTable = new DataTable();
                adapterInstance.Fill(dTable);

                userShow.DataSource = dTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products product = new Products();
            product.Show();
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
    }
}
