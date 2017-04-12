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
    public partial class NovoBaralho : Form
    {
        public NovoBaralho()
        {
            InitializeComponent();
        }

        private void buttonNovoBaralhoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
