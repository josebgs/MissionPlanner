using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextbox.Text == "admin" && passwordTextbox.Text == "admin")
            {

            }
        }
    }
}
