namespace ListasEnlazadas
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
            this.lstViewPila = new System.Windows.Forms.ListView();
            this.lstViewPila2 = new System.Windows.Forms.ListView();
            this.btnMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(104, 28);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(144, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(298, 28);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(95, 33);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstViewPila
            // 
            this.lstViewPila.HideSelection = false;
            this.lstViewPila.Location = new System.Drawing.Point(87, 78);
            this.lstViewPila.Name = "lstViewPila";
            this.lstViewPila.Size = new System.Drawing.Size(215, 62);
            this.lstViewPila.TabIndex = 3;
            this.lstViewPila.UseCompatibleStateImageBehavior = false;
            // 
            // lstViewPila2
            // 
            this.lstViewPila2.HideSelection = false;
            this.lstViewPila2.Location = new System.Drawing.Point(87, 189);
            this.lstViewPila2.Name = "lstViewPila2";
            this.lstViewPila2.Size = new System.Drawing.Size(215, 64);
            this.lstViewPila2.TabIndex = 4;
            this.lstViewPila2.UseCompatibleStateImageBehavior = false;
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(396, 205);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(104, 37);
            this.btnMayor.TabIndex = 5;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 326);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.lstViewPila2);
            this.Controls.Add(this.lstViewPila);
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
        private System.Windows.Forms.ListView lstViewPila;
        private System.Windows.Forms.ListView lstViewPila2;
        private System.Windows.Forms.Button btnMayor;
    }
}

