namespace Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Value = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Date1 = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.Label();
            this.Categ = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1253, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить новый товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить город";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(927, 392);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Date1);
            this.panel1.Controls.Add(this.Date2);
            this.panel1.Controls.Add(this.Categ);
            this.panel1.Controls.Add(this.City);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(969, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 411);
            this.panel1.TabIndex = 5;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(23, 324);
            this.Value.Name = "Value";
            this.Value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Value.Size = new System.Drawing.Size(148, 13);
            this.Value.TabIndex = 7;
            this.Value.Text = "Кол-во оставшегося товара";
            this.Value.Click += new System.EventHandler(this.Value_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(23, 371);
            this.Price.Name = "Price";
            this.Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Price.Size = new System.Drawing.Size(48, 20);
            this.Price.TabIndex = 6;
            this.Price.Text = "Цена";
            // 
            // Date1
            // 
            this.Date1.AutoSize = true;
            this.Date1.Location = new System.Drawing.Point(23, 241);
            this.Date1.Name = "Date1";
            this.Date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date1.Size = new System.Drawing.Size(78, 13);
            this.Date1.TabIndex = 5;
            this.Date1.Text = "Дата привоза";
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(23, 284);
            this.Date2.Name = "Date2";
            this.Date2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date2.Size = new System.Drawing.Size(83, 13);
            this.Date2.TabIndex = 4;
            this.Date2.Text = "Дата отправки";
            this.Date2.Click += new System.EventHandler(this.Date1_Click);
            // 
            // Categ
            // 
            this.Categ.AutoSize = true;
            this.Categ.Location = new System.Drawing.Point(23, 186);
            this.Categ.Name = "Categ";
            this.Categ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Categ.Size = new System.Drawing.Size(60, 13);
            this.Categ.TabIndex = 3;
            this.Categ.Text = "Категории";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(23, 139);
            this.City.Name = "City";
            this.City.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.City.Size = new System.Drawing.Size(37, 13);
            this.City.TabIndex = 2;
            this.City.Text = "Город";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(23, 54);
            this.Desc.MinimumSize = new System.Drawing.Size(250, 50);
            this.Desc.Name = "Desc";
            this.Desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Desc.Size = new System.Drawing.Size(250, 50);
            this.Desc.TabIndex = 1;
            this.Desc.Text = "Описание товара";
            this.Desc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Desc.Click += new System.EventHandler(this.Desc_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(64, 18);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(137, 17);
            this.Header.TabIndex = 0;
            this.Header.Text = "Название товара";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1081, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Купить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(784, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Мои заказы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(651, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 548);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Зоотовары";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Date1;
        private System.Windows.Forms.Label Date2;
        private System.Windows.Forms.Label Categ;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
    }
}