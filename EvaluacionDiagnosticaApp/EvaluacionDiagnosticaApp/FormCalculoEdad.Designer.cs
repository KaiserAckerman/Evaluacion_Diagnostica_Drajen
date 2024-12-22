namespace EvaluacionDiagnosticaApp
{
    partial class FormCalculoEdad
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
            dtpFechaNacimiento = new DateTimePicker();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(373, 128);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(126, 23);
            dtpFechaNacimiento.TabIndex = 0;
            dtpFechaNacimiento.Value = new DateTime(2024, 12, 22, 16, 12, 23, 0);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(250, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cálculo de Edad";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruccion.Location = new Point(123, 128);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(244, 21);
            lblInstruccion.TabIndex = 2;
            lblInstruccion.Text = "Selecciona tu fecha de nacimiento";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightBlue;
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCalcular.Location = new Point(340, 202);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 30);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormCalculoEdad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblInstruccion);
            Controls.Add(lblTitulo);
            Controls.Add(dtpFechaNacimiento);
            Name = "FormCalculoEdad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalculoEdad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaNacimiento;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Button btnCalcular;
    }
}