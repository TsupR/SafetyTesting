using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SafetyTesting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                string pathaccounts = "Accounts.db";
                string login;
                string password;
                login = textBox1.Text;
                password = textBox2.Text;
                using StreamWriter writer = new StreamWriter(pathaccounts, true);
                writer.Write("@" + login + "-" + password);
                MessageBox.Show("Новый профиль успешно создан!");
            }
            else
            {
                MessageBox.Show("Введите новый логин и пароль.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
