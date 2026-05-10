namespace Proyecto_MetodosNumericos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.gPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbFalsaPosicion = new System.Windows.Forms.ToolStripButton();
            this.tsbSecante = new System.Windows.Forms.ToolStripButton();
            this.tsbNewtonR = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.gPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFalsaPosicion,
            this.tsbSecante,
            this.tsbNewtonR,
            this.tsbSalir});
            this.tsMenu.Location = new System.Drawing.Point(0, 385);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 65);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "CUADRO DE HERRAMIENTAS";
            // 
            // gPanel
            // 
            this.gPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.gPanel.Controls.Add(this.label1);
            this.gPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gPanel.Location = new System.Drawing.Point(0, 0);
            this.gPanel.Name = "gPanel";
            this.gPanel.Size = new System.Drawing.Size(800, 70);
            this.gPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE MÉTODOS NUMERICOS";
            // 
            // tsbFalsaPosicion
            // 
            this.tsbFalsaPosicion.AutoSize = false;
            this.tsbFalsaPosicion.BackColor = System.Drawing.Color.Transparent;
            this.tsbFalsaPosicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbFalsaPosicion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFalsaPosicion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbFalsaPosicion.Image = global::Proyecto_MetodosNumericos.Properties.Resources.icons8_vista_ortogonal_34;
            this.tsbFalsaPosicion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFalsaPosicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFalsaPosicion.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsbFalsaPosicion.Name = "tsbFalsaPosicion";
            this.tsbFalsaPosicion.Size = new System.Drawing.Size(60, 60);
            this.tsbFalsaPosicion.Text = "M. Falsa Posción";
            // 
            // tsbSecante
            // 
            this.tsbSecante.AutoSize = false;
            this.tsbSecante.BackColor = System.Drawing.Color.Transparent;
            this.tsbSecante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSecante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbSecante.Image = global::Proyecto_MetodosNumericos.Properties.Resources.icons8_vista_ortogonal_34__1_;
            this.tsbSecante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSecante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSecante.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tsbSecante.Name = "tsbSecante";
            this.tsbSecante.Size = new System.Drawing.Size(60, 60);
            this.tsbSecante.Text = "M. Secante";
            // 
            // tsbNewtonR
            // 
            this.tsbNewtonR.AutoSize = false;
            this.tsbNewtonR.BackColor = System.Drawing.Color.Transparent;
            this.tsbNewtonR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewtonR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbNewtonR.Image = global::Proyecto_MetodosNumericos.Properties.Resources.icons8_vista_ortogonal_34__2_;
            this.tsbNewtonR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNewtonR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewtonR.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tsbNewtonR.Name = "tsbNewtonR";
            this.tsbNewtonR.Size = new System.Drawing.Size(60, 60);
            this.tsbNewtonR.Text = "M. Newton Raphson";
            // 
            // tsbSalir
            // 
            this.tsbSalir.AutoSize = false;
            this.tsbSalir.BackColor = System.Drawing.Color.Transparent;
            this.tsbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbSalir.Image = global::Proyecto_MetodosNumericos.Properties.Resources.Open_Door_white;
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(60, 60);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gPanel);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gPanel.ResumeLayout(false);
            this.gPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbFalsaPosicion;
        private System.Windows.Forms.ToolStripButton tsbSecante;
        private System.Windows.Forms.ToolStripButton tsbNewtonR;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel gPanel;
        private System.Windows.Forms.Label label1;
    }
}

