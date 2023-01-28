namespace IntercambioElementos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento1 = new System.Windows.Forms.TextBox();
            this.txtElemento2 = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstViewPila = new System.Windows.Forms.ListView();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.lstViewPila2 = new System.Windows.Forms.ListView();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento 2:";
            // 
            // txtElemento1
            // 
            this.txtElemento1.Location = new System.Drawing.Point(136, 37);
            this.txtElemento1.Name = "txtElemento1";
            this.txtElemento1.Size = new System.Drawing.Size(123, 20);
            this.txtElemento1.TabIndex = 2;
            // 
            // txtElemento2
            // 
            this.txtElemento2.Location = new System.Drawing.Point(136, 74);
            this.txtElemento2.Name = "txtElemento2";
            this.txtElemento2.Size = new System.Drawing.Size(123, 20);
            this.txtElemento2.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(324, 33);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(87, 24);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar 1";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstViewPila
            // 
            this.lstViewPila.HideSelection = false;
            this.lstViewPila.Location = new System.Drawing.Point(41, 135);
            this.lstViewPila.Name = "lstViewPila";
            this.lstViewPila.Size = new System.Drawing.Size(289, 58);
            this.lstViewPila.TabIndex = 5;
            this.lstViewPila.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(324, 70);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(87, 24);
            this.btnInsertar2.TabIndex = 6;
            this.btnInsertar2.Text = "Insertar 2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // lstViewPila2
            // 
            this.lstViewPila2.HideSelection = false;
            this.lstViewPila2.Location = new System.Drawing.Point(41, 223);
            this.lstViewPila2.Name = "lstViewPila2";
            this.lstViewPila2.Size = new System.Drawing.Size(289, 67);
            this.lstViewPila2.TabIndex = 7;
            this.lstViewPila2.UseCompatibleStateImageBehavior = false;
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(366, 241);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(104, 37);
            this.btnIntercambiar.TabIndex = 8;
            this.btnIntercambiar.Text = "Intercambiar";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 418);
            this.Controls.Add(this.btnIntercambiar);
            this.Controls.Add(this.lstViewPila2);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.lstViewPila);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtElemento2);
            this.Controls.Add(this.txtElemento1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento1;
        private System.Windows.Forms.TextBox txtElemento2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListView lstViewPila;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.ListView lstViewPila2;
        private System.Windows.Forms.Button btnIntercambiar;
    }
}

