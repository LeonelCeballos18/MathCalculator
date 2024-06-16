using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatematicas2daParcial
{
    internal class Validaciones
    {
        public static void Numeros(KeyPressEventArgs V)
        {
            //Puede pasar solo numeros
            if (V.KeyChar >= 45 && V.KeyChar <= 46 || (V.KeyChar >= 48 && V.KeyChar <= 57))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar)) // No admite espacios
            {
                V.Handled = true;
            }
            else if (Char.IsControl(V.KeyChar)) //Admite la tecla retroceso (borrar)
            {
                V.Handled = false;

            }
            else //Cualquier otro caractter será invalido 
            {
                V.Handled = true;
                MessageBox.Show("Favor de ingresar solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
