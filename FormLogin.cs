using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool IsValidCredentials(string username, string password)
        {
            
            return username == "admin" && password == "25112005";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPass.Text;

            if (IsValidCredentials(username, password))
            {
                // Open the main form
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
                MessageBox.Show("You have successfully logged in.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbYourName_Click(object sender, EventArgs e)
        {

        }
    }
}
