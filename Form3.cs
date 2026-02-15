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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Text = $"Hello, {Functional.name}";
            switch (Functional.level)
            {
                case "0":
                    break;
                case "1":
                    break;
                case "2":
                    linkLabel1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    button1.Visible = true;
                    break;

                default:
                    linkLabel1.Visible = false; break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Functional.GetUsers());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            
            for(int i = 0; i < Functional.BaseLength(); i++)
            {
                if (login.Equals(Functional.GetInfo(i)[0]))
                {
                    Functional.GetInfo(i)[2] = textBox2.Text;
                    Functional.ExportToJson();
                    MessageBox.Show("Success!");
                    break;
                }
            }
            
        }
    }
}
