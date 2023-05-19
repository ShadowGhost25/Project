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
    public partial class NewZoo : Form
    {
        public NewZoo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewZoo_Load(object sender, EventArgs e)
        {
            Connection.adap.SelectCommand = new MySqlCommand("SELECT name FROM city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable city = new DataTable();
            Connection.adap.Fill(city);
            Connection.connect.Close();
            foreach(DataRow row in city.Rows)
            {
                comboBox1.Items.Add(row["name"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];

            Connection.adap.SelectCommand = new MySqlCommand("SELECT name FROM category", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable category = new DataTable();
            Connection.adap.Fill(category);
            Connection.connect.Close();
            foreach (DataRow row in category.Rows)
            {
                comboBox2.Items.Add(row["name"].ToString());
            }
            comboBox2.SelectedItem = comboBox2.Items[0];
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO zoo(name,description,category,city,date1,date2,price,value) VALUES(@name,@description,@category,@city,@date1,@date2,@price,@value)", Connection.connect);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@name", textBox1.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@description", textBox2.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@category", comboBox2.SelectedItem);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@city", comboBox1.SelectedItem);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            Connection.adap.InsertCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("dd-MM-yyyy"));
            Connection.adap.InsertCommand.Parameters.AddWithValue("@price", textBox3.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@value", textBox4.Text);
            Connection.connect.Open();
            Connection.adap.InsertCommand.ExecuteNonQuery();
            Connection.connect.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
