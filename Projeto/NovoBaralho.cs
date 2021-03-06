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
    public partial class NovoBaralho : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        public NovoBaralho()
        {
            InitializeComponent();
        }


        private void buttonNovoBaralhoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNovoBaralhoConfimar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeNovoBaralho.Text.Trim();
            Array baralhos = container.Deck.ToArray<Deck>();
            Deck baralho = new Deck()
            {
                Name = nome
            };
            /*int NumeroDecks = 0;
            int Check = 0;
            do {
                if(baralhos[NumeroDecks] == nome)
                {
                    Check = 1;
                }
                NumeroDecks++;
            } while (NumeroDecks <= container.Deck.Count<Deck>());
            if(Check == 0)
            {*/
                container.Deck.Add(baralho);
                container.SaveChanges();
            //}            
            this.Close();
        }
    }
}
