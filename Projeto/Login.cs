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
            string username = textBoxUser.Text;
            string pass = textBoxPass.Text;

            if (textBoxUser.Text.Length == 0 || textBoxPass.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var users = from utilizador in container.User.OfType<Referee>() where utilizador.Username == textBoxUser.Text && utilizador.Password == textBoxPass.Text select utilizador;

            //Referee arbitro = 

            //Se os dados existirem na base de dados o programa abre o menu
            if (//arbitro != null)
            {
                MenuArbitroForm menuarbitro = new MenuArbitroForm();
                menuarbitro.ShowDialog();
            }
                     
        }

    }
}
