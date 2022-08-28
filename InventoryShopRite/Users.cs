using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // filling dataGrid

            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users1 WHERE 1", connection);
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
        // filling dataFrame
        void curData()
        {
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users1 WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);

            userShow.DataSource = dTable;
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
                    string query = "INSERT INTO users1(id, firstname, surname, password) VALUES ('" + id.Text + "','" + firstName.Text + "','" + surname.Text + "', '" + password.Text + "')";
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


                curData();
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

        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /**firstName.Text = userShow.SelectedRows[0].Cells[0].Value.ToString();
            surname.Text = userShow.SelectedRows[0].Cells[1].Value.ToString();
            id.Text = userShow.SelectedRows[0].Cells[2].Value.ToString();
            password.Text = userShow.SelectedRows[0].Cells[3].Value.ToString();*/
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userShow.Rows[e.RowIndex];
                id.Text = row.Cells[0].Value.ToString();
                firstName.Text = row.Cells[1].Value.ToString();
                surname.Text = row.Cells[2].Value.ToString();
                password.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("ENTER USER ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "DELETE FROM users1 WHERE id = '" + id.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("USER DELETED");
                connection.Close();
                curData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("ENTER USER ID");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                string query = "UPDATE users1 SET id = '" + this.id.Text + "', firstName= '" + this.firstName.Text + "', surname = '"+ this.surname.Text+"', password='"+this.password.Text+"' where id='" + this.id.Text + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("USER UPDATED");
                connection.Close();
                curData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories cat = new Categories();
            cat.Show();
        }
    }
}
