namespace Arbol_Binario
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearLexicografico = new System.Windows.Forms.Button();
            this.lstViewArbol = new System.Windows.Forms.ListView();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(92, 56);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(120, 20);
            this.txtElemento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento:";
            // 
            // btnCrearLexicografico
            // 
            this.btnCrearLexicografico.Location = new System.Drawing.Point(273, 56);
            this.btnCrearLexicografico.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearLexicografico.Name = "btnCrearLexicografico";
            this.btnCrearLexicografico.Size = new System.Drawing.Size(280, 28);
            this.btnCrearLexicografico.TabIndex = 6;
            this.btnCrearLexicografico.Text = "Crear arbol lexicografico";
            this.btnCrearLexicografico.UseVisualStyleBackColor = true;
            this.btnCrearLexicografico.Click += new System.EventHandler(this.btnCrearLexicografico_Click);
            // 
            // lstViewArbol
            // 
            this.lstViewArbol.HideSelection = false;
            this.lstViewArbol.Location = new System.Drawing.Point(23, 165);
            this.lstViewArbol.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewArbol.Name = "lstViewArbol";
            this.lstViewArbol.Size = new System.Drawing.Size(548, 215);
            this.lstViewArbol.TabIndex = 7;
            this.lstViewArbol.UseCompatibleStateImageBehavior = false;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(330, 112);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(144, 28);
            this.btnPreOrden.TabIndex = 8;
            this.btnPreOrden.Text = "Calcular Suma";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 420);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.lstViewArbol);
            this.Controls.Add(this.btnCrearLexicografico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElemento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearLexicografico;
        private System.Windows.Forms.ListView lstViewArbol;
        private System.Windows.Forms.Button btnPreOrden;
    }
}

