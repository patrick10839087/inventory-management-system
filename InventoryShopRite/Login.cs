using MySql.Data.MySqlClient;
using System.Data;

namespace InventoryShopRite
{
    public partial class Login : Form
    {
        // establishing database connection
        public static string connectionString = "server=localhost;database=inventory-management-system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Login()
        {
            InitializeComponent();
            //SQL table selection
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users WHERE 1", connection);
            DataTable dTable = new DataTable();
            adapterInstance.Fill(dTable);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userID, userPassword;
            userID = userIDTab.Text;
            userPassword = passwordTab.Text;

            try
            {
                string query = "SELECT id, password FROM users WHERE id='" + userIDTab.Text + "' AND password='" + passwordTab.Text + "'";

                MySqlDataAdapter adapterInstance = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                adapterInstance.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    userID = userIDTab.Text;
                    userPassword = passwordTab.Text;

                    // MessageBox.Show("Login Successfull");

                    // moving to next screen
                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Enter a valid ID or password");
                    userIDTab.Clear();
                    passwordTab.Clear();

                    userIDTab.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTab.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            userIDTab.Text = "";
            passwordTab.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}