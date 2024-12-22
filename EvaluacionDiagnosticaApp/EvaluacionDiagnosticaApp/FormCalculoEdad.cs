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
    public partial class FormCalculoEdad : Form
    {
        public FormCalculoEdad()
        {
            InitializeComponent();
        }
        // Determina la edad exacta (años, meses, días y horas)
        // restando sucesivamente la fecha y hora de nacimiento de la fecha y hora actuales, devolviendo un cálculo parcial.
        private (int años, int meses, int dias, int horas) CalcularEdadExacta(DateTime fechaNac)
        {
            DateTime ahora = DateTime.Now;
            int años = ahora.Year - fechaNac.Year;
            if (fechaNac.AddYears(años) > ahora)
            {
                años--;
            }
            DateTime fechaTrasAnos = fechaNac.AddYears(años);
            int meses = 0;
            while (fechaTrasAnos.AddMonths(meses + 1) <= ahora)
            {
                meses++;
            }
            DateTime fechaTrasMeses = fechaTrasAnos.AddMonths(meses);
            TimeSpan difDias = ahora - fechaTrasMeses;
            int dias = difDias.Days;
            DateTime fechaTrasDias = fechaTrasMeses.AddDays(dias);
            TimeSpan difHoras = ahora - fechaTrasDias;
            int horas = difHoras.Hours;
            return (años, meses, dias, horas);
        }
        // Obtiene la fecha seleccionada, valida que no sea futura,
        // calcula la edad en años/meses/días/horas de forma parcial y muestra el resultado en un MessageBox,
        // luego limpia los controles.
        private void btnCalcular_Click(object sender, EventArgs e)
        {      
                DateTime fechaSeleccionada = dtpFechaNacimiento.Value;
                if (fechaSeleccionada > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser mayor que la fecha actual.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    LimpiarControles();
                    return;
                }
                var (años, meses, dias, horas) = CalcularEdadExacta(fechaSeleccionada);
                string mensaje = $"Tu edad exacta es:\n" +
                                 $"{años} años\n" +
                                 $"{meses} meses\n" +
                                 $"{dias} días\n" +
                                 $"{horas} horas";
                MessageBox.Show(mensaje,
                                "Cálculo de Edad",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);              
                LimpiarControles();
            }
        //Funcion para limpiar los controles
        private void LimpiarControles()
        {
            dtpFechaNacimiento.Value = DateTime.Now.Date;
        }
    }
}
