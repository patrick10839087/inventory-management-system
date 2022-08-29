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
        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
