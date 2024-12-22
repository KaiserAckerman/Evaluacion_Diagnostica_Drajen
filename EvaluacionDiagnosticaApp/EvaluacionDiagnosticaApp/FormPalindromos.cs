using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionDiagnosticaApp
{
    public partial class FormPalindromos : Form
    {
        public FormPalindromos()
        {
            InitializeComponent();
        }

        // Método general que se encarga de verificar si una palabra es palíndromo
        private bool EsPalindromo(string palabra)
        {
            string minuscula = palabra.ToLower();
            char[] caracteres = minuscula.ToCharArray();
            Array.Reverse(caracteres);
            string invertida = new string(caracteres);
            return minuscula == invertida;
        }
        // Valida el texto ingresado (comprueba si está vacío y si es palíndromo), muestra el resultado en un MessageBox y limpia el campo.
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string palabraIngresada = txtPalabra.Text.Trim();
            if (string.IsNullOrWhiteSpace(palabraIngresada))
            {
                MessageBox.Show("Por favor, ingresa una palabra.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPalabra.Clear();
                return;
            }
            bool resultado = EsPalindromo(palabraIngresada);
            if (resultado)
            {
                MessageBox.Show($"\"{palabraIngresada}\" es un palíndromo.",
                                "Resultado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"\"{palabraIngresada}\" NO es un palíndromo.",
                                "Resultado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            txtPalabra.Clear();
        }
    }
}
