namespace Proyecto_MetodosNumericos
{
    partial class FrmFalsaPosicion
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
            this.dtgIteraciones = new System.Windows.Forms.DataGridView();
            this.gpbFuncion = new System.Windows.Forms.GroupBox();
            this.txtCoeficienteA = new System.Windows.Forms.TextBox();
            this.txtCoeficienteB = new System.Windows.Forms.TextBox();
            this.txtCoeficienteC = new System.Windows.Forms.TextBox();
            this.txtCoeficienteD = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXa = new System.Windows.Forms.TextBox();
            this.txtXb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIteraciones)).BeginInit();
            this.gpbFuncion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgIteraciones
            // 
            this.dtgIteraciones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIteraciones.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgIteraciones.Location = new System.Drawing.Point(360, 174);
            this.dtgIteraciones.Name = "dtgIteraciones";
            this.dtgIteraciones.Size = new System.Drawing.Size(800, 400);
            this.dtgIteraciones.TabIndex = 0;
            // 
            // gpbFuncion
            // 
            this.gpbFuncion.Controls.Add(this.txtRaiz);
            this.gpbFuncion.Controls.Add(this.label7);
            this.gpbFuncion.Controls.Add(this.txtError);
            this.gpbFuncion.Controls.Add(this.label6);
            this.gpbFuncion.Controls.Add(this.label5);
            this.gpbFuncion.Controls.Add(this.txtXb);
            this.gpbFuncion.Controls.Add(this.txtXa);
            this.gpbFuncion.Controls.Add(this.label4);
            this.gpbFuncion.Controls.Add(this.label3);
            this.gpbFuncion.Controls.Add(this.label2);
            this.gpbFuncion.Controls.Add(this.label1);
            this.gpbFuncion.Controls.Add(this.btnCalcular);
            this.gpbFuncion.Controls.Add(this.txtCoeficienteD);
            this.gpbFuncion.Controls.Add(this.txtCoeficienteC);
            this.gpbFuncion.Controls.Add(this.txtCoeficienteB);
            this.gpbFuncion.Controls.Add(this.txtCoeficienteA);
            this.gpbFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncion.Location = new System.Drawing.Point(26, 113);
            this.gpbFuncion.Name = "gpbFuncion";
            this.gpbFuncion.Size = new System.Drawing.Size(300, 618);
            this.gpbFuncion.TabIndex = 1;
            this.gpbFuncion.TabStop = false;
            this.gpbFuncion.Text = "DATOS DE FUNCIÓN";
            // 
            // txtCoeficienteA
            // 
            this.txtCoeficienteA.Location = new System.Drawing.Point(122, 105);
            this.txtCoeficienteA.Name = "txtCoeficienteA";
            this.txtCoeficienteA.Size = new System.Drawing.Size(80, 29);
            this.txtCoeficienteA.TabIndex = 2;
            // 
            // txtCoeficienteB
            // 
            this.txtCoeficienteB.Location = new System.Drawing.Point(122, 155);
            this.txtCoeficienteB.Name = "txtCoeficienteB";
            this.txtCoeficienteB.Size = new System.Drawing.Size(80, 29);
            this.txtCoeficienteB.TabIndex = 3;
            // 
            // txtCoeficienteC
            // 
            this.txtCoeficienteC.Location = new System.Drawing.Point(122, 212);
            this.txtCoeficienteC.Name = "txtCoeficienteC";
            this.txtCoeficienteC.Size = new System.Drawing.Size(80, 29);
            this.txtCoeficienteC.TabIndex = 4;
            // 
            // txtCoeficienteD
            // 
            this.txtCoeficienteD.Location = new System.Drawing.Point(122, 271);
            this.txtCoeficienteD.Name = "txtCoeficienteD";
            this.txtCoeficienteD.Size = new System.Drawing.Size(80, 29);
            this.txtCoeficienteD.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(122, 558);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "D";
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(122, 334);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(80, 29);
            this.txtXa.TabIndex = 2;
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(122, 376);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(80, 29);
            this.txtXb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Xb";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(122, 437);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(80, 29);
            this.txtError.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "e";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Location = new System.Drawing.Point(109, 504);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(100, 29);
            this.txtRaiz.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 80);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "MÉTODO DE FALSA POSICIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "TABLA DE ITERACIONES";
            // 
            // FrmFalsaPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbFuncion);
            this.Controls.Add(this.dtgIteraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFalsaPosicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFalsaPosicion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgIteraciones)).EndInit();
            this.gpbFuncion.ResumeLayout(false);
            this.gpbFuncion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgIteraciones;
        private System.Windows.Forms.GroupBox gpbFuncion;
        private System.Windows.Forms.TextBox txtCoeficienteD;
        private System.Windows.Forms.TextBox txtCoeficienteC;
        private System.Windows.Forms.TextBox txtCoeficienteB;
        private System.Windows.Forms.TextBox txtCoeficienteA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXb;
        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}