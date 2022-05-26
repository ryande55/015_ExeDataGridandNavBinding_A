using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && TxtPassword.Text == "12345")
            {
                new Form2().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("The User or password you entered is incorrect, try again");
                txtUsername.Clear();
                TxtPassword.Clear();
                txtUsername.Focus();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            TxtPassword.Clear();
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}