using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MS
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuLogout.Enabled = mnuWork.Enabled = mnuFind.Enabled = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            //   frmLogin f = new frmLogin();
            GUI_Login l = new GUI_Login();
            l.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }
    }
}
