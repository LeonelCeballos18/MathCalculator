using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSScriptControl;

namespace ProyectoMatematicas2daParcial
{
    public partial class reglaFalsa : Form
    {
        int indice;
        public reglaFalsa()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtBoxXu.Text == "" || TxtBoxXl.Text == "" || TxtBoxParo.Text == "" || TxtBoxFuncion.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
                double xl = Math.Round(double.Parse(TxtBoxXl.Text), decimales);
                double xu = Math.Round(double.Parse(TxtBoxXu.Text), decimales);
                double fxl = Math.Round(Convert.ToDouble(resolverEcuacion(funcion, Convert.ToString(xl))), decimales);
                double fxu = Math.Round(Convert.ToDouble(resolverEcuacion(funcion, Convert.ToString(xu))), decimales);
                double error = 100;
                double anteriorXr = 0;
                double xr = 0;


                while (tolerancia < error)
                {
                    xr = Math.Round(obtenerxr(xl, xu, fxl, fxu), decimales);
                    double fxr = Math.Round(Convert.ToDouble(resolverEcuacion(funcion, Convert.ToString(xr))), decimales);

                    if (iteracion > 1)
                    {
                        error = Math.Abs(calcularError(anteriorXr, xr));
                    }

                    if (fxr > 0)
                    {
                        xl = xr;
                        fxl = fxr;
                    }
                    else if (fxr < 0)
                    {
                        xu = xr;
                        fxu = fxr;
                    }

                    anteriorXr = xr;
                    iteracion++;
                }

                LblRes.Text = Convert.ToString(xr);
                LblError.Text = Convert.ToString(error) + "%";
                LblNumItera.Text = Convert.ToString(iteracion);
                indice = DataGridIteraciones.Rows.Add();
                DataGridIteraciones.Rows[indice].Cells[0].Value = iteracion;
                DataGridIteraciones.Rows[indice].Cells[1].Value = xr;
                DataGridIteraciones.Rows[indice].Cells[2].Value = error;
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

        double obtenerxr(double xl, double xu, double fxl, double fxu)
        {
            return xu - (fxu * (xl - xu) / (fxl - fxu));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reglaFalsa_Load(object sender, EventArgs e)
        {
            DataGridIteraciones.ColumnCount = 3;

            DataGridIteraciones.Columns[0].Name = "Iteración";
            DataGridIteraciones.Columns[1].Name = "xr";
            DataGridIteraciones.Columns[2].Name = "Error porcentual";
            DataGridIteraciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridIteraciones.ReadOnly = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBoxDecimales.Text = "";
            TxtBoxParo.Text = "";
            TxtBoxFuncion.Text = "";
            TxtBoxXl.Text = "";
            TxtBoxXu.Text = "";
            LblRes.Text = "0";
            LblNumItera.Text = "0";
            LblError.Text = "0%";
        }

        private void DataGridIteraciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
