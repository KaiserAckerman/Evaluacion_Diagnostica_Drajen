namespace EvaluacionDiagnosticaApp
{
    partial class FormFibonacci
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
            nudPosicion = new NumericUpDown();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPosicion).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(194, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(412, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Sucesión de Fibonacci";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(213, 130);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la posición (n):";
            // 
            // nudPosicion
            // 
            nudPosicion.Location = new Point(360, 131);
            nudPosicion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPosicion.Name = "nudPosicion";
            nudPosicion.Size = new Size(69, 23);
            nudPosicion.TabIndex = 4;
            nudPosicion.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightBlue;
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCalcular.Location = new Point(467, 127);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(250, 189);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(300, 150);
            txtResultado.TabIndex = 6;
            // 
            // FormFibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(nudPosicion);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "FormFibonacci";
            Text = "FormFibonacci";
            ((System.ComponentModel.ISupportInitialize)nudPosicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private NumericUpDown nudPosicion;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}