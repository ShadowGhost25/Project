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

namespace Tree_Shop
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 authoriz = new Form1();
            authoriz.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.adap.SelectCommand = new MySqlCommand("SELECT * FROM users WHERE login = @login", Connection.connect);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
            Connection.connect.Open();
            Connection.reader = Connection.adap.SelectCommand.ExecuteReader();
            if (!Connection.reader.Read())
            {
                Connection.connect.Close();
                Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO users(login, password, fio, nickname) VALUES(@login, @password, @fio, @nickname)", Connection.connect);
                Connection.adap.InsertCommand.Parameters.AddWithValue("@login", textBox1.Text);
                Connection.adap.InsertCommand.Parameters.AddWithValue("@password", textBox2.Text);
                Connection.adap.InsertCommand.Parameters.AddWithValue("@fio", textBox4.Text);
                Connection.adap.InsertCommand.Parameters.AddWithValue("@nickname", textBox3.Text);
                Connection.connect.Open();
                Connection.adap.InsertCommand.ExecuteNonQuery();
                Connection.connect.Close();
                Form1 authoriz = new Form1();
                authoriz.Show();
                this.Close();
            }
            else
            {
                Connection.connect.Close();
                label7.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
