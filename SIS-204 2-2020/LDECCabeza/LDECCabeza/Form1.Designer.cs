namespace LDECCabeza
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
            this.lstListaCabeza = new System.Windows.Forms.ListView();
            this.txtCabeza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btninsertarcabeza = new System.Windows.Forms.Button();
            this.txtElementoCabeza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaCabeza
            // 
            this.lstListaCabeza.HideSelection = false;
            this.lstListaCabeza.Location = new System.Drawing.Point(20, 96);
            this.lstListaCabeza.Name = "lstListaCabeza";
            this.lstListaCabeza.Size = new System.Drawing.Size(629, 95);
            this.lstListaCabeza.TabIndex = 27;
            this.lstListaCabeza.UseCompatibleStateImageBehavior = false;
            // 
            // txtCabeza
            // 
            this.txtCabeza.Location = new System.Drawing.Point(597, 54);
            this.txtCabeza.Name = "txtCabeza";
            this.txtCabeza.ReadOnly = true;
            this.txtCabeza.Size = new System.Drawing.Size(52, 20);
            this.txtCabeza.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cabeza:";
            // 
            // btninsertarcabeza
            // 
            this.btninsertarcabeza.Location = new System.Drawing.Point(291, 44);
            this.btninsertarcabeza.Name = "btninsertarcabeza";
            this.btninsertarcabeza.Size = new System.Drawing.Size(101, 31);
            this.btninsertarcabeza.TabIndex = 24;
            this.btninsertarcabeza.Text = "Insertar";
            this.btninsertarcabeza.UseVisualStyleBackColor = true;
            this.btninsertarcabeza.Click += new System.EventHandler(this.btninsertarcabeza_Click);
            // 
            // txtElementoCabeza
            // 
            this.txtElementoCabeza.Location = new System.Drawing.Point(114, 50);
            this.txtElementoCabeza.Name = "txtElementoCabeza";
            this.txtElementoCabeza.Size = new System.Drawing.Size(152, 20);
            this.txtElementoCabeza.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(42, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Elemento:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(416, 44);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 242);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstListaCabeza);
            this.Controls.Add(this.txtCabeza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btninsertarcabeza);
            this.Controls.Add(this.txtElementoCabeza);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstListaCabeza;
        private System.Windows.Forms.TextBox txtCabeza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btninsertarcabeza;
        private System.Windows.Forms.TextBox txtElementoCabeza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
    }
}

