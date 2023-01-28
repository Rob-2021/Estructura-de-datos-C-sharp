namespace LDEPares_Impares
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstElemento = new System.Windows.Forms.ListView();
            this.txtPar = new System.Windows.Forms.TextBox();
            this.txtImpar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(102, 70);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(133, 20);
            this.txtElemento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(320, 66);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(104, 39);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstElemento
            // 
            this.lstElemento.HideSelection = false;
            this.lstElemento.Location = new System.Drawing.Point(36, 147);
            this.lstElemento.Name = "lstElemento";
            this.lstElemento.Size = new System.Drawing.Size(547, 127);
            this.lstElemento.TabIndex = 4;
            this.lstElemento.UseCompatibleStateImageBehavior = false;
            // 
            // txtPar
            // 
            this.txtPar.Location = new System.Drawing.Point(643, 164);
            this.txtPar.Name = "txtPar";
            this.txtPar.ReadOnly = true;
            this.txtPar.Size = new System.Drawing.Size(100, 20);
            this.txtPar.TabIndex = 5;
            // 
            // txtImpar
            // 
            this.txtImpar.Location = new System.Drawing.Point(643, 242);
            this.txtImpar.Name = "txtImpar";
            this.txtImpar.ReadOnly = true;
            this.txtImpar.Size = new System.Drawing.Size(100, 20);
            this.txtImpar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Par";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Impar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImpar);
            this.Controls.Add(this.txtPar);
            this.Controls.Add(this.lstElemento);
            this.Controls.Add(this.btnInsertar);
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
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListView lstElemento;
        private System.Windows.Forms.TextBox txtPar;
        private System.Windows.Forms.TextBox txtImpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

