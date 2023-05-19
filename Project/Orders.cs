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

namespace Project
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            Connection.adap.SelectCommand = new MySqlCommand(
                "SELECT users.fio, zoo.name, zoo.city, zoo.date1, zoo.date2 " +
                "FROM (users, zoo) " +
                "JOIN orders ON orders.login = users.login AND orders.id_tovar = zoo.id " +
                "WHERE orders.login = @login", Connection.connect);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@login", Connection.UserLogin);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            Connection.adap.Fill(table);
            Connection.connect.Close();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
