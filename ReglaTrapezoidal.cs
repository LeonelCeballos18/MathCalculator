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
using AngouriMath;

namespace ProyectoMatematicas2daParcial
{
    public partial class ReglaTrapezoidal : Form
    {

        int indice;
        public ReglaTrapezoidal()
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
                double valorSuperior = Convert.ToDouble(TxtBoxSuperior.Text);
                double valorInferior = Convert.ToDouble(TxtBoxInferior.Text);
                double n = Convert.ToDouble(TxTBoxSegmentos.Text);
                double valorX = valorInferior;
                int decimales;
                if (TxtBoxDecimales.Text == "")
                {
                    decimales = 9;
                }
                else
                {
                    decimales = int.Parse(TxtBoxDecimales.Text);
                }

                double valorSuperiorIntegrado = Math.Round(Convert.ToDouble(resolverEcuacion(funcionIntegrada.ToString(), TxtBoxSuperior.Text)), decimales);
                double valorInferiorIntegrado = Math.Round(Convert.ToDouble(resolverEcuacion(funcionIntegrada.ToString(), TxtBoxInferior.Text)), decimales);

                double integralDefinida = valorSuperiorIntegrado - valorInferiorIntegrado;

                double h = (valorSuperior - valorInferior) / n;
                double xValue = valorInferior;
                double fxValue = 0;
                double[] xTab = {xValue};
                double[] fxTab = { };
                double iValue;

                while (xValue <= valorSuperior)
                {
                    Array.Resize(ref xTab, xTab.Length + 1);
                    xValue = xValue + h;
                    xTab[xTab.Length-1] = xValue;
                    indice = DataGridxFx.Rows.Add();
                    DataGridxFx.Rows[indice].Cells[0].Value = xValue;
                    DataGridxFx.Rows[indice].Cells[1].Value = fxValue;
                    //double fxRes = (Math.Round(Convert.ToDouble(resolverEcuacion(funcion.ToString(), valorX.ToString())), decimales));

                    for (int i = 0; i < xTab.Length; i++)
                    {
                        Array.Resize(ref fxTab, fxTab.Length + 1);
                        fxValue = (Math.Round(Convert.ToDouble(resolverEcuacion(funcion.ToString(), xTab[i].ToString())), decimales));
                        fxTab[fxTab.Length - 1] = fxValue;
                    }

                }

                double midValuesPlus = 0;

                for(int i = 1; i<fxTab.Length-2; i++)
                {
                    midValuesPlus = midValuesPlus + fxTab[i];
                }

                iValue = Math.Round((valorSuperior - valorInferior) * ((fxTab[0] + (2 * midValuesPlus) + fxTab[fxTab.Length - 2]) / (2 * n)));

                double error = Math.Abs((integralDefinida - iValue) / integralDefinida)*100;

                LblResTrapezio.Text = iValue.ToString() + "u^2";
                LblError.Text = Math.Round(error, 2).ToString() + "%";
                LblResIntegral.Text = Convert.ToString(integralDefinida) + "u^2";

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

        private void ReglaTrapezoidal_Load(object sender, EventArgs e)
        {
            DataGridxFx.ColumnCount = 2;

            DataGridxFx.Columns[0].Name = "x";
            DataGridxFx.Columns[1].Name = "fx";
            DataGridxFx.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridxFx.ReadOnly = true;
        }
    }
}
