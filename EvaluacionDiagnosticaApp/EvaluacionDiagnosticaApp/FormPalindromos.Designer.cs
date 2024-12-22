namespace EvaluacionDiagnosticaApp
{
    partial class FormPalindromos
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
            txtPalabra = new TextBox();
            btnValidar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(168, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Validador de Palíndromos";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(365, 138);
            txtPalabra.MaxLength = 50;
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(200, 23);
            txtPalabra.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.LightBlue;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Location = new Point(414, 206);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 30);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 135);
            label2.Name = "label2";
            label2.Size = new Size(180, 26);
            label2.TabIndex = 3;
            label2.Text = "Ingrese una palabra";
            // 
            // FormPalindromos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnValidar);
            Controls.Add(txtPalabra);
            Controls.Add(lblTitulo);
            Name = "FormPalindromos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPalindromos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtPalabra;
        private Button btnValidar;
        private Label label2;
    }
}