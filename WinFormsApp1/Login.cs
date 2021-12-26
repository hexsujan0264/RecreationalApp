using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password.");

                }
                else if (txtUser.Text == "admin" && txtPassword.Text == "admin")
                {
                    VisitorInfo fm1 = new VisitorInfo();
                    fm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the correct password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
