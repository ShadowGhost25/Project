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
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }
        public static int y = 100;
        public static DataTable table = new DataTable();
        public static int item;
        public static string searchtext;

        public void selectQuery()
        {
            y = 100;
            Controls.Clear();
            table.Clear();

            if (Connection.admin)
            {
                Button newZoo = new Button();
                newZoo.Location = new Point(10, 120);
                newZoo.Size = new Size(160, 23);
                newZoo.Text = "Добавить новый товар";
                newZoo.BackColor = Color.IndianRed;
                newZoo.ForeColor = Color.White;
                newZoo.FlatStyle = FlatStyle.Flat;
                newZoo.Font = new Font(newZoo.Font, FontStyle.Bold);
                newZoo.FlatAppearance.BorderSize = 0;
                newZoo.Click += newZoo_Click;
                this.Controls.Add(newZoo);

                Button newCity = new Button();
                newCity.Location = new Point(20, 160);
                newCity.Size = new Size(132, 23);
                newCity.Text = "Добавить город";
                newCity.BackColor = Color.IndianRed;
                newCity.ForeColor = Color.White;
                newCity.FlatStyle = FlatStyle.Flat;
                newCity.Font = new Font(newCity.Font, FontStyle.Bold);
                newCity.FlatAppearance.BorderSize = 0;
                newCity.Click += newCity_Click;
                this.Controls.Add(newCity);
            }

            PictureBox Logo = new PictureBox();
            Logo.Location = new Point(10, 5);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.Size = new Size(164, 100);
            Logo.Image = Properties.Resources.draw_svg20210819_17584_16ngk8w_svg;
            this.Controls.Add(Logo);

            TextBox searchField = new TextBox();
            searchField.Location = new Point(406, 20);
            searchField.Size = new Size(180, 20);
            searchField.Name = "searchField";
            this.Controls.Add(searchField);
            searchField.Text = searchtext;

            ComboBox cityBox = new ComboBox();
            cityBox.Location = new Point(250, 20);
            cityBox.Size = new Size(121, 21);
            cityBox.Name = "cityBox";
            cityBox.BackColor = Color.IndianRed;
            cityBox.ForeColor = Color.White;
            cityBox.Font = new Font(cityBox.Font, FontStyle.Bold);
            this.Controls.Add(cityBox); 
            cityBox.Items.Add("Все");
            cityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Connection.adap.SelectCommand = new MySqlCommand("SELECT name FROm city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable city = new DataTable();
            Connection.adap.Fill(city);
            Connection.connect.Close();
            foreach(DataRow row in city.Rows)
            {
                (this.Controls["cityBox"] as ComboBox).Items.Add(row["name"].ToString());
            }
            (this.Controls["cityBox"] as ComboBox).SelectedItem = (this.Controls["cityBox"] as ComboBox).Items[item];
            

            Button searchClick = new Button();
            searchClick.Location = new Point(610, 20);
            searchClick.Size = new Size(75, 23);
            searchClick.Text = "Поиск";
            searchClick.BackColor = Color.IndianRed;
            searchClick.ForeColor = Color.White;
            searchClick.FlatStyle = FlatStyle.Flat;
            searchClick.Font = new Font(searchClick.Font, FontStyle.Bold);
            searchClick.FlatAppearance.BorderSize = 0;
            searchClick.Click += search;
            this.Controls.Add(searchClick);

            Button orders = new Button();
            orders.Location = new Point(710, 20);
            orders.Size = new Size(156, 23);
            orders.Text = "Мои заказы";
            orders.BackColor = Color.IndianRed;
            orders.ForeColor = Color.White;
            orders.FlatStyle = FlatStyle.Flat;
            orders.Font = new Font(orders.Font, FontStyle.Bold);
            orders.FlatAppearance.BorderSize = 0;
            orders.Click += orders_Click;
            this.Controls.Add(orders);

            Button goOut = new Button();
            goOut.Location = new Point(970, 45);
            goOut.Size = new Size(100, 23);
            goOut.Text = "Выйти";
            goOut.BackColor = Color.IndianRed;
            goOut.ForeColor = Color.White;
            goOut.FlatStyle = FlatStyle.Flat;
            goOut.Font = new Font(goOut.Font, FontStyle.Bold);
            goOut.FlatAppearance.BorderSize = 0;
            goOut.Click += goOut_Click;
            this.Controls.Add(goOut);

            Label FullName = new Label();
            FullName.Location = new Point(930, 25);
            FullName.Size = new Size(1015, 30);
            FullName.Font = new Font(FullName.Font, FontStyle.Bold);
            FullName.Text = Connection.FIOUser;
            FullName.Click += FullName_Click;
            this.Controls.Add(FullName);

            string query = ("SELECT * FROM zoo WHERE name LIKE '%" + (this.Controls["searchField"] as TextBox).Text + "%\'");
            
            if((this.Controls["cityBox"] as ComboBox).SelectedItem.ToString() != "Все")
            {
                query += (" AND city = '" + (this.Controls["cityBox"] as ComboBox).SelectedItem.ToString() + "'");
            }
            Connection.adap.SelectCommand = new MySqlCommand(query, Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            Connection.adap.Fill(table);
            Connection.connect.Close();

            foreach(DataRow row in table.Rows)
            {

                GroupBox newGroupBox = new GroupBox();
                newGroupBox.Location = new Point(180, y);
                newGroupBox.Text = "";
                newGroupBox.Size = new Size(800, 400);
                this.Controls.Add(newGroupBox);
                y += 450;

                PictureBox newImage = new PictureBox();
                newImage.Location = new Point(550, 25);
                newImage.Size = new Size(200, 200);
                newImage.SizeMode = PictureBoxSizeMode.Zoom;
                newImage.ImageLocation = row["picture"].ToString();
                newGroupBox.Controls.Add(newImage);

                Label newHeaderLabel = new Label();
                newHeaderLabel.Location = new Point(20, 20);
                newHeaderLabel.Size = new Size(250, 20);
                newHeaderLabel.Text = row["name"].ToString();
                newHeaderLabel.Font = new Font(newHeaderLabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newHeaderLabel);

                Label newDescriptionlabel = new Label();
                newDescriptionlabel.Location = new Point(20, 50);
                newDescriptionlabel.Size = new Size(500, 100);
                newDescriptionlabel.Text = "Описание : " + row["description"].ToString();
                newDescriptionlabel.Font = new Font(newDescriptionlabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newDescriptionlabel);

                Label newCategorylabel = new Label();
                newCategorylabel.Location = new Point(20, 150);
                newCategorylabel.Size = new Size(200, 19);
                newCategorylabel.Text = "Категории: " + row["category"].ToString();
                newCategorylabel.Font = new Font(newCategorylabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newCategorylabel);

                Label newCitylabel = new Label();
                newCitylabel.Location = new Point(20, 205);
                newCitylabel.Size = new Size(200, 19);
                newCitylabel.Text = "Город: " + row["city"].ToString();
                newCitylabel.Font = new Font(newCitylabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newCitylabel);

                Label newDate1label = new Label();
                newDate1label.Location = new Point(20, 250);
                newDate1label.Size = new Size(300, 19);
                newDate1label.Text = "Дата привоза: " + row["date1"].ToString();
                newDate1label.Font = new Font(newDate1label.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newDate1label);

                Label newDate2label = new Label();
                newDate2label.Location = new Point(20, 300);
                newDate2label.Size = new Size(200, 19);
                newDate2label.Text = "Дата отвоза: " + row["date2"].ToString();
                newDate2label.Font = new Font(newDate2label.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newDate2label);

                Label newPricelabel = new Label();
                newPricelabel.Location = new Point(70, 335);
                newPricelabel.Size = new Size(170, 19);
                newPricelabel.Text = "Цена: " + row["price"].ToString() + " .руб";
                newPricelabel.Font = new Font(newPricelabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newPricelabel);

                Label newValuelabel = new Label();
                newValuelabel.Location = new Point(240, 335);
                newValuelabel.Size = new Size(100, 19);
                newValuelabel.Text = "Кол-во: " + row["value"].ToString();
                newValuelabel.Font = new Font(newValuelabel.Font.FontFamily, 10, FontStyle.Bold);
                newGroupBox.Controls.Add(newValuelabel);

                Button buy = new Button();
                buy.Location = new Point(660, 335);
                buy.Size = new Size(100, 23);
                buy.Text = "Купить";
                buy.BackColor = Color.IndianRed;
                buy.ForeColor = Color.White;
                buy.Font = new Font(buy.Font, FontStyle.Bold);
                buy.FlatStyle = FlatStyle.Flat;
                buy.Name = row["id"].ToString();
                buy.Click += buy_Click;
                newGroupBox.Controls.Add(buy);

                if (Connection.admin == true)
                {
                    Button delete = new Button();
                    delete.Location = new Point(550, 335);
                    delete.Size = new Size(100, 23);
                    delete.Text = "Удалить";
                    delete.BackColor = Color.IndianRed;
                    delete.ForeColor = Color.White;
                    delete.FlatStyle = FlatStyle.Flat;
                    delete.Font = new Font(delete.Font, FontStyle.Bold);
                    delete.Click += delete_Click;
                    delete.Name = row["id"].ToString();
                    newGroupBox.Controls.Add(delete);
                }
            }
        }
        private void newZoo_Click(object sender, EventArgs e)
        {
            NewZoo f = new NewZoo();
            f.ShowDialog();
        }
        private void search(object sender, EventArgs e)
        {
            item = (this.Controls["cityBox"] as ComboBox).SelectedIndex;
            searchtext = (this.Controls["searchField"] as TextBox).Text;
            selectQuery();
        }
        private void buy_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Connection.adap.UpdateCommand = new MySqlCommand("UPDATE zoo SET value = value-1 WHERE id= @id", Connection.connect);
            Connection.adap.UpdateCommand.Parameters.AddWithValue("@id", btn.Name);
            Connection.connect.Open();
            Connection.adap.UpdateCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();

            Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO orders (login, id_tovar) VALUES (@login, @id_tovar)", Connection.connect);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@login", Connection.UserLogin);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@id_tovar", btn.Name);
            Connection.connect.Open();
            Connection.adap.InsertCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Connection.adap.DeleteCommand = new MySqlCommand("DELETE FROM zoo WHERE id = @id", Connection.connect);
            Connection.adap.DeleteCommand.Parameters.AddWithValue("@id", deleteButton.Name);
            Connection.connect.Open();
            Connection.adap.DeleteCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();
        }
        private void goOut_Click(object sender, EventArgs e)
        {
            Connection.FIOUser = "";
            Connection.UserLogin = "";
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        private void orders_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            f.ShowDialog();
            this.Close();
        }
        private void newCity_Click(object sender, EventArgs e)
        {
            NewCity f = new NewCity();
            f.ShowDialog();
        }
        private void Main2_Load(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FullName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
