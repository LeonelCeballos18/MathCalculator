namespace ProyectoMatematicas2daParcial
{
    partial class reglaFalsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxXl = new System.Windows.Forms.TextBox();
            this.TxtBoxXu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxParo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxFuncion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblNumItera = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.TxtBoxDecimales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new ProyectoMatematicas2daParcial.Buttons();
            this.BtnLimpiar = new ProyectoMatematicas2daParcial.Buttons();
            this.BtnCalcular = new ProyectoMatematicas2daParcial.Buttons();
            this.DataGridIteraciones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(51, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(56, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xl: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "FALSE POSITION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter the reference values to approximate the root";
            // 
            // TxtBoxXl
            // 
            this.TxtBoxXl.Location = new System.Drawing.Point(101, 128);
            this.TxtBoxXl.Name = "TxtBoxXl";
            this.TxtBoxXl.Size = new System.Drawing.Size(191, 20);
            this.TxtBoxXl.TabIndex = 2;
            // 
            // TxtBoxXu
            // 
            this.TxtBoxXu.Location = new System.Drawing.Point(101, 102);
            this.TxtBoxXu.Name = "TxtBoxXu";
            this.TxtBoxXu.Size = new System.Drawing.Size(191, 20);
            this.TxtBoxXu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(548, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result:";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(647, 130);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(19, 20);
            this.LblRes.TabIndex = 13;
            this.LblRes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter the stopping factor:";
            // 
            // TxtBoxParo
            // 
            this.TxtBoxParo.Location = new System.Drawing.Point(55, 178);
            this.TxtBoxParo.Name = "TxtBoxParo";
            this.TxtBoxParo.Size = new System.Drawing.Size(191, 20);
            this.TxtBoxParo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter the function";
            // 
            // TxtBoxFuncion
            // 
            this.TxtBoxFuncion.Location = new System.Drawing.Point(55, 278);
            this.TxtBoxFuncion.Name = "TxtBoxFuncion";
            this.TxtBoxFuncion.Size = new System.Drawing.Size(425, 20);
            this.TxtBoxFuncion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(548, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Number of Iterations:";
            // 
            // LblNumItera
            // 
            this.LblNumItera.AutoSize = true;
            this.LblNumItera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblNumItera.Location = new System.Drawing.Point(742, 167);
            this.LblNumItera.Name = "LblNumItera";
            this.LblNumItera.Size = new System.Drawing.Size(19, 20);
            this.LblNumItera.TabIndex = 19;
            this.LblNumItera.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(548, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Error: ";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblError.Location = new System.Drawing.Point(611, 202);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(34, 20);
            this.LblError.TabIndex = 21;
            this.LblError.Text = "0%";
            // 
            // TxtBoxDecimales
            // 
            this.TxtBoxDecimales.Location = new System.Drawing.Point(55, 228);
            this.TxtBoxDecimales.Name = "TxtBoxDecimales";
            this.TxtBoxDecimales.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxDecimales.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(44, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Enter the number of decimals to work with:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 62);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 68);
            this.panel2.TabIndex = 25;
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
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Clear";
            this.BtnLimpiar.TextColor = System.Drawing.Color.White;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
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
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calculate";
            this.BtnCalcular.TextColor = System.Drawing.Color.White;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // DataGridIteraciones
            // 
            this.DataGridIteraciones.AllowUserToAddRows = false;
            this.DataGridIteraciones.AllowUserToDeleteRows = false;
            this.DataGridIteraciones.AllowUserToResizeColumns = false;
            this.DataGridIteraciones.AllowUserToResizeRows = false;
            this.DataGridIteraciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridIteraciones.Location = new System.Drawing.Point(130, 318);
            this.DataGridIteraciones.Name = "DataGridIteraciones";
            this.DataGridIteraciones.Size = new System.Drawing.Size(762, 246);
            this.DataGridIteraciones.TabIndex = 88;
            this.DataGridIteraciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridIteraciones_CellContentClick);
            // 
            // reglaFalsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.DataGridIteraciones);
            this.Controls.Add(this.TxtBoxDecimales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblNumItera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBoxFuncion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtBoxParo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxXu);
            this.Controls.Add(this.TxtBoxXl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reglaFalsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reglaFalsa";
            this.Load += new System.EventHandler(this.reglaFalsa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Buttons BtnSalir;
        private Buttons BtnCalcular;
        private Buttons BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxXl;
        private System.Windows.Forms.TextBox TxtBoxXu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBoxParo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxFuncion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblNumItera;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TxtBoxDecimales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridIteraciones;
    }
}