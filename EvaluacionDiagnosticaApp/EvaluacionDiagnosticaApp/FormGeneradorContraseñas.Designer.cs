namespace EvaluacionDiagnosticaApp
{
    partial class FormGeneradorContraseñas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label1 = new Label();
            nudLongitud = new NumericUpDown();
            btnGenerar = new Button();
            txtContrasena = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(157, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(486, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Generador de Contraseñas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(165, 119);
            label1.Name = "label1";
            label1.Size = new Size(177, 17);
            label1.TabIndex = 3;
            label1.Text = "Longitud de la contraseña:";
            // 
            // nudLongitud
            // 
            nudLongitud.Location = new Point(343, 118);
            nudLongitud.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudLongitud.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(120, 23);
            nudLongitud.TabIndex = 4;
            nudLongitud.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.LightBlue;
            btnGenerar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnGenerar.Location = new Point(340, 179);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 30);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.AutoSize = true;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.FlatStyle = FlatStyle.Flat;
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.Location = new Point(320, 239);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(162, 23);
            txtContrasena.TabIndex = 6;
            txtContrasena.Text = "Contraseña Generada";
            txtContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGeneradorContraseñas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContrasena);
            Controls.Add(btnGenerar);
            Controls.Add(nudLongitud);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "FormGeneradorContraseñas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGeneradorContraseñas";
            ((System.ComponentModel.ISupportInitialize)nudLongitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private NumericUpDown nudLongitud;
        private Button btnGenerar;
        private Label txtContrasena;
    }
}