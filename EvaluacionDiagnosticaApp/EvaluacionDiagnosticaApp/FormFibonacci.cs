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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }
        // Crea una lista con los primeros n términos de la sucesión de Fibonacci de manera iterativa.
        private List<long> GenerarFibonacci(int n)
        {
            List<long> fibo = new List<long>();
            if (n >= 1) fibo.Add(0);
            if (n >= 2) fibo.Add(1);
            for (int i = 2; i < n; i++)
            {
                long siguiente = fibo[i - 1] + fibo[i - 2];
                fibo.Add(siguiente);
            }
            return fibo;
        }
        // Toma la posición n del NumericUpDown, genera la sucesión de Fibonacci y muestra el resultado en el TextBox.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = (int)nudPosicion.Value;
            List<long> secuencia = GenerarFibonacci(n);
            string resultado = string.Join(", ", secuencia);
            txtResultado.Text = resultado;
        }
    }
}
