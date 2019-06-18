using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public class Manejadora
    {
        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en el manejador");
        }

        public void Manejador2(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en el manejador de instancia");
            if(sender is Button)
            {
                MessageBox.Show("Button");
            }
            else if (sender is TextBox)
            {
                MessageBox.Show("Textbox");
            }
            else if (sender is Label)
            {
                MessageBox.Show("Label");
            }
        }

        public static void Sumar(int a,int b)
        {
            MessageBox.Show((a + b).ToString());
        }

        public void Restar(int a, int b)
        {
            MessageBox.Show((a - b).ToString());
        }

        public void Multiplicar(int a,int b)
        {
            MessageBox.Show((a * b).ToString());
        }

        public void OtraSuma(MiDelegado d,int a,int b)
        {
            d.Invoke(a, b);
        }
    }
}
