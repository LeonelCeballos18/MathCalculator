namespace ProyectoMatematicas2daParcial
{
    partial class ReglaTrapezoidal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new ProyectoMatematicas2daParcial.Buttons();
            this.TxtBoxInferior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxDecimales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxFuncion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblResIntegral = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxSuperior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblResTrapezio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxTBoxSegmentos = new System.Windows.Forms.TextBox();
            this.DataGridxFx = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new ProyectoMatematicas2daParcial.Buttons();
            this.BtnCalcular = new ProyectoMatematicas2daParcial.Buttons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridxFx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 62);
            this.panel1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "REGLA TRAPEZOIDAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 68);
            this.panel2.TabIndex = 29;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSalir.BorderRadius = 10;
            this.BtnSalir.BorderSize = 0;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(860, 16);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(150, 40);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "&Exit";
            this.BtnSalir.TextColor = System.Drawing.Color.White;
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // TxtBoxInferior
            // 
            this.TxtBoxInferior.Location = new System.Drawing.Point(314, 143);
            this.TxtBoxInferior.Name = "TxtBoxInferior";
            this.TxtBoxInferior.Size = new System.Drawing.Size(62, 20);
            this.TxtBoxInferior.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(237, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Lower:";
            // 
            // TxtBoxDecimales
            // 
            this.TxtBoxDecimales.Location = new System.Drawing.Point(52, 212);
            this.TxtBoxDecimales.Name = "TxtBoxDecimales";
            this.TxtBoxDecimales.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxDecimales.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(48, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 20);
            this.label9.TabIndex = 96;
            this.label9.Text = "Enter the number of decimals to work with:";
            // 
            // TxtBoxFuncion
            // 
            this.TxtBoxFuncion.Location = new System.Drawing.Point(52, 285);
            this.TxtBoxFuncion.Name = "TxtBoxFuncion";
            this.TxtBoxFuncion.Size = new System.Drawing.Size(425, 20);
            this.TxtBoxFuncion.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(48, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 95;
            this.label7.Text = "Enter the function";
            // 
            // LblResIntegral
            // 
            this.LblResIntegral.AutoSize = true;
            this.LblResIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResIntegral.Location = new System.Drawing.Point(113, 430);
            this.LblResIntegral.Name = "LblResIntegral";
            this.LblResIntegral.Size = new System.Drawing.Size(52, 20);
            this.LblResIntegral.TabIndex = 94;
            this.LblResIntegral.Text = "0 u^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(48, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Defined Integral Result:";
            // 
            // TxtBoxSuperior
            // 
            this.TxtBoxSuperior.Location = new System.Drawing.Point(135, 143);
            this.TxtBoxSuperior.Name = "TxtBoxSuperior";
            this.TxtBoxSuperior.Size = new System.Drawing.Size(62, 20);
            this.TxtBoxSuperior.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Enter the limits of the integral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(55, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Upper:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(48, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 100;
            this.label8.Text = "Trapezoidal Rule Result:";
            // 
            // LblResTrapezio
            // 
            this.LblResTrapezio.AutoSize = true;
            this.LblResTrapezio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResTrapezio.Location = new System.Drawing.Point(113, 511);
            this.LblResTrapezio.Name = "LblResTrapezio";
            this.LblResTrapezio.Size = new System.Drawing.Size(52, 20);
            this.LblResTrapezio.TabIndex = 101;
            this.LblResTrapezio.Text = "0 u^2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(48, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 103;
            this.label12.Text = "Error:";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(102, 544);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(34, 20);
            this.LblError.TabIndex = 104;
            this.LblError.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(48, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Enter the segments to work with:";
            // 
            // TxTBoxSegmentos
            // 
            this.TxTBoxSegmentos.Location = new System.Drawing.Point(299, 342);
            this.TxTBoxSegmentos.Name = "TxTBoxSegmentos";
            this.TxTBoxSegmentos.Size = new System.Drawing.Size(92, 20);
            this.TxTBoxSegmentos.TabIndex = 106;
            // 
            // DataGridxFx
            // 
            this.DataGridxFx.AllowUserToAddRows = false;
            this.DataGridxFx.AllowUserToDeleteRows = false;
            this.DataGridxFx.AllowUserToResizeColumns = false;
            this.DataGridxFx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridxFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridxFx.Location = new System.Drawing.Point(564, 285);
            this.DataGridxFx.Name = "DataGridxFx";
            this.DataGridxFx.Size = new System.Drawing.Size(305, 288);
            this.DataGridxFx.TabIndex = 107;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnLimpiar.BorderRadius = 10;
            this.BtnLimpiar.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(790, 180);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "Clear";
            this.BtnLimpiar.TextColor = System.Drawing.Color.White;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnCalcular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnCalcular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCalcular.BorderRadius = 10;
            this.BtnCalcular.BorderSize = 0;
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(790, 114);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(150, 40);
            this.BtnCalcular.TabIndex = 26;
            this.BtnCalcular.Text = "Calculate";
            this.BtnCalcular.TextColor = System.Drawing.Color.White;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // ReglaTrapezoidal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.DataGridxFx);
            this.Controls.Add(this.TxTBoxSegmentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblResTrapezio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBoxInferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxDecimales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBoxFuncion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblResIntegral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxSuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReglaTrapezoidal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReglaTrapezoidal";
            this.Load += new System.EventHandler(this.ReglaTrapezoidal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridxFx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Buttons BtnLimpiar;
        private Buttons BtnCalcular;
        private Buttons BtnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtBoxInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxDecimales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBoxFuncion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblResIntegral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblResTrapezio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxTBoxSegmentos;
        private System.Windows.Forms.DataGridView DataGridxFx;
    }
}