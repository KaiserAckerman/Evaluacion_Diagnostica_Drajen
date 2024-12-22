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
    public partial class FormGeneradorContraseñas : Form
    {
        public FormGeneradorContraseñas()
        {
            InitializeComponent();
        }
        // Genera una contraseña aleatoria con longitud mínima de 8 caracteres y al menos una mayúscula, 
        // un dígito y un carácter especial; luego mezcla los caracteres para asegurar mayor aleatoriedad.
        private string GenerarContrasena(int longitud)
        {
            const string MAYUSCULAS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string MINUSCULAS = "abcdefghijklmnopqrstuvwxyz";
            const string DIGITOS = "0123456789";
            const string ESPECIALES = "!@#$%^&*()-_=+<>?";
            if (longitud < 8)
            {
                throw new ArgumentException("La longitud mínima es 8.");
            }
            Random rnd = new Random();
            char mayus = MAYUSCULAS[rnd.Next(MAYUSCULAS.Length)];
            char digito = DIGITOS[rnd.Next(DIGITOS.Length)];
            char especial = ESPECIALES[rnd.Next(ESPECIALES.Length)];
            List<char> caracteres = new List<char>();
            caracteres.Add(mayus);
            caracteres.Add(digito);
            caracteres.Add(especial);
            string TODOS_LOS_CARACTERES = MAYUSCULAS + MINUSCULAS + DIGITOS + ESPECIALES;
            for (int i = 0; i < (longitud - 3); i++)
            {
                caracteres.Add(TODOS_LOS_CARACTERES[rnd.Next(TODOS_LOS_CARACTERES.Length)]);
            }
            for (int i = 0; i < caracteres.Count; i++)
            {
                int randomIndex = rnd.Next(caracteres.Count);
                char temp = caracteres[i];
                caracteres[i] = caracteres[randomIndex];
                caracteres[randomIndex] = temp;
            }
            return new string(caracteres.ToArray());
        }
        // Obtiene la longitud elegida, genera una contraseña que cumple los requisitos y la muestra en el TextBox.
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitudDeseada = (int)nudLongitud.Value;
            string contrasena = GenerarContrasena(longitudDeseada);
            txtContrasena.Text = contrasena;
        }
    }
}
