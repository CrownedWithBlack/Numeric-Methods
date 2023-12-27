using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Metodo_de_las_secantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "X\u2076";
            label6.Text = "X\u2075";
            label7.Text = "X\u2074";
            label8.Text = "X\u00B3";
            label9.Text = "X\u00B2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                calcular();

            }catch(System.FormatException errorFormato) 
            {
                MessageBox.Show("Ingrese un valor númerico válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular()
        {
            txtSalida.Text = null;
            double intervaloMenor = double.Parse(txtIntervaloMenor.Text.Trim());
            double intervaloMayor = double.Parse(txtIntervaloMayor.Text.Trim());
            int numDecimales = Int32.Parse(txtNumDecimales.Text.Trim());
            double porcentajeError = double.Parse(txtPorcentajeError.Text.Trim());
            string numDecString = "F" +numDecimales.ToString();
            double cantX6 = double.Parse(txtx6.Text.Trim());
            double cantX5 = double.Parse(txtx5.Text.Trim());
            double cantX4 = double.Parse(txtx4.Text.Trim());
            double cantX3 = double.Parse(txtx3.Text.Trim());
            double cantX2 = double.Parse(txtx2.Text.Trim());
            double cantX = double.Parse(txtx.Text.Trim());
            double cantCons = double.Parse(txtConstante.Text.Trim());

            //funcion del intervalo menor
            double fXim1 = Math.Round(cantX6 * Math.Pow(intervaloMenor, 6) + cantX5 * Math.Pow(intervaloMenor, 5) + cantX4 * Math.Pow(intervaloMenor, 4) + cantX3 * Math.Pow(intervaloMenor, 3) + cantX2 * Math.Pow(intervaloMenor, 2) + cantX * intervaloMenor + cantCons
                , numDecimales, MidpointRounding.AwayFromZero) ;
            //funcion del intervalo mayor
            double fXi = Math.Round(cantX6 * Math.Pow(intervaloMayor, 6) + cantX5 * Math.Pow(intervaloMayor, 5) + cantX4 * Math.Pow(intervaloMayor, 4) + cantX3 * Math.Pow(intervaloMayor, 3) + cantX2 * Math.Pow(intervaloMayor, 2) + cantX * intervaloMayor + cantCons
                , numDecimales, MidpointRounding.AwayFromZero);

            //primera aproximacion
            double XiM1 = Math.Round( intervaloMayor -((fXi * (intervaloMenor - intervaloMayor))/(fXim1-fXi))
                ,numDecimales,MidpointRounding.AwayFromZero);

            bool continuar=true;
            if ((fXim1-fXi)==0)
            {
                MessageBox.Show("El valor encontrado es cero, los intervalos dados son las raices buscadas","Error, división por cero",MessageBoxButtons.OK,MessageBoxIcon.Error);
                continuar = false;
            }
            else
            {
            //primera salida de datos
            txtSalida.AppendText("Aproximación 1 = "+XiM1+Environment.NewLine);
            txtSalida.AppendText("El valor de fXim1 es: "+fXim1.ToString()+Environment.NewLine);
            txtSalida.AppendText("El valor de fXi es: "+fXi.ToString()+Environment.NewLine);
            txtSalida.AppendText("El valor de XiM1 es: " + XiM1.ToString() + Environment.NewLine + Environment.NewLine);
            }

            double error = 100;
            int cont = 2;
            while (error > porcentajeError)
            {
                if (!continuar)
                    break;

                //comienzan las iteraciones, aproximacion 2++
                intervaloMenor = intervaloMayor;
                intervaloMayor = XiM1;
                fXim1 = Math.Round(cantX6 * Math.Pow(intervaloMenor, 6) + cantX5 * Math.Pow(intervaloMenor, 5) + cantX4 * Math.Pow(intervaloMenor, 4) + cantX3 * Math.Pow(intervaloMenor, 3) + cantX2 * Math.Pow(intervaloMenor, 2) + cantX * intervaloMenor + cantCons
                    , numDecimales, MidpointRounding.AwayFromZero);
                fXi = Math.Round(cantX6 * Math.Pow(intervaloMayor, 6) + cantX5 * Math.Pow(intervaloMayor, 5) + cantX4 * Math.Pow(intervaloMayor, 4) + cantX3 * Math.Pow(intervaloMayor, 3) + cantX2 * Math.Pow(intervaloMayor, 2) + cantX * intervaloMayor + cantCons
                    , numDecimales, MidpointRounding.AwayFromZero);
                XiM1 = Math.Round(intervaloMayor - ((fXi * (intervaloMenor - intervaloMayor)) / (fXim1 - fXi))
                    , numDecimales, MidpointRounding.AwayFromZero);
                error = Math.Abs(((XiM1 - intervaloMayor) / XiM1) * 100);

                //salida de datos
                txtSalida.AppendText("Aproximación " + cont +" = "+XiM1+ Environment.NewLine);
                txtSalida.AppendText("El valor de fXim1 es: " + fXim1.ToString() + Environment.NewLine);
                txtSalida.AppendText("El valor de fXi es: " + fXi.ToString() + Environment.NewLine);
                txtSalida.AppendText("El valor de XiM1 es: " + XiM1.ToString() + Environment.NewLine);
                txtSalida.AppendText("El porcentaje de error seleccionado es: " + porcentajeError.ToString() + Environment.NewLine);
                txtSalida.AppendText("El porcentaje de error actual es: " + error.ToString(numDecString) + Environment.NewLine + Environment.NewLine);
                cont++;
            }
        }

        private void btnLimpiarSalida_Click(object sender, EventArgs e)
        {
            txtSalida.Text = null;
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtSalida.Text = null;
            txtIntervaloMenor.Text = "0";
            txtIntervaloMayor.Text = "0";
            txtNumDecimales.Text = "0";
            txtPorcentajeError.Text = "0";
            txtx6.Text = "0";
            txtx5.Text = "0";
            txtx4.Text = "0";
            txtx3.Text = "0";
            txtx3.Text = "0";
            txtx2.Text = "0";
            txtx.Text = "0";
            txtConstante.Text = "0";
        }

        private void txtIntervaloMenor_Click(object sender, EventArgs e)
        {
            txtIntervaloMenor.SelectAll();
        }

        private void txtIntervaloMenor_Enter(object sender, EventArgs e)
        {
            txtIntervaloMenor.SelectAll();
        }

        private void txtIntervaloMayor_Click(object sender, EventArgs e)
        {
            txtIntervaloMayor.SelectAll();
        }

        private void txtIntervaloMayor_Enter(object sender, EventArgs e)
        {
            txtIntervaloMayor.SelectAll();
        }

        private void txtNumDecimales_Click(object sender, EventArgs e)
        {
            txtNumDecimales.SelectAll();
        }

        private void txtNumDecimales_Enter(object sender, EventArgs e)
        {
            txtNumDecimales.SelectAll();

        }

        private void txtPorcentajeError_Click(object sender, EventArgs e)
        {
            txtPorcentajeError.SelectAll();
        }

        private void txtPorcentajeError_Enter(object sender, EventArgs e)
        {
            txtPorcentajeError.SelectAll();
        }

        private void txtx6_Click(object sender, EventArgs e)
        {
            txtx6.SelectAll();
        }

        private void txtx6_Enter(object sender, EventArgs e)
        {
            txtx6.SelectAll();
        }

        private void txtx5_Click(object sender, EventArgs e)
        {
            txtx5.SelectAll();
        }

        private void txtx5_Enter(object sender, EventArgs e)
        {
            txtx5.SelectAll();
        }

        private void txtx4_Click(object sender, EventArgs e)
        {
            txtx4.SelectAll();
        }

        private void txtx4_Enter(object sender, EventArgs e)
        {
            txtx4.SelectAll();
        }

        private void txtx3_Click(object sender, EventArgs e)
        {
            txtx3.SelectAll();
        }

        private void txtx3_Enter(object sender, EventArgs e)
        {
            txtx3.SelectAll();
        }

        private void txtx2_Click(object sender, EventArgs e)
        {
            txtx2.SelectAll();
        }

        private void txtx2_Enter(object sender, EventArgs e)
        {
            txtx2.SelectAll();
        }

        private void txtx_Click(object sender, EventArgs e)
        {
            txtx.SelectAll();
        }

        private void txtx_Enter(object sender, EventArgs e)
        {
            txtx.SelectAll();
        }

        private void txtConstante_Click(object sender, EventArgs e)
        {
            txtConstante.SelectAll();
        }

        private void txtConstante_Enter(object sender, EventArgs e)
        {
            txtConstante.SelectAll();
        }
    }
}
