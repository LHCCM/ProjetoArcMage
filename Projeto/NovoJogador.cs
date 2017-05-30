using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto
{
    public partial class NovoJogadorForm : Form
    {
        public Player NovoJogador { get; private set; }

        string destinationpath = Path.GetDirectoryName(Application.ExecutablePath);

        DialogResult result;

        public NovoJogadorForm()
        {
            InitializeComponent();
        }

        private void buttonCancelarNovoJogador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmNovoJogador_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxNick.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxAvatar.Text.Length == 0)
            {
                result = MessageBox.Show("Não escolheu um avatar, continuar mesmo assim?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    NovoJogadorFunc();
                }
            }
            else
            {
                NovoJogadorFunc();
            }
        }

        private void buttonEscolherAvatar_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.png, *.jpg) | *.png; *.jpg";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                this.textBoxAvatar.Text = openFileDialog1.FileName;
                Image imagem = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = new Bitmap(imagem, new Size(153, 132));
            }

            if (openFileDialog1.FileName != null)
            {
                //acessede apenas ao nome do ficheiro
                string filename = Path.GetFileName(openFileDialog1.FileName);

                //copia o ficheiro para uma pasta e faz overwrite se o ficheiro já exitir
                File.Copy(openFileDialog1.FileName, Path.Combine(destinationpath, filename), true);
            }
        }

        private void NovoJogadorFunc()
        {
            string filename = Path.GetFileName(openFileDialog1.FileName);

            string nome = textBoxNome.Text.Trim();
            string nick = textBoxNick.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string avatar = Path.Combine(destinationpath, filename);

            NovoJogador = new Player()
            {
                Name = nome,
                Nickname = nick,
                Email = email,

                Age = (int)numericUpDownIdade.Value,
                Avatar = avatar,

            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
