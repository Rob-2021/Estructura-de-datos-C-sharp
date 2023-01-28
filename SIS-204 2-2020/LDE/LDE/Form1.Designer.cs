namespace LDE
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
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertarOrdenado = new System.Windows.Forms.Button();
            this.lstListaDoble = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(331, 75);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(90, 36);
            this.btnInsertarCola.TabIndex = 0;
            this.btnInsertarCola.Text = "Insertar como cola";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elemento";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(98, 80);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(195, 20);
            this.txtElemento.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(569, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertarOrdenado
            // 
            this.btnInsertarOrdenado.Location = new System.Drawing.Point(451, 75);
            this.btnInsertarOrdenado.Name = "btnInsertarOrdenado";
            this.btnInsertarOrdenado.Size = new System.Drawing.Size(90, 36);
            this.btnInsertarOrdenado.TabIndex = 6;
            this.btnInsertarOrdenado.Text = "Insertar Ordenado";
            this.btnInsertarOrdenado.UseVisualStyleBackColor = true;
            this.btnInsertarOrdenado.Click += new System.EventHandler(this.btnInsertarOrdenado_Click);
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.HideSelection = false;
            this.lstListaDoble.Location = new System.Drawing.Point(31, 166);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(628, 162);
            this.lstListaDoble.TabIndex = 7;
            this.lstListaDoble.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 381);
            this.Controls.Add(this.lstListaDoble);
            this.Controls.Add(this.btnInsertarOrdenado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertarOrdenado;
        private System.Windows.Forms.ListView lstListaDoble;
    }
}

