using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.src;
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
        !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                string[] info = new string[3];
                info[0] = textBox1.Text;
                info[1] = textBox2.Text;
                info[2] = "0";
                if (!Functional.isUserExists(info))
                {
                    Functional.AddUser(info);
                    MessageBox.Show("Success!");
                }
                else
                {
                    label3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Enter login and password");
            }
        }
    }
}
