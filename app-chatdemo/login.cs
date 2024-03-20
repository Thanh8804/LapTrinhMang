using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chatdemo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgetpass forgetpass = new forgetpass();
            forgetpass.Show();
        }
    }
}
