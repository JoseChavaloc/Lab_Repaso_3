namespace Lab_Repaso_3
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
            this.btnPropietario = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPropietario
            // 
            this.btnPropietario.Location = new System.Drawing.Point(307, 66);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(161, 58);
            this.btnPropietario.TabIndex = 0;
            this.btnPropietario.Text = "REGISTRAR PROPIETARIO";
            this.btnPropietario.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(307, 301);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(168, 58);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "IR A REPORTES";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Location = new System.Drawing.Point(307, 180);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(172, 58);
            this.btnPropiedad.TabIndex = 2;
            this.btnPropiedad.Text = "REGISTRAR PROPIEDAD";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPropiedad);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnPropietario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnPropiedad;
    }
}

