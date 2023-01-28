namespace LCCabeza
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lstListaCircular = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElementoCabeza = new System.Windows.Forms.TextBox();
            this.btninsertarcabeza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCabeza = new System.Windows.Forms.TextBox();
            this.lstListaCabeza = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Simplemente Enlazada Circular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(103, 75);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(152, 20);
            this.txtElemento.TabIndex = 2;
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Location = new System.Drawing.Point(298, 75);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(101, 31);
            this.btnInsertar1.TabIndex = 3;
            this.btnInsertar1.Text = "Insertar 1";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(429, 75);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(101, 31);
            this.btnInsertar2.TabIndex = 4;
            this.btnInsertar2.Text = "Insertar 2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(560, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lstListaCircular
            // 
            this.lstListaCircular.HideSelection = false;
            this.lstListaCircular.Location = new System.Drawing.Point(32, 130);
            this.lstListaCircular.Name = "lstListaCircular";
            this.lstListaCircular.Size = new System.Drawing.Size(629, 95);
            this.lstListaCircular.TabIndex = 6;
            this.lstListaCircular.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista Doblemente Enlazada Con Nodo Cabeza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(29, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elemento:";
            // 
            // txtElementoCabeza
            // 
            this.txtElementoCabeza.Location = new System.Drawing.Point(103, 301);
            this.txtElementoCabeza.Name = "txtElementoCabeza";
            this.txtElementoCabeza.Size = new System.Drawing.Size(152, 20);
            this.txtElementoCabeza.TabIndex = 9;
            // 
            // btninsertarcabeza
            // 
            this.btninsertarcabeza.Location = new System.Drawing.Point(298, 295);
            this.btninsertarcabeza.Name = "btninsertarcabeza";
            this.btninsertarcabeza.Size = new System.Drawing.Size(101, 31);
            this.btninsertarcabeza.TabIndex = 10;
            this.btninsertarcabeza.Text = "Insertar";
            this.btninsertarcabeza.UseVisualStyleBackColor = true;
            this.btninsertarcabeza.Click += new System.EventHandler(this.btninsertarcabeza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cabeza:";
            // 
            // txtCabeza
            // 
            this.txtCabeza.Location = new System.Drawing.Point(478, 301);
            this.txtCabeza.Name = "txtCabeza";
            this.txtCabeza.ReadOnly = true;
            this.txtCabeza.Size = new System.Drawing.Size(52, 20);
            this.txtCabeza.TabIndex = 12;
            this.txtCabeza.TextChanged += new System.EventHandler(this.txtCabeza_TextChanged);
            // 
            // lstListaCabeza
            // 
            this.lstListaCabeza.HideSelection = false;
            this.lstListaCabeza.Location = new System.Drawing.Point(32, 348);
            this.lstListaCabeza.Name = "lstListaCabeza";
            this.lstListaCabeza.Size = new System.Drawing.Size(629, 95);
            this.lstListaCabeza.TabIndex = 14;
            this.lstListaCabeza.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 478);
            this.Controls.Add(this.lstListaCabeza);
            this.Controls.Add(this.txtCabeza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btninsertarcabeza);
            this.Controls.Add(this.txtElementoCabeza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ListView lstListaCircular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElementoCabeza;
        private System.Windows.Forms.Button btninsertarcabeza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCabeza;
        private System.Windows.Forms.ListView lstListaCabeza;
    }
}

