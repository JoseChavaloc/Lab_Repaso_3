namespace Lab_Repaso_3
{
    partial class FormReporte
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOrdenCuota = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAltosBajos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(836, 37);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(214, 53);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "ORDENAR POR FECHA DE INGRESO";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnOrdenCuota
            // 
            this.btnOrdenCuota.Location = new System.Drawing.Point(836, 119);
            this.btnOrdenCuota.Name = "btnOrdenCuota";
            this.btnOrdenCuota.Size = new System.Drawing.Size(214, 51);
            this.btnOrdenCuota.TabIndex = 2;
            this.btnOrdenCuota.Text = "ORDENAR POR CUOTA DE MANTENIMIENTO DESCENDENTE";
            this.btnOrdenCuota.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "ORDENAR POR CUOTA DE MANTENIMIENTO ASCENDENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAltosBajos
            // 
            this.btnAltosBajos.Location = new System.Drawing.Point(836, 279);
            this.btnAltosBajos.Name = "btnAltosBajos";
            this.btnAltosBajos.Size = new System.Drawing.Size(214, 61);
            this.btnAltosBajos.TabIndex = 4;
            this.btnAltosBajos.Text = "MOSTRAR 3 MAS ALTOS Y 3 MAS BAJOS";
            this.btnAltosBajos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "MOSTRAR LA MAYOR CUOTA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAltosBajos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrdenCuota);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenCuota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAltosBajos;
        private System.Windows.Forms.Button button2;
    }
}