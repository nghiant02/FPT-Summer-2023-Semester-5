using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_FA22_TrialTest_Nghia
{
    public partial class Login : Form
    {
        public ElectricStoreDBContext _context = new ElectricStoreDBContext();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                UsersServices _usersServices = new UsersServices(_context);
                string us = txtUsername.Text;
                string pas = txtPassword.Text;

                Users ac = _usersServices.LoginAccount(us, pas);
                if (ac.UserRole == 1)
                {
                    this.Hide();
                    Form form = new Management();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
