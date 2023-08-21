using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class Login : Form
    {
        IAccountRepository _accountRepository = new AccountRepository();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            var check = _accountRepository.GetAccounts().Where(x => x.Username == username && x.Password == password).ToList();

            if (check.Any()) 
            {
                var checkRole = _accountRepository.GetAccountByName(username);

                if (checkRole.Role.Equals(1))
                {
                    MessageBox.Show("Not Implement");
                } if (checkRole.Role.Equals(2))
                {
                    this.Hide();
                    StaffForm staff = new StaffForm();
                    staff.Show();
                } else
                {
                    MessageBox.Show("You are not allowed to the application");
                }
                
            } 
        }
    }
}
