﻿using System;
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
    public partial class EditarTorneioForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();

        public EditarTorneioForm()
        {
            InitializeComponent();

            refresTorneios();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            TorneioForm form = new TorneioForm();
            form.Show();

            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedItem == null)
            {
                MessageBox.Show("Nenhum torneio selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            if (listBoxTorneio.SelectedItem.GetType() == typeof(TeamTournament))
                {
                    TeamTournament team = (TeamTournament)listBoxTorneio.SelectedItem;

                    if (team != null)
                    {

                        DialogResult result = MessageBox.Show("Tem a certeza que deseja guardar as alterações ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            if (textBoxDesc.Text == null || textBoxNome.Text == null)
                            {
                                MessageBox.Show("Preencha as caixas de texto, Por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string nome = textBoxNome.Text.Trim();
                                string desc = textBoxDesc.Text.Trim();
                                DateTime date = dateTimePicker.Value;

                                team.Nome = nome;
                                team.Data = date;
                                team.Desc = desc;

                                container.SaveChanges();
                            }
                        }
                    }
                    
                }
                else //if(listBoxTorneio.SelectedItem.GetType() == typeof(StandardTournament))
                {
                    StandardTournament standard = (StandardTournament)listBoxTorneio.SelectedItem;

                    if (standard != null)
                    {
                        DialogResult result = MessageBox.Show("Tem a certeza que deseja guardar as alterações ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                        if (result == DialogResult.Yes)
                        {
                            if (textBoxDesc.Text == null || textBoxNome.Text == null)
                            {
                                MessageBox.Show("Preencha as caixas de texto, Por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string nome = textBoxNome.Text.Trim();
                                string desc = textBoxDesc.Text.Trim();
                                DateTime date = dateTimePicker.Value;

                                standard.Nome = nome;
                                standard.Data = date;
                                standard.Desc = desc;

                                container.SaveChanges();
                            }
                        }
                    }
                }

            }
        }

        private void refresTorneios()
        {
            listBoxTorneio.Items.Clear();
            listBoxTorneio.Items.AddRange(container.Tournament.OfType<StandardTournament>().ToArray());
            listBoxTorneio.Items.AddRange(container.Tournament.OfType<TeamTournament>().ToArray());
        }

        private void listBoxTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxTorneio.SelectedItem.GetType() == typeof(TeamTournament))
            {
                TeamTournament team = (TeamTournament)listBoxTorneio.SelectedItem;

                if (team != null)
                {

                    textBoxNome.Text = team.Nome;
                    textBoxDesc.Text = team.Desc;
                    dateTimePicker.Value = team.Data;
                }
            }
            else
            {
                StandardTournament solo = (StandardTournament)listBoxTorneio.SelectedItem;
                if (solo != null)
                {
                    textBoxNome.Text = solo.Nome;
                    textBoxDesc.Text = solo.Desc;
                    dateTimePicker.Value = solo.Data;
                }

            }
        }
    }
}
