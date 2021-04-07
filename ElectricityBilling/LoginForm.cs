using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace ElectricityBilling
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        { //Splash form coding
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
        }
        //It can calling the Splash Form
        private void formRun()
        {
            Application.Run(new SplashForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterPage M1 = new MasterPage();
           
                string a = "admin", b = "pass";
                string c = "Harsh", d = "password";

                if (txtUser.Text == a && txtPassword.Text == b||txtUser.Text==c&&txtPassword.Text==d)
                {
                    M1.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter correct Username and Password", "User Name or Password Incorrect!");
                }
                txtPassword.Clear();
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        //It call the splash form
       
    }
}