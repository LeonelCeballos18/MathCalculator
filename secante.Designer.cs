namespace ProyectoMatematicas2daParcial
{
    partial class secante
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
            this.TxtBoxDecimales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxFuncion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxSuperior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxInferior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new ProyectoMatematicas2daParcial.Buttons();
            this.BtnCalcular = new ProyectoMatematicas2daParcial.Buttons();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEFINED INTEGRALS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 68);
            this.panel2.TabIndex = 27;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BtnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSalir.BorderRadius = 10;
            this.BtnSalir.BorderSize = 0;
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
            // TxtBoxDecimales
            // 
            this.TxtBoxDecimales.Location = new System.Drawing.Point(44, 196);
            this.TxtBoxDecimales.Name = "TxtBoxDecimales";
            this.TxtBoxDecimales.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxDecimales.TabIndex = 68;
            this.TxtBoxDecimales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxDecimales_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(33, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Enter the number of decimals to work with:";
            // 
            // TxtBoxFuncion
            // 
            this.TxtBoxFuncion.Location = new System.Drawing.Point(44, 269);
            this.TxtBoxFuncion.Name = "TxtBoxFuncion";
            this.TxtBoxFuncion.Size = new System.Drawing.Size(425, 20);
            this.TxtBoxFuncion.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(33, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Enter the function";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(604, 130);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(19, 20);
            this.LblRes.TabIndex = 75;
            this.LblRes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(505, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Result:";
            // 
            // TxtBoxSuperior
            // 
            this.TxtBoxSuperior.Location = new System.Drawing.Point(120, 127);
            this.TxtBoxSuperior.Name = "TxtBoxSuperior";
            this.TxtBoxSuperior.Size = new System.Drawing.Size(62, 20);
            this.TxtBoxSuperior.TabIndex = 66;
            this.TxtBoxSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSuperior_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Enter the limits of the integral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Upper:";
            // 
            // TxtBoxInferior
            // 
            this.TxtBoxInferior.Location = new System.Drawing.Point(299, 127);
            this.TxtBoxInferior.Name = "TxtBoxInferior";
            this.TxtBoxInferior.Size = new System.Drawing.Size(62, 20);
            this.TxtBoxInferior.TabIndex = 83;
            this.TxtBoxInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxInferior_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(222, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Lower: ";
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
            this.BtnLimpiar.TabIndex = 30;
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
            this.BtnCalcular.TabIndex = 29;
            this.BtnCalcular.Text = "Calculate";
            this.BtnCalcular.TextColor = System.Drawing.Color.White;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(629, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "u^2";
            // 
            // secante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxInferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxDecimales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBoxFuncion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxSuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "secante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "secante";
            this.Load += new System.EventHandler(this.secante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Buttons BtnSalir;
        private Buttons BtnLimpiar;
        private Buttons BtnCalcular;
        private System.Windows.Forms.TextBox TxtBoxDecimales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBoxFuncion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}