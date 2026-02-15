using WinFormsApp1.src;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Functional.ImportJson();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 register = new Form2();
            this.Visible = false;
            await register.ShowAsync();
            this.Visible = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                string[] info = new string[2];
                info[0] = textBox1.Text;
                info[1] = textBox2.Text;
                for (int i = 0; i < Functional.BaseLength(); i++)
                {
                    if (Functional.GetInfo(i)[0].Equals(info[0]) && Functional.GetInfo(i)[1].Equals(info[1]))
                    {
                        Functional.name = Functional.GetInfo(i)[0];
                        Functional.level = Functional.GetInfo(i)[2];
                        MainWindow Maen = new MainWindow();
                        Functional.ImportJson();
                        Maen.Show();
                        this.Visible = false;
                        return;
                    }
                }
                MessageBox.Show("No accounts with this login.");
            }
            else
            {
                MessageBox.Show("Enter login and password.");
            }
        }
    }
}
