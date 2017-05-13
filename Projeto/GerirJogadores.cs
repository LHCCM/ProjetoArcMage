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
    public partial class GerirJogadoresForm : Form
    {
        Model1Container container = new Model1Container();

        public GerirJogadoresForm()
        {
            InitializeComponent();

            refreshJogadores();            
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirEquipasJogadoresForm gerirEJ = new GerirEquipasJogadoresForm();
            gerirEJ.Show();
            this.Close();
        }

        //Adicionar jogador
        private void buttonNovoJogador_Click(object sender, EventArgs e)
        {
            NovoJogadorForm form = new NovoJogadorForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarJogador(form.NovoJogador);
            }
            refreshJogadores();
        }

        private void AdicionarJogador(Player jogador)
        {
            container.Player.Add(jogador);
            container.SaveChanges();
        }

        private void refreshJogadores()
        {
            listBoxJogadores.Items.Clear();
            listBoxJogadores.Items.AddRange(container.Player.ToArray<Player>());
        }

        private void buttonApagarJogador_Click(object sender, EventArgs e)
        {
            //WIP//
            //funçao apagar jogador selecionado na listboxJogdores
        }

        private void buttonEditarJogador_Click(object sender, EventArgs e)
        {
            EditarJogadorForm editJ = new EditarJogadorForm();
            editJ.Show();
        }

        //Mostrar info do jogador selecionado
        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

            if (jogadorSelecionado != null)
            {
                labelID.Text = Convert.ToString(jogadorSelecionado.Id);
                labelNome.Text = jogadorSelecionado.Name;
                labelEmail.Text = jogadorSelecionado.Email;
                labelNick.Text = jogadorSelecionado.Nickname;
                labelIdade.Text = Convert.ToString(jogadorSelecionado.Age);
            }
            refreshJogadores();
        }
    }
}
