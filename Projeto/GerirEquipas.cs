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
    public partial class GerirEquipasForm : Form
    {
        public GerirEquipasForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirEquipasJogadoresForm gerirEJ = new GerirEquipasJogadoresForm();
            gerirEJ.Show();
            this.Close(); ;
        }

        private void buttonNovaEquipa_Click(object sender, EventArgs e)
        {
            NovaEquipaForm novaE = new NovaEquipaForm();
            novaE.Show();
        }

        private void buttonApagarEquipa_Click(object sender, EventArgs e)
        {
            //funçao apagar equipa selecionada na listboxEquipas
        }

        private void buttonAdicionarJogador_Click(object sender, EventArgs e)
        {
            //função adicionar jogador existente selecionado a equipa selecionada
        }

        private void buttonRemoverJogador_Click(object sender, EventArgs e)
        {
            //função retirar jogador selecionado da equipa
        }
    }
}
