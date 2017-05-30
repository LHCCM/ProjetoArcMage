using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class LoginForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();
        
        List<User> users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuArbitroForm refereemenu = new MenuArbitroForm();
            refereemenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminForm adminmenu = new MenuAdminForm();
            adminmenu.Show();
            this.Hide();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            users.GetType();
            string password = textBox2.Text;

            if (users.GetType() == typeof(Administrator))
            {
                ///if (validUser(textBox1.Text, textBox2.Text))
                //{
                    MenuAdminForm adminmenu = new MenuAdminForm();
                    adminmenu.Show();

                //}
            }
            else if (users.GetType() == typeof(Referee))
            {
                
            }
            else
            {
                labelErro.Show();
                textBox1.Text = "";
                textBox2.Text = "";

            }
                     
        }

    }
}
