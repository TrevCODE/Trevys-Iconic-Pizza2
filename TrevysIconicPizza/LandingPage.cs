using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevysIconicPizza
{
    public partial class LandingPage : Form
    {
        private  LoginPage loginPage;
        private CreateAccountPage createAccountPage;
        public LandingPage()
        {
            InitializeComponent();
            
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            loginPage = new LoginPage();
            loginPage.Show();
            //this.Visible = false; //Does not work well
            
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            createAccountPage = new CreateAccountPage();
            createAccountPage.Show();
           // this.Visible = false; // Does not work well
        }
    }
}
