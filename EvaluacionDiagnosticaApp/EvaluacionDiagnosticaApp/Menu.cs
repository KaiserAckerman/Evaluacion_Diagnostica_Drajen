namespace EvaluacionDiagnosticaApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPalindromos_Click(object sender, EventArgs e)
        {
            FormPalindromos formPalindromos = new FormPalindromos();
            formPalindromos.Show();
        }

        private void btnCalculoEdad_Click(object sender, EventArgs e)
        {
            FormCalculoEdad formCalculoEdad = new FormCalculoEdad();
            formCalculoEdad.Show();
        }

        private void btnGeneradorContrasenas_Click(object sender, EventArgs e)
        {
            FormGeneradorContraseñas formGeneradorContrasenas = new FormGeneradorContraseñas();
            formGeneradorContrasenas.Show();
        }

        private void btnAhorcado_Click(object sender, EventArgs e)
        {
            FormAhorcado formAhorcado = new FormAhorcado();
            formAhorcado.Show();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            FormFibonacci formFibonacci = new FormFibonacci();
            formFibonacci.Show();
        }

        private void btnCrudUsuarios_Click(object sender, EventArgs e)
        {
            FormCrudUsuarios formCrudUsuarios = new FormCrudUsuarios();
            formCrudUsuarios.Show();
        }
    }
}
