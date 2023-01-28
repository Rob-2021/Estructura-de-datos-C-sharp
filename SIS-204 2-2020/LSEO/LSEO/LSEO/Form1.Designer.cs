namespace LSEO
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
            this.list = new System.Windows.Forms.ListView();
            this.btnOrdenado = new System.Windows.Forms.Button();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(42, 109);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(368, 133);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // btnOrdenado
            // 
            this.btnOrdenado.Location = new System.Drawing.Point(386, 35);
            this.btnOrdenado.Name = "btnOrdenado";
            this.btnOrdenado.Size = new System.Drawing.Size(104, 39);
            this.btnOrdenado.TabIndex = 1;
            this.btnOrdenado.Text = "INSERTAR ORDENADO";
            this.btnOrdenado.UseVisualStyleBackColor = true;
            this.btnOrdenado.Click += new System.EventHandler(this.btnOrdenado_Click);
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(97, 45);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(218, 20);
            this.txtElement.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "elementos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.btnOrdenado);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button btnOrdenado;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label1;
    }
}

