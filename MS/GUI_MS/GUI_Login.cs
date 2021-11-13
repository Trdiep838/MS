using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MS;
namespace GUI_MS
{
    public partial class GUI_Login : Form
    {
        BUS_Login buslog = new BUS_Login();
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (buslog.getUser(txtUsername.Text,txtPass.Text) == false)
            {
                mySave.KT = !mySave.KT;
                MessageBox.Show("Login Successful", "Attention");
                Close();
            }
            else MessageBox.Show("UserName or Password incorect", "Attention");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
