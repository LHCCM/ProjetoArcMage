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

    //public Player Jogador { get; private set; }
    //public Team NovaEquipa { get; private set; }

    public partial class NovaEquipaForm : Form
    {
        public NovaEquipaForm()
        {
            InitializeComponent();

            //refreshJogadores();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome da equipa, por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string nome = textBoxNome.Text.Trim();


                /*NovaEquipa = new Team()
                {
                    Name = nome,
                    Avatar = "null",

                };
                DialogResult = DialogResult.OK;
                Close();
            }*/
            }

            /* private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
             {
                 Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItems;
             }

             private void refreshJogadores()
             {
                 listBoxJogadores.Items.Clear();
                 listBoxJogadores.Items.AddRange(container.Player.ToArray<Player>());
             }*/

        }
    }
}
