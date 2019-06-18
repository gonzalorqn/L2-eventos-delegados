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
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Inicializar);
        }
        
        private void Inicializar(object sender, EventArgs e)
        {
            this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
        }

        private void MiManejador(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            MessageBox.Show(c.Name);
            if(c.Name == "btnBoton1")
            {
                this.btnBoton1.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton2.Click += new System.EventHandler(this.MiManejador);
            }
            else if (c.Name == "btnBoton2")
            {
                this.btnBoton2.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton3.Click += new System.EventHandler(this.MiManejador);
            }
            else if (c.Name == "btnBoton3")
            {
                this.btnBoton3.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado d = new MiDelegado(Manejadora.Sumar);
            d.Invoke(3, 2);
            d(3, 2);
            MiDelegado dr = new MiDelegado((new Manejadora()).Restar);
            dr(3, 2);
            MiDelegado delegadoCombinado = (MiDelegado)MiDelegado.Combine(d, dr);
            delegadoCombinado.Invoke(4, 2);
            MessageBox.Show(dr.Method.ToString() + " - " + dr.Target.ToString());
            foreach (MiDelegado item in delegadoCombinado.GetInvocationList())
            {
                MessageBox.Show(item.Method.ToString());
            }
            MiDelegado d4 = (MiDelegado)MiDelegado.Combine(delegadoCombinado,new MiDelegado((new Manejadora()).Multiplicar));
            d4(3, 4);
            (new Manejadora()).OtraSuma(d, 3, 2);
        }
    }
}
