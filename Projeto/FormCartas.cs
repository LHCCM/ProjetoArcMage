using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class CartasForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();

        public CartasForm()
        {
            InitializeComponent();

            refreshCards();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        //Adicionar cartas à lista
        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            CriarCartaForm form = new CriarCartaForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarCarta(form.NovaCarta);
            }
            refreshCards();
        }

        private void AdicionarCarta(Card carta)
        {
            container.Card.Add(carta);
            container.SaveChanges();
        }

        private void refreshCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.Card.ToArray<Card>());
        }

        private void buttonEditarCarta_Click(object sender, EventArgs e)
        {
            FormEditarCartas form = new FormEditarCartas();
            DialogResult result = form.ShowDialog();

            Close();
        }

        //dis works now :D
        private void buttonApagarCarta_Click(object sender, EventArgs e)
        {
            /*if ()
            {

            }
            else
            {*/

                if (listBoxCartas.SelectedIndex != -1)
                {
                    container.Card.Remove((Card)listBoxCartas.SelectedItem);
                    container.SaveChanges();
                }
            //}
            refreshCards();
        }

        //Mostrar informação do item selecionado
        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                labelNome.Text = cartaSelecionada.Name;
                labelAtaque.Text = Convert.ToString(cartaSelecionada.Atack);
                labelDefesa.Text = Convert.ToString(cartaSelecionada.Defense);
                labelCusto.Text = Convert.ToString(cartaSelecionada.Cost);
                labelLeal.Text = Convert.ToString(cartaSelecionada.Loyal);
                textBoxRegraCarta.Text = cartaSelecionada.Rules;
                labelFacao.Text = cartaSelecionada.Faction;
                labelTipo.Text = cartaSelecionada.Type;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoMsgBox = "Operação cancelada.";
            string tituloMsgBox = "Cancelado";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    try
                    {
                        using (BinaryReader reader = new BinaryReader(stream))
                        {
                            foreach (Card carta in container.Card)
                                {
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                            }
                                reader.Close();

                                textoMsgBox = "Sucesso";
                                tituloMsgBox = "Terminada";

                                refreshCards();
                        }
                    }
                    catch (InvalidCastException ex)
                    {
                        textoMsgBox = "Não foi possível converter os dados guadados no ficheiro. O ficheiro não contém uma versão correta das classes.";
                        tituloMsgBox = "Erro de Leitura";
                    }
                }
            }

            MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoMsgBox = "Operação cancelada.";
            string tituloMsgBox = "Cancelado";

            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writter = new StreamWriter(saveFileDialogExport.FileName, false))
                {
                    try
                    {
                        writter.WriteLine("# "+ container.Card.Count()+" cartas");
                        writter.WriteLine("");

                        foreach (Card carta in container.Card)
                        {
                            writter.WriteLine(String.Format("Nome: {0}", carta.Name));
                            writter.WriteLine(String.Format("Facao: {0}", carta.Faction));
                            writter.WriteLine(String.Format("Tipo: {0}", carta.Type));
                            writter.WriteLine(String.Format("Custo: {0}", carta.Cost));
                            writter.WriteLine(String.Format("Lealdade: {0}", carta.Loyal));
                            writter.WriteLine(String.Format("Regra: {0}", carta.Rules));
                            writter.WriteLine(String.Format("Ataque: {0}", carta.Atack));
                            writter.WriteLine(String.Format("Defesa: {0}", carta.Defense));
                            writter.WriteLine("");
                        }
                        writter.Flush();

                        textoMsgBox = "Exportação concluída com sucesso.";
                        tituloMsgBox = "Exportação Terminada";
                    }
                    catch (Exception ex)
                    {
                        textoMsgBox = "Não foi possível exportar os dados para o ficheiro selecionado. " + ex.Message;
                        tituloMsgBox = "Erro de Exportação";
                    }
                }
            }
            MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoMsgBox = "Operação cancelada.";
            string tituloMsgBox = "Cancelado";

            if (saveFileDialogGuardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialogGuardar.FileName, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        foreach (Card carta in container.Card)
                        {
                            writer.Write(String.Format("Nome: {0}", carta.Name));
                            writer.Write(String.Format("Facao: {0}", carta.Faction));
                            writer.Write(String.Format("Tipo: {0}", carta.Type));
                            writer.Write(String.Format("Custo: {0}", carta.Cost));
                            writer.Write(String.Format("Lealdade: {0}", carta.Loyal));
                            writer.Write(String.Format("Regra: {0}", carta.Rules));
                            writer.Write(String.Format("Ataque: {0}", carta.Atack));
                            writer.Write(String.Format("Defesa: {0}", carta.Defense));
                            writer.Write("");
                        }
                        writer.Flush();
                        writer.Close();

                        textoMsgBox = "Exportação concluída com sucesso.";
                        tituloMsgBox = "Exportação Terminada";
                    }
                }
            }

            MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }
    }
}
