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
    public partial class EditarBaralhoForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();
        public EditarBaralhoForm()
        {
            InitializeComponent();
            refreshCartas();
        }
        private void refreshCartas()
        {
            listBoxTotalCartas.Items.Clear();
            listBoxTotalCartas.Items.AddRange(container.Card.ToArray<Card>());
            
        }
        private void refreshCartasBaralho()
        {
            AussiliaryVars var = new AussiliaryVars();
              
        }
        private void textBoxProcura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcura.Text;
            int index = listBoxTotalCartas.FindString(myString, -1);
            if (index != -1)
            {
                listBoxTotalCartas.SetSelected(index, true);
            }
            else
                MessageBox.Show("Baralho Inexistente.");
        }

        private void buttonAdicionarCartaBaralho_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

        }

        private void EditarBaralhoForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxCartasBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCartasBaralho.SelectedIndex != 0)
            {
                buttonRemoverCartaBaralho.Enabled = true;
            }
        }

        private void buttonRemoverCartaBaralho_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTotalCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTotalCartas.SelectedIndex != 0)
            {
                buttonAdicionarCartaBaralho.Enabled = true;
            }
        }
    }
}
