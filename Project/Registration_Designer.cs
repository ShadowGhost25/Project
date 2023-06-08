namespace Tree_Shop
{
    partial class Registration
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
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(333, 569);
            label4.Name = "label4";
            label4.Size = new Size(223, 19);
            label4.TabIndex = 13;
            label4.Text = "Прикоснулись к деревьям? Войти";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 30, 30);
            button1.Location = new Point(363, 517);
            button1.Name = "button1";
            button1.Size = new Size(170, 37);
            button1.TabIndex = 12;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(333, 234);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 11;
            label3.Text = "Введите Пароль";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(333, 141);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 9;
            label2.Text = "Введите Логин";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 65);
            label1.Name = "label1";
            label1.Size = new Size(234, 50);
            label1.TabIndex = 7;
            label1.Text = "Регистрация";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(334, 418);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 17;
            label5.Text = "Ваш никнейм";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 449);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(334, 325);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 15;
            label6.Text = "Ваше имя";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(334, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 27);
            textBox4.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(317, 489);
            label7.Name = "label7";
            label7.Size = new Size(260, 20);
            label7.TabIndex = 18;
            label7.Text = "Такой пользователь уже существует";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(882, 653);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
    }
}