namespace Pregunta_5
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.lstElemento = new System.Windows.Forms.ListView();
            this.lstGenerarLista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(112, 69);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(149, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(298, 66);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 38);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnGenerarLista
            // 
            this.btnGenerarLista.Location = new System.Drawing.Point(447, 66);
            this.btnGenerarLista.Name = "btnGenerarLista";
            this.btnGenerarLista.Size = new System.Drawing.Size(108, 38);
            this.btnGenerarLista.TabIndex = 3;
            this.btnGenerarLista.Text = "Generar Lista";
            this.btnGenerarLista.UseVisualStyleBackColor = true;
            // 
            // lstElemento
            // 
            this.lstElemento.HideSelection = false;
            this.lstElemento.Location = new System.Drawing.Point(54, 131);
            this.lstElemento.Name = "lstElemento";
            this.lstElemento.Size = new System.Drawing.Size(562, 97);
            this.lstElemento.TabIndex = 4;
            this.lstElemento.UseCompatibleStateImageBehavior = false;
            // 
            // lstGenerarLista
            // 
            this.lstGenerarLista.HideSelection = false;
            this.lstGenerarLista.Location = new System.Drawing.Point(54, 264);
            this.lstGenerarLista.Name = "lstGenerarLista";
            this.lstGenerarLista.Size = new System.Drawing.Size(562, 97);
            this.lstGenerarLista.TabIndex = 5;
            this.lstGenerarLista.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.lstGenerarLista);
            this.Controls.Add(this.lstElemento);
            this.Controls.Add(this.btnGenerarLista);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnGenerarLista;
        private System.Windows.Forms.ListView lstElemento;
        private System.Windows.Forms.ListView lstGenerarLista;
    }
}

