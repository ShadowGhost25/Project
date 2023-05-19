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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void selectQuery()
        {
            label1.Text = Connection.FIOUser;
            string query = "SELECT * FROM zoo WHERE name LIKE '%" + textBox1.Text + "%\'";
            if(comboBox1.SelectedItem.ToString() != "Все")
            {
                query += (" AND city = '" + comboBox1.SelectedItem.ToString() + "'");
            }
            Connection.adap.SelectCommand = new MySqlCommand(query, Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable zoo = new DataTable();
            Connection.adap.Fill(zoo);
            Connection.connect.Close();
            dataGridView1.DataSource = zoo;
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].HeaderText = "Название товара";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Категории";
            dataGridView1.Columns[4].HeaderText = "Город";
            dataGridView1.Columns[5].HeaderText = "Дата привоза";
            dataGridView1.Columns[6].HeaderText = "Дата отправки";
            dataGridView1.Columns[7].HeaderText = "Цена";
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].HeaderText = "Кол-во товара";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if(Connection.admin == true)
            {
                button2.Visible = true;
                button3.Visible = true;
                button6.Visible = true;
            }
            comboBox1.Items.Add("Все");
            Connection.adap.SelectCommand = new MySqlCommand("SELECT name FROM city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable table = new DataTable();
            Connection.adap.Fill(table);
            Connection.connect.Close();
            foreach(DataRow row in table.Rows)
            {
                comboBox1.Items.Add(row["name"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
            selectQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.FIOUser = "";
            Connection.UserLogin = "";
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewCity f = new NewCity();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewZoo f = new NewZoo();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Date1_Click(object sender, EventArgs e)
        {

        }

        private void Value_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Header.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            Desc.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
            City.Text = "Город: " + dataGridView1.CurrentRow.Cells["city"].Value.ToString();
            Categ.Text = "Категория: " + dataGridView1.CurrentRow.Cells["category"].Value.ToString();
            Date1.Text = "Дата привоза: " + dataGridView1.CurrentRow.Cells["date1"].Value.ToString();
            Date2.Text = "Дата отправки: " + dataGridView1.CurrentRow.Cells["date2"].Value.ToString();
            Price.Text = "Цена: " + dataGridView1.CurrentRow.Cells["price"].Value.ToString() + " руб. ";
            Value.Text = "Кол-во оставшегося товара" + dataGridView1.CurrentRow.Cells["value"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Запрос на уменьшение количества товара
            Connection.adap.UpdateCommand = new MySqlCommand("UPDATE zoo SET value= value-1 WHERE id=@id", Connection.connect);
            Connection.adap.UpdateCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.UpdateCommand.ExecuteNonQuery();
            Connection.connect.Close();
            //Запрос на добавление в таблицу мои товары
            Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO orders (login, id_tovar) VALUES (@login,@id_tovar)", Connection.connect);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@login", Connection.UserLogin);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@id_tovar", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.InsertCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            f.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Desc_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Connection.adap.DeleteCommand = new MySqlCommand("DELETE FROM zoo WHERE id = @id", Connection.connect);
            Connection.adap.DeleteCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.DeleteCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();
        }
    }
}
