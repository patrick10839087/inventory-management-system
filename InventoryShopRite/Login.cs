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
            MySqlDataAdapter adapterInstance = new MySqlDataAdapter("SELECT * FROM users1 WHERE 1", connection);
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
            string userName, userPassword, userLevel;
            userName = userIDTab.Text;
            userPassword = passwordTab.Text;
            userLevel = comboAccess.SelectedItem.ToString();

            try
            {
                string query = "SELECT firstName, password, accessLevel FROM users1 WHERE firstName='" + userIDTab.Text + "' AND password='" + passwordTab.Text + "' AND accessLevel='" + comboAccess.SelectedItem.ToString() + "'";

                MySqlDataAdapter adapterInstance = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                adapterInstance.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    userName = userIDTab.Text;
                    userPassword = passwordTab.Text;
                    userLevel = comboAccess.SelectedItem.ToString();

                    if (userLevel == "ADMIN")
                    {
                        // moving to admin screen
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.Show();
                    }

                    if (userLevel == "ATTENDANT")
                    {
                        // attendant screen
                        this.Hide();
                        Sales sales = new();
                        sales.Show();
                    }
                }
                else
                {
                    MessageBox.Show("ENTER VALID CREDENTIALS");
                    userIDTab.Clear();
                    passwordTab.Clear();
                    //comboAccess.Items.Clear();
                    userIDTab.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine("errorrrr " + ex);
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