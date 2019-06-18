using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
            this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
            this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
            this.lblEtiqueta.Click += new System.EventHandler(new Manejadora().Manejador2);
            this.txtCuadroTexto.Click += new System.EventHandler(new Manejadora().Manejador2);
            this.btnBoton.Click += new System.EventHandler(new Manejadora().Manejador2);
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del boton");
            
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del label");
            this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
        }

        private void txtCuadroTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del textbox");
        }
    }
}
