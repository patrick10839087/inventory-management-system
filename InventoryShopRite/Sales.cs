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
        private void userShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
