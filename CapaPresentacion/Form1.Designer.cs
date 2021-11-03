
namespace CapaPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtcodigoBarras = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMetodo4 = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo5 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombres.Location = new System.Drawing.Point(223, 48);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(274, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDireccion.Location = new System.Drawing.Point(223, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecio.Location = new System.Drawing.Point(223, 142);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(274, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtcodigoBarras
            // 
            this.txtcodigoBarras.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtcodigoBarras.Location = new System.Drawing.Point(223, 192);
            this.txtcodigoBarras.Name = "txtcodigoBarras";
            this.txtcodigoBarras.Size = new System.Drawing.Size(274, 20);
            this.txtcodigoBarras.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.Info;
            this.btnLeer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(445, 239);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(92, 53);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.SystemColors.Info;
            this.btnEscribir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.Location = new System.Drawing.Point(176, 239);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(92, 53);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(657, 239);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 53);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMetodo4
            // 
            this.btnMetodo4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo4.Location = new System.Drawing.Point(136, 384);
            this.btnMetodo4.Name = "btnMetodo4";
            this.btnMetodo4.Size = new System.Drawing.Size(85, 38);
            this.btnMetodo4.TabIndex = 5;
            this.btnMetodo4.Text = "Metodo 4 ( )";
            this.btnMetodo4.UseVisualStyleBackColor = false;
            this.btnMetodo4.Click += new System.EventHandler(this.btnMetodo4_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo1.Location = new System.Drawing.Point(136, 330);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(85, 38);
            this.btnMetodo1.TabIndex = 5;
            this.btnMetodo1.Text = "Metodo 1 ( )";
            this.btnMetodo1.UseVisualStyleBackColor = false;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo5
            // 
            this.btnMetodo5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo5.Location = new System.Drawing.Point(319, 384);
            this.btnMetodo5.Name = "btnMetodo5";
            this.btnMetodo5.Size = new System.Drawing.Size(85, 38);
            this.btnMetodo5.TabIndex = 5;
            this.btnMetodo5.Text = "Metodo 5 ( )";
            this.btnMetodo5.UseVisualStyleBackColor = false;
            this.btnMetodo5.Click += new System.EventHandler(this.btnMetodo5_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo2.Location = new System.Drawing.Point(319, 330);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(85, 38);
            this.btnMetodo2.TabIndex = 5;
            this.btnMetodo2.Text = "Metodo 2 ( )";
            this.btnMetodo2.UseVisualStyleBackColor = false;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo3.Location = new System.Drawing.Point(468, 330);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(85, 38);
            this.btnMetodo3.TabIndex = 5;
            this.btnMetodo3.Text = "Metodo 3 ( )";
            this.btnMetodo3.UseVisualStyleBackColor = false;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo5);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.btnMetodo4);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtcodigoBarras);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombres);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtcodigoBarras;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMetodo4;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo5;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
    }
}

