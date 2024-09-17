namespace IMC
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
            btncalcular = new Button();
            btnlimpar = new Button();
            textaltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resultado = new Label();
            txtpeso = new TextBox();
            resultvalor = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(50, 157);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(137, 157);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 1;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // textaltura
            // 
            textaltura.Location = new Point(57, 64);
            textaltura.Name = "textaltura";
            textaltura.Size = new Size(169, 23);
            textaltura.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Resultado:";
            label3.Click += label3_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(97, 107);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 7;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(57, 20);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(169, 23);
            txtpeso.TabIndex = 8;
            // 
            // resultvalor
            // 
            resultvalor.AutoSize = true;
            resultvalor.Location = new Point(97, 122);
            resultvalor.Name = "resultvalor";
            resultvalor.Size = new Size(28, 15);
            resultvalor.TabIndex = 10;
            resultvalor.Text = "0,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 122);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Valor: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 208);
            Controls.Add(resultvalor);
            Controls.Add(label5);
            Controls.Add(txtpeso);
            Controls.Add(resultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textaltura);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnlimpar;
        private TextBox textpeso;
        private TextBox textaltura;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label resultado;
        private TextBox txtpeso;
        private Label resultvalor;
        private Label label5;
    }
}
