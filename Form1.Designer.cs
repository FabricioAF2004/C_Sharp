namespace calculadora_IMC
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            resultado = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            valorIMC = new TextBox();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(165, 57);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 0;
            txtAltura.TextAlign = HorizontalAlignment.Center;
            txtAltura.TextChanged += altura_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 109);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(165, 137);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 31);
            txtPeso.TabIndex = 2;
            txtPeso.TextAlign = HorizontalAlignment.Center;
            txtPeso.TextChanged += peso_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 275);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // resultado
            // 
            resultado.Location = new Point(58, 303);
            resultado.Name = "resultado";
            resultado.Size = new Size(348, 31);
            resultado.TabIndex = 6;
            resultado.TextAlign = HorizontalAlignment.Center;
            resultado.TextChanged += resultado_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(13, 376);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(359, 376);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 196);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 12;
            label3.Text = "Valor do IMC";
            // 
            // valorIMC
            // 
            valorIMC.Location = new Point(166, 224);
            valorIMC.Name = "valorIMC";
            valorIMC.Size = new Size(150, 31);
            valorIMC.TabIndex = 11;
            valorIMC.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(label3);
            Controls.Add(valorIMC);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(txtPeso);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltura;
        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private Label label4;
        private TextBox resultado;
        private Button btnCalcular;
        private Button btnLimpar;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private TextBox valorIMC;
    }
}
