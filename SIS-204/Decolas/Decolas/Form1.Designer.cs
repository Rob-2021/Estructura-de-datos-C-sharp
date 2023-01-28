namespace Decolas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInsertarDelante = new System.Windows.Forms.Button();
            this.btnEliminarDetras = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListView();
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decolas e invertir cola";
            // 
            // txtElemento
            // 
            this.txtElemento.AutoSize = true;
            this.txtElemento.Location = new System.Drawing.Point(13, 107);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(51, 13);
            this.txtElemento.TabIndex = 1;
            this.txtElemento.Text = "Elemento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnInsertarDelante
            // 
            this.btnInsertarDelante.Location = new System.Drawing.Point(285, 107);
            this.btnInsertarDelante.Name = "btnInsertarDelante";
            this.btnInsertarDelante.Size = new System.Drawing.Size(135, 46);
            this.btnInsertarDelante.TabIndex = 3;
            this.btnInsertarDelante.Text = "Insertar por Delante";
            this.btnInsertarDelante.UseVisualStyleBackColor = true;
            this.btnInsertarDelante.Click += new System.EventHandler(this.btnInsertarDelante_Click);
            // 
            // btnEliminarDetras
            // 
            this.btnEliminarDetras.Location = new System.Drawing.Point(448, 107);
            this.btnEliminarDetras.Name = "btnEliminarDetras";
            this.btnEliminarDetras.Size = new System.Drawing.Size(130, 46);
            this.btnEliminarDetras.TabIndex = 4;
            this.btnEliminarDetras.Text = "Eliminar por detras";
            this.btnEliminarDetras.UseVisualStyleBackColor = true;
            this.btnEliminarDetras.Click += new System.EventHandler(this.btnEliminarDetras_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(615, 107);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(134, 46);
            this.btnInvertir.TabIndex = 5;
            this.btnInvertir.Text = "Invertir Cola";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(86, 275);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(590, 128);
            this.lstCola.TabIndex = 6;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(285, 190);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(135, 57);
            this.btnInsertarCola.TabIndex = 7;
            this.btnInsertarCola.Text = "insertar Cola";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarCola);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnEliminarDetras);
            this.Controls.Add(this.btnInsertarDelante);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtElemento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInsertarDelante;
        private System.Windows.Forms.Button btnEliminarDetras;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.Button btnInsertarCola;
    }
}

