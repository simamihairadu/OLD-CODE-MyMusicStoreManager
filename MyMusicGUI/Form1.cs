using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMusicPersistence;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            EmployeeAccount account;
            using(var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                try 
                {
                    account = unitOfWork.EmployeeAccounts.GetEmployeeByUsername(username);
                    if(account.Password == password)
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        MainPanel mainPanel= new MainPanel();
                        mainPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bad username or password");
                    }
                }
                catch
                {
                    MessageBox.Show("Bad username or password");
                }
            }
        }
    }
}
