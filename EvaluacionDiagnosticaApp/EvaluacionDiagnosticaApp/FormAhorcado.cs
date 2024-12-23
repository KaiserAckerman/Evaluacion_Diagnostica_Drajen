using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EvaluacionDiagnosticaApp
{
    public partial class FormAhorcado : Form
    {
        public FormAhorcado()
        {
            InitializeComponent();
            IniciarJuego();
        }
//DECLARACION VARIABLES UTILIZADAS
        private readonly string[] palabras = { "PERRO", "GATO", "AVION", "JUEGO", "CABLE", "PLUMA" };
        private string palabraSecreta;
        private char[] palabraOculta;
        private int errores;
        private const int MAX_ERRORES = 5;
        private List<char> letrasUsadas;

        // Selecciona aleatoriamente la palabra secreta, inicializa la versión oculta y reinicia errores, 
        // letras usadas y controles de interfaz para comenzar o reiniciar el juego.
        private void IniciarJuego()
        {
            Random rnd = new Random();
            int index = rnd.Next(palabras.Length);
            palabraSecreta = palabras[index].ToUpper();
            palabraOculta = new string('_', palabraSecreta.Length).ToCharArray();
            errores = 0;
            letrasUsadas = new List<char>();
            lblPalabraOculta.Text = new string(palabraOculta);
            lblIntentosRestantes.Text = $"Intentos restantes: {MAX_ERRORES - errores}";
            lblLetrasUsadas.Text = "Letras usadas: ";
            txtLetra.Clear();
            txtLetra.Focus();
        }
        // Valida la letra ingresada contra la palabra secreta, actualiza errores o aciertos y reinicia el juego al ganar o agotar intentos.
        private void btnProbar_Click(object sender, EventArgs e)
        {
            string input = txtLetra.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
            {
                MessageBox.Show("Ingresa una letra válida.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLetra.Clear();
                txtLetra.Focus();
                return;
            }
            char letraIngresada = input[0];
            if (letrasUsadas.Contains(letraIngresada))
            {
                MessageBox.Show("Ya intentaste con esa letra.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtLetra.Clear();
                txtLetra.Focus();
                return;
            }
            letrasUsadas.Add(letraIngresada);
            bool acierto = false;
            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letraIngresada)
                {
                    palabraOculta[i] = letraIngresada;
                    acierto = true;
                }
            }
            if (!acierto)
            {
                errores++;
            }
            lblPalabraOculta.Text = new string(palabraOculta);
            lblLetrasUsadas.Text = $"Letras usadas: {string.Join(", ", letrasUsadas)}";
            lblIntentosRestantes.Text = $"Intentos restantes: {MAX_ERRORES - errores}";
            txtLetra.Clear();
            txtLetra.Focus();
            if (!new string(palabraOculta).Contains('_'))
            {
                MessageBox.Show("¡Felicidades! Adivinaste la palabra: " + palabraSecreta,
                                "Ganaste",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                IniciarJuego();
                return;
            }
            if (errores >= MAX_ERRORES)
            {
                MessageBox.Show($"Lo siento, has perdido. La palabra era: {palabraSecreta}",
                                "Perdiste",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                IniciarJuego();
                return;
            }
        }
    }
}
