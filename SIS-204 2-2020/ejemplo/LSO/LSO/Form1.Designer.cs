namespace LSO
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListView();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnImpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(403, 54);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(163, 45);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "INSERTAR_ORDENADO";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "elementos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(102, 67);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(242, 20);
            this.txtElement.TabIndex = 2;
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(86, 144);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(305, 65);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(430, 105);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(136, 44);
            this.btnPar.TabIndex = 4;
            this.btnPar.Text = "cant_de_pares";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnImpar
            // 
            this.btnImpar.Location = new System.Drawing.Point(430, 165);
            this.btnImpar.Name = "btnImpar";
            this.btnImpar.Size = new System.Drawing.Size(136, 44);
            this.btnImpar.TabIndex = 5;
            this.btnImpar.Text = "cant_de_impares";
            this.btnImpar.UseVisualStyleBackColor = true;
            this.btnImpar.Click += new System.EventHandler(this.btnImpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 261);
            this.Controls.Add(this.btnImpar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnImpar;
    }
}

