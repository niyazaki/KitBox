using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if (comboBoxPassword.Text == "password")
            {
                this.Hide();
                Template form = new Template();
                form.Show();
                form.Controls.Add(new AdminMenu());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
