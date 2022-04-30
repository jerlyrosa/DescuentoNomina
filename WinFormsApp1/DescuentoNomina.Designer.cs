namespace WinFormsApp1
{
    partial class DescuentoNomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputArs = new System.Windows.Forms.TextBox();
            this.InputAfp = new System.Windows.Forms.TextBox();
            this.InputIsr = new System.Windows.Forms.TextBox();
            this.InputTotalDescuento = new System.Windows.Forms.TextBox();
            this.InputSueldoNeto = new System.Windows.Forms.TextBox();
            this.InputSalarioMensual = new System.Windows.Forms.TextBox();
            this.InputHorasExtras = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARS (3.04%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(259, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "AFP (2.87%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(259, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total. Descuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(259, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sueldo Neto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 295);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salario Mensual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(257, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Horas Extras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(281, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descuento de Nomina";
            // 
            // inputArs
            // 
            this.inputArs.Location = new System.Drawing.Point(423, 74);
            this.inputArs.Name = "inputArs";
            this.inputArs.Size = new System.Drawing.Size(169, 23);
            this.inputArs.TabIndex = 1;
            // 
            // InputAfp
            // 
            this.InputAfp.Location = new System.Drawing.Point(423, 111);
            this.InputAfp.Name = "InputAfp";
            this.InputAfp.Size = new System.Drawing.Size(169, 23);
            this.InputAfp.TabIndex = 1;
            // 
            // InputIsr
            // 
            this.InputIsr.Location = new System.Drawing.Point(423, 146);
            this.InputIsr.Name = "InputIsr";
            this.InputIsr.Size = new System.Drawing.Size(169, 23);
            this.InputIsr.TabIndex = 1;
            // 
            // InputTotalDescuento
            // 
            this.InputTotalDescuento.Location = new System.Drawing.Point(423, 184);
            this.InputTotalDescuento.Name = "InputTotalDescuento";
            this.InputTotalDescuento.Size = new System.Drawing.Size(169, 23);
            this.InputTotalDescuento.TabIndex = 1;
            // 
            // InputSueldoNeto
            // 
            this.InputSueldoNeto.Location = new System.Drawing.Point(423, 218);
            this.InputSueldoNeto.Name = "InputSueldoNeto";
            this.InputSueldoNeto.Size = new System.Drawing.Size(169, 23);
            this.InputSueldoNeto.TabIndex = 1;
            // 
            // InputSalarioMensual
            // 
            this.InputSalarioMensual.Location = new System.Drawing.Point(395, 293);
            this.InputSalarioMensual.Name = "InputSalarioMensual";
            this.InputSalarioMensual.Size = new System.Drawing.Size(166, 23);
            this.InputSalarioMensual.TabIndex = 1;
            // 
            // InputHorasExtras
            // 
            this.InputHorasExtras.Location = new System.Drawing.Point(388, 329);
            this.InputHorasExtras.Name = "InputHorasExtras";
            this.InputHorasExtras.Size = new System.Drawing.Size(155, 23);
            this.InputHorasExtras.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(387, 399);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(113, 30);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // DescuentoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.InputHorasExtras);
            this.Controls.Add(this.InputSalarioMensual);
            this.Controls.Add(this.InputSueldoNeto);
            this.Controls.Add(this.InputTotalDescuento);
            this.Controls.Add(this.InputIsr);
            this.Controls.Add(this.InputAfp);
            this.Controls.Add(this.inputArs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DescuentoNomina";
            this.Text = "DescuentoNomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox inputArs;
        private TextBox InputAfp;
        private TextBox InputIsr;
        private TextBox InputTotalDescuento;
        private TextBox InputSueldoNeto;
        private TextBox InputSalarioMensual;
        private TextBox InputHorasExtras;
        private Button calcular;
    }
}