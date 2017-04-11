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
    public partial class GerirJogadoresForm : Form
    {
        public GerirJogadoresForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirEquipasJogadoresForm gerirEJ = new GerirEquipasJogadoresForm();
            gerirEJ.Show();
            this.Close();
        }

        private void buttonNovoJogador_Click(object sender, EventArgs e)
        {
            NovoJogadorForm novoJ = new NovoJogadorForm();
            novoJ.Show();
        }

        private void buttonApagarJogador_Click(object sender, EventArgs e)
        {
            //funçao apagar jogador selecionado na listboxJogdores
        }

        private void buttonEditarJogador_Click(object sender, EventArgs e)
        {
            EditarJogadorForm editJ = new EditarJogadorForm();
            editJ.Show();
        }
    }
}
