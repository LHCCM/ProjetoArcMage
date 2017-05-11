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
    public partial class CartasForm : Form
    {

        Model1Container container = new Model1Container();

        public CartasForm()
        {
            InitializeComponent();

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            CriarCartaForm novaC = new CriarCartaForm();
            novaC.Show();
            refreshCards();
        }

        private void refreshCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.Card.ToArray<Card>());
        }
    }
}
