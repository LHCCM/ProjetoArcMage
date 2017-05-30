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
    public partial class NovoTorneioForm : Form
    {
        public StandardTournament NovoTorneioStandard { get; private set; }
        public TeamTournament NovoTorneioTeam { get; private set; }

        public NovoTorneioForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriarTorneio_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxDesc.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonStandard.Checked == true)
            {
                string nome = textBoxNome.Text.Trim();
                string desc = textBoxDesc.Text.Trim(); 
                DateTime date = dateTimePicker.Value;

                NovoTorneioStandard = new StandardTournament()
                {
                    Nome = nome,
                    Data = date,
                    Desc = desc,
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (radioButtonEquipas.Checked == true)
            {
                string nome = textBoxNome.Text.Trim();
                string desc = textBoxDesc.Text.Trim();
                DateTime date = dateTimePicker.Value;

                NovoTorneioTeam = new TeamTournament()
                {
                    Nome = nome,
                    Data = date,
                    Desc = desc,
                };
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de torneio selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
