namespace EvaluacionDiagnosticaApp
{
    partial class FormAhorcado
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
            lblPalabraOculta = new Label();
            txtLetra = new TextBox();
            btnProbar = new Button();
            lblIntentosRestantes = new Label();
            lblLetrasUsadas = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(307, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Ahorcado";
            // 
            // lblPalabraOculta
            // 
            lblPalabraOculta.AutoSize = true;
            lblPalabraOculta.Font = new Font("Microsoft Sans Serif", 14F);
            lblPalabraOculta.Location = new Point(365, 136);
            lblPalabraOculta.Name = "lblPalabraOculta";
            lblPalabraOculta.Size = new Size(70, 24);
            lblPalabraOculta.TabIndex = 3;
            lblPalabraOculta.Text = "_ _ _ _ ";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(372, 201);
            txtLetra.MaxLength = 1;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(50, 23);
            txtLetra.TabIndex = 4;
            // 
            // btnProbar
            // 
            btnProbar.BackColor = Color.LightBlue;
            btnProbar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnProbar.Location = new Point(340, 248);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(120, 30);
            btnProbar.TabIndex = 5;
            btnProbar.Text = "Probar Letra";
            btnProbar.UseVisualStyleBackColor = false;
            btnProbar.Click += btnProbar_Click;
            // 
            // lblIntentosRestantes
            // 
            lblIntentosRestantes.AutoSize = true;
            lblIntentosRestantes.Font = new Font("Microsoft Sans Serif", 14F);
            lblIntentosRestantes.Location = new Point(113, 136);
            lblIntentosRestantes.Name = "lblIntentosRestantes";
            lblIntentosRestantes.Size = new Size(175, 24);
            lblIntentosRestantes.TabIndex = 7;
            lblIntentosRestantes.Text = "Intentos restantes: 5";
            // 
            // lblLetrasUsadas
            // 
            lblLetrasUsadas.AutoSize = true;
            lblLetrasUsadas.Font = new Font("Microsoft Sans Serif", 14F);
            lblLetrasUsadas.Location = new Point(504, 136);
            lblLetrasUsadas.Name = "lblLetrasUsadas";
            lblLetrasUsadas.Size = new Size(130, 24);
            lblLetrasUsadas.TabIndex = 8;
            lblLetrasUsadas.Text = "Letras usadas:";
            // 
            // FormAhorcado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLetrasUsadas);
            Controls.Add(lblIntentosRestantes);
            Controls.Add(btnProbar);
            Controls.Add(txtLetra);
            Controls.Add(lblPalabraOculta);
            Controls.Add(lblTitulo);
            Name = "FormAhorcado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAhorcado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPalabraOculta;
        private TextBox txtLetra;
        private Button btnProbar;
        private Label lblIntentosRestantes;
        private Label lblLetrasUsadas;
    }
}