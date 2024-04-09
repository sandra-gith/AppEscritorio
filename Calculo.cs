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
    public partial class Calculo : Form
    {
        Menu ventanaMenu;

        public Calculo()
        {
            InitializeComponent();
        }
        public void referenciarVentaMenu(Menu ventanaMenu)
        {
           this.ventanaMenu = ventanaMenu;
        }

        public void atraparDato(string dato)
        {
            mostrarDato.Text = dato;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaMenu.Visible = true;
        }
        

        private void Calculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
