namespace LSECircular
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
            this.lstListaCircular = new System.Windows.Forms.ListView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListaCircular
            // 
            this.lstListaCircular.HideSelection = false;
            this.lstListaCircular.Location = new System.Drawing.Point(35, 115);
            this.lstListaCircular.Name = "lstListaCircular";
            this.lstListaCircular.Size = new System.Drawing.Size(641, 95);
            this.lstListaCircular.TabIndex = 13;
            this.lstListaCircular.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(565, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(438, 62);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(101, 31);
            this.btnInsertar2.TabIndex = 11;
            this.btnInsertar2.Text = "Insertar 2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Location = new System.Drawing.Point(307, 62);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(101, 31);
            this.btnInsertar1.TabIndex = 10;
            this.btnInsertar1.Text = "Insertar 1";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(110, 68);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(152, 20);
            this.txtElemento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Elemento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Simplemente Enlazada Circular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 240);
            this.Controls.Add(this.lstListaCircular);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnInsertar1);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstListaCircular;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

