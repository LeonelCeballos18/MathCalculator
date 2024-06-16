using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using AngouriMath;

namespace ProyectoMatematicas2daParcial
{
    public partial class secante : Form
    {
        public secante()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            if (TxtBoxSuperior.Text == "" || TxtBoxInferior.Text == "" || TxtBoxFuncion.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Entity funcion = TxtBoxFuncion.Text;
                Entity funcionIntegrada = funcion.Integrate("x");
                int decimales;
                if (TxtBoxDecimales.Text == "")
                {
                    decimales = 9;
                }
                else
                {
                    decimales = int.Parse(TxtBoxDecimales.Text);
                }

                double valorSuperior = Math.Round(Convert.ToDouble(resolverEcuacion(funcionIntegrada.ToString(), TxtBoxSuperior.Text)), decimales);
                double valorInferior = Math.Round(Convert.ToDouble(resolverEcuacion(funcionIntegrada.ToString(), TxtBoxInferior.Text)), decimales);

                double integralDefinida = valorSuperior - valorInferior;

                LblRes.Text = Convert.ToString(integralDefinida);

            }
        }

        string resolverEcuacion(string funcion, string valor)
        {
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";

            string expresion;

            if ((funcion.Contains("e")) && (funcion.Contains("x")))
            {
                string remplazarE = funcion.Replace("e", "2.7182818284");
                expresion = remplazarE.Replace("x", Convert.ToString(valor));
            }
            else
            {
                expresion = funcion.Replace("x", Convert.ToString(valor));
            }

            object fxr = sc.Eval(expresion);

            return fxr.ToString();
        }

        private void secante_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtBoxSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBoxSuperior.Text = "";
            TxtBoxInferior.Text = "";
            TxtBoxFuncion.Text = "";
            TxtBoxDecimales.Text = "";
            LblRes.Text = "0";
        }

        private void TxtBoxInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtBoxDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }
    }
}
