namespace Pregunta_6_ColaYPila
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
            this.btnEliminarAtras = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstElementos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lstElementos2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnEliminarAtras
            // 
            this.btnEliminarAtras.Location = new System.Drawing.Point(480, 35);
            this.btnEliminarAtras.Name = "btnEliminarAtras";
            this.btnEliminarAtras.Size = new System.Drawing.Size(124, 43);
            this.btnEliminarAtras.TabIndex = 9;
            this.btnEliminarAtras.Text = "Intercambio";
            this.btnEliminarAtras.UseVisualStyleBackColor = true;
            this.btnEliminarAtras.Click += new System.EventHandler(this.btnEliminarAtras_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(320, 35);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(124, 43);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertarDelante_Click);
            // 
            // lstElementos
            // 
            this.lstElementos.HideSelection = false;
            this.lstElementos.Location = new System.Drawing.Point(51, 187);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(553, 70);
            this.lstElementos.TabIndex = 7;
            this.lstElementos.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(100, 35);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(150, 20);
            this.txtElemento.TabIndex = 5;
            // 
            // lstElementos2
            // 
            this.lstElementos2.HideSelection = false;
            this.lstElementos2.Location = new System.Drawing.Point(51, 293);
            this.lstElementos2.Name = "lstElementos2";
            this.lstElementos2.Size = new System.Drawing.Size(553, 70);
            this.lstElementos2.TabIndex = 10;
            this.lstElementos2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 459);
            this.Controls.Add(this.lstElementos2);
            this.Controls.Add(this.btnEliminarAtras);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElemento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarAtras;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListView lstElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.ListView lstElementos2;
    }
}

