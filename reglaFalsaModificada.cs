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

namespace ProyectoMatematicas2daParcial
{
    public partial class reglaFalsaModificada : Form
    {

        int indice;
        public reglaFalsaModificada()
        {
            InitializeComponent();
        }



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtBoxX.Text == "" || TxtBoxParo.Text == "" || TxtBoxFuncion.Text == "") 
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Expr variable = Expr.Variable("x");
                Expr func = Infix.ParseOrThrow(TxtBoxFuncion.Text);

                int iteracion = 0;
                int decimales;
                if (TxtBoxDecimales.Text == "")
                {
                    decimales = 9;
                }
                else
                {
                    decimales = int.Parse(TxtBoxDecimales.Text);
                }
                double tolerancia = double.Parse(TxtBoxParo.Text);
                string funcion = TxtBoxFuncion.Text;
                string funcDerivada = func.Differentiate(variable).ToString();
                double x = Math.Round(double.Parse(TxtBoxX.Text), decimales);
                double error = 100;
                double anteriorX = 0;

                while (tolerancia < error)
                {
                    double funcRes = Math.Round(Convert.ToDouble(resolverEcuacion(funcDerivada, Convert.ToString(x))), decimales);
                    double funcionRes = Math.Round(Convert.ToDouble(resolverEcuacion(funcion, Convert.ToString(x))), decimales);
                    x = Math.Round(obtenerx(x, funcRes, funcionRes), decimales);

                    if (iteracion > 1)
                    {
                        error = Math.Abs(calcularError(anteriorX, x));
                    }

                    anteriorX = x;
                    iteracion++;
                    indice = DataGridIteraciones.Rows.Add();
                    DataGridIteraciones.Rows[indice].Cells[0].Value = iteracion;
                    DataGridIteraciones.Rows[indice].Cells[1].Value = x;
                    DataGridIteraciones.Rows[indice].Cells[2].Value = error;
                }

                LblRes.Text = Convert.ToString(x);
                LblError.Text = Convert.ToString(error) + "%";
                LblNumItera.Text = Convert.ToString(iteracion);
            }
        }

        double calcularError(double anteriorXr, double xr)
        {
            double error = ((xr - anteriorXr) / xr) * 100;
            return Math.Round(error, 2);
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

        double obtenerx(double x, double funcRes, double funcionRes)
        {
            return x - (funcionRes / funcRes);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reglaFalsaModificada_Load(object sender, EventArgs e)
        {
            DataGridIteraciones.ColumnCount = 3;

            DataGridIteraciones.Columns[0].Name = "Iteración";
            DataGridIteraciones.Columns[1].Name = "xr";
            DataGridIteraciones.Columns[2].Name = "Error porcentual";
            DataGridIteraciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridIteraciones.ReadOnly = true;
        }

        private void TxtBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtBoxParo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtBoxDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }
    }
}
