using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Menu : Form
    {
        Calculo ventanaCalculo;

        public Menu()

        {
            InitializeComponent();
            ventanaCalculo = new Calculo();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaCalculo.referenciarVentaMenu(this);

            string nombreTextBox = ingresarDato.Text;
            ventanaCalculo.atraparDato(nombreTextBox);

            ventanaCalculo.Visible = true;

        }

    }
}
