using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form



    {
        string operador = "";
        double num1 = 0, num2 = 0;
        bool nuevoNumero = true; // para que pueda usar varios numeros seguidos
        double memoria = 0; // almacena el valor en memoria
        double numeroActual = 0; // almacena el valor actual en la pantalla
        public Form1()
        {
            InitializeComponent();

        }

        // Botón M+ (Suma a la memoria)
        private void btnMmas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out numeroActual))
            {
                memoria += numeroActual;
                MessageBox.Show($"Memoria: {memoria}");
            }
        }

        // Botón M- (Resta de la memoria)
        private void btnMmenos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out numeroActual))
            {
                memoria -= numeroActual;
                MessageBox.Show($"Memoria: {memoria}");
            }
        }

        // Botón MC (Borrar memoria)
        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            MessageBox.Show("Memoria borrada.");
        }

        // Botón MR (Mostrar memoria)
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoria.ToString();
        }


        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;   // detecta cual boton fue presionado

            if (txtDisplay.Text == "0" || nuevoNumero)
            {
                txtDisplay.Text = boton.Text;
                nuevoNumero = false; // resetea la bandera
            }

            else
                txtDisplay.Text += boton.Text;  // agrega el numero al final
        }

        // Botones de operaciones (+, -, *, /)
        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operador = boton.Text;
            nuevoNumero = true; // activa la bandera para un nuevo numero
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
        }

        // Boton Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtDisplay.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        MessageBox.Show("No se puede dividir entre 0");
                    break;
                case "^": resultado = Math.Pow(num1, num2); break; // <-- para representar el exponente
            }


            txtDisplay.Text = resultado.ToString();
        }

        // Boton CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        // Boton BA
        private void btnBA_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // Exponente (num1 ^ num2)
        private void btnExp_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
        }

        // Raíz cuadrada
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            double resultado = Math.Sqrt(num1);
            txtDisplay.Text = resultado.ToString();
        }

        // Pi (π)
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
        }

        // Logaritmo (base 10)
        private void btnLog_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            if (num1 > 0)
            {
                double resultado = Math.Log10(num1);
                txtDisplay.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("El logaritmo solo está definido para números positivos.");
            }
        }

        // porcentaje
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = (valor / 100).ToString();
        }

        // cuadrado de un numero
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Pow(valor, 2).ToString();
        }

        // seno
        private void btnSen_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(valor).ToString();
        }

        // coseno
        private void btnCos_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(valor).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}