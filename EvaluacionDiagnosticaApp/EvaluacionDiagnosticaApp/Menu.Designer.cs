namespace EvaluacionDiagnosticaApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPalindromos = new Button();
            btnGeneradorContrasenas = new Button();
            btnFibonacci = new Button();
            btnCrudUsuarios = new Button();
            btnAhorcado = new Button();
            btnCalculoEdad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtG", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 18);
            label1.Name = "label1";
            label1.Size = new Size(270, 48);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // btnPalindromos
            // 
            btnPalindromos.BackColor = Color.LightSteelBlue;
            btnPalindromos.Cursor = Cursors.Hand;
            btnPalindromos.FlatStyle = FlatStyle.Flat;
            btnPalindromos.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPalindromos.Location = new Point(175, 96);
            btnPalindromos.Name = "btnPalindromos";
            btnPalindromos.Size = new Size(120, 50);
            btnPalindromos.TabIndex = 1;
            btnPalindromos.Text = "Palindromos";
            btnPalindromos.UseVisualStyleBackColor = false;
            btnPalindromos.Click += btnPalindromos_Click;
            // 
            // btnGeneradorContrasenas
            // 
            btnGeneradorContrasenas.BackColor = Color.LightSteelBlue;
            btnGeneradorContrasenas.Cursor = Cursors.Hand;
            btnGeneradorContrasenas.FlatStyle = FlatStyle.Flat;
            btnGeneradorContrasenas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneradorContrasenas.Location = new Point(175, 213);
            btnGeneradorContrasenas.Name = "btnGeneradorContrasenas";
            btnGeneradorContrasenas.Size = new Size(120, 50);
            btnGeneradorContrasenas.TabIndex = 2;
            btnGeneradorContrasenas.Text = "Generador";
            btnGeneradorContrasenas.UseVisualStyleBackColor = false;
            btnGeneradorContrasenas.Click += btnGeneradorContrasenas_Click;
            // 
            // btnFibonacci
            // 
            btnFibonacci.BackColor = Color.LightSteelBlue;
            btnFibonacci.Cursor = Cursors.Hand;
            btnFibonacci.FlatStyle = FlatStyle.Flat;
            btnFibonacci.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFibonacci.Location = new Point(175, 330);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(120, 50);
            btnFibonacci.TabIndex = 3;
            btnFibonacci.Text = "Fibonacci";
            btnFibonacci.UseVisualStyleBackColor = false;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // btnCrudUsuarios
            // 
            btnCrudUsuarios.BackColor = Color.LightSteelBlue;
            btnCrudUsuarios.Cursor = Cursors.Hand;
            btnCrudUsuarios.FlatStyle = FlatStyle.Flat;
            btnCrudUsuarios.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrudUsuarios.Location = new Point(495, 330);
            btnCrudUsuarios.Name = "btnCrudUsuarios";
            btnCrudUsuarios.Size = new Size(120, 50);
            btnCrudUsuarios.TabIndex = 6;
            btnCrudUsuarios.Text = "Crud Usuarios";
            btnCrudUsuarios.UseVisualStyleBackColor = false;
            btnCrudUsuarios.Click += btnCrudUsuarios_Click;
            // 
            // btnAhorcado
            // 
            btnAhorcado.BackColor = Color.LightSteelBlue;
            btnAhorcado.Cursor = Cursors.Hand;
            btnAhorcado.FlatStyle = FlatStyle.Flat;
            btnAhorcado.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAhorcado.Location = new Point(495, 213);
            btnAhorcado.Name = "btnAhorcado";
            btnAhorcado.Size = new Size(120, 50);
            btnAhorcado.TabIndex = 5;
            btnAhorcado.Text = "Ahorcado";
            btnAhorcado.UseVisualStyleBackColor = false;
            btnAhorcado.Click += btnAhorcado_Click;
            // 
            // btnCalculoEdad
            // 
            btnCalculoEdad.BackColor = Color.LightSteelBlue;
            btnCalculoEdad.Cursor = Cursors.Hand;
            btnCalculoEdad.FlatStyle = FlatStyle.Flat;
            btnCalculoEdad.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculoEdad.Location = new Point(495, 96);
            btnCalculoEdad.Name = "btnCalculoEdad";
            btnCalculoEdad.Size = new Size(120, 50);
            btnCalculoEdad.TabIndex = 4;
            btnCalculoEdad.Text = "Calculo Edad";
            btnCalculoEdad.UseVisualStyleBackColor = false;
            btnCalculoEdad.Click += btnCalculoEdad_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrudUsuarios);
            Controls.Add(btnAhorcado);
            Controls.Add(btnCalculoEdad);
            Controls.Add(btnFibonacci);
            Controls.Add(btnGeneradorContrasenas);
            Controls.Add(btnPalindromos);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPalindromos;
        private Button btnGeneradorContrasenas;
        private Button btnFibonacci;
        private Button btnCrudUsuarios;
        private Button btnAhorcado;
        private Button btnCalculoEdad;
    }
}
