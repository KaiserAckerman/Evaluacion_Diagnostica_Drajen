using System;
using System.Collections.Generic;
using System.IO;               
using System.Linq;             
using System.Windows.Forms;
using Newtonsoft.Json;         

namespace EvaluacionDiagnosticaApp
{
    public partial class FormCrudUsuarios : Form
    {
        // Clase con las variables del usuario
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Contrasena { get; set; }
        }
        // Lista en memoria y variables
        private List<Usuario> listaUsuarios;
        private int ultimoId;
        private const string ARCHIVO_JSON = "usuarios.json";
        public FormCrudUsuarios()
        {
            InitializeComponent();         
        }
        private void FormCrudUsuarios_Load_1(object sender, EventArgs e)
        {
            CargarUsuariosDeJson();
            RefrescarGrid();
        }
        // Cargar JSON
        private void CargarUsuariosDeJson()
        {
            if (File.Exists(ARCHIVO_JSON))
            {
                string json = File.ReadAllText(ARCHIVO_JSON);
                listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);

                if (listaUsuarios == null)
                    listaUsuarios = new List<Usuario>();
            }
            else
            {
                listaUsuarios = new List<Usuario>();
            }

            if (listaUsuarios.Count > 0)
                ultimoId = listaUsuarios.Max(u => u.Id);
            else
                ultimoId = 0;
        }
        // Guardar JSON tras cada cambio
        private void GuardarUsuariosEnJson()
        {
            string json = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
            File.WriteAllText(ARCHIVO_JSON, json);
        }
        // Muestra la lista en el DataGridView
        private void RefrescarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // Verifica campos obligatorios, crea un nuevo usuario con ID autoincremental, lo agrega a la lista, 
        // guarda en JSON, actualiza la vista y limpia los controles.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingresa los datos requeridos (Nombre y Contraseña).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ultimoId++;
            Usuario nuevo = new Usuario()
            {
                Id = ultimoId,
                Nombre = txtNombre.Text.Trim(),
                Contrasena = txtContrasena.Text,
                Edad = (int)nudEdad.Value
            };
            listaUsuarios.Add(nuevo);
            GuardarUsuariosEnJson();
            RefrescarGrid();
            LimpiarCampos();
        }
        // Verifica que exista un usuario seleccionado y, si lo encuentra, actualiza sus datos, guarda los cambios en el JSON
        // refresca la lista y limpia los campos.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecciona un usuario para editar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = int.Parse(txtId.Text);
            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Edad = (int)nudEdad.Value;
                usuario.Contrasena = txtContrasena.Text;
                GuardarUsuariosEnJson();
                RefrescarGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El usuario no existe en la lista.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Verifica que se haya seleccionado un usuario, solicita confirmación para eliminarlo y, 
        // de proceder, lo quita de la lista, actualiza el JSON y refresca la interfaz.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecciona un usuario para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(txtId.Text);
            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                var confirm = MessageBox.Show($"¿Seguro que deseas eliminar al usuario '{usuario.Nombre}'?",
                                              "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    listaUsuarios.Remove(usuario);
                    GuardarUsuariosEnJson();
                    RefrescarGrid();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe en la lista.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Obtiene el usuario seleccionado en el DataGridView y llena los controles del formulario con sus datos.
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Usuario seleccionado = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
                txtId.Text = seleccionado.Id.ToString();
                txtNombre.Text = seleccionado.Nombre;
                // Aqui se muestra en nudEdad, no en dgvUsuarios.Value
                nudEdad.Value = seleccionado.Edad;
                txtContrasena.Text = seleccionado.Contrasena;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        // Limpia los campos del formulario, restableciendo el ID y el texto, y reiniciando la edad a cero.
        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            nudEdad.Value = 0;
            txtContrasena.Text = "";
        }
    }
}
