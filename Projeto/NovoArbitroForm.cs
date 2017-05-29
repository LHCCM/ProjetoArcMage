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
    public partial class NovoArbitroForm : Form
    {
        public Referee NovoArbitro { get; private set; }

        string destinationpath = @"C:\\Users\\User\\Source\\Repos\\ProjetoArcMage\\Avatares";
        
        DialogResult result;

        public NovoArbitroForm()
        {
            InitializeComponent();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxNickname.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxAvatar.Text.Length == 0)
            {
                result = MessageBox.Show("Não escolheu um avatar, continuar mesmo assim?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    NovoArbitroFunc();
                }
            }
            else
            {
                NovoArbitroFunc();
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

        private void NovoArbitroFunc()
        {
            string filename = Path.GetFileName(openFileDialog1.FileName);

            string nome = textBoxNome.Text.Trim();
            string nickname = textBoxNickname.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string avatar = Path.Combine(destinationpath, filename);

            NovoArbitro = new Referee()
            {
                Name = nome,
                Username = nickname,
                Password = password,
                Avatar = avatar,
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
