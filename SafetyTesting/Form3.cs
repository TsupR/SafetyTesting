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
    public partial class Form3 : Form
    {
        string path = "Questions.db";
        string textbufer;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Form3()
        {
            InitializeComponent();
            using StreamReader reader = new StreamReader(path);
            textBox1.Text = reader.ReadToEnd();
        }        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbufer = textBox1.Text;
            textBox1.Clear();
            using StreamWriter writer = new StreamWriter(path);
            textBox1.Text = textbufer;
            writer.Write(textbufer);
            MessageBox.Show("Текст успешно отредактирован!");
        }
    }
}
