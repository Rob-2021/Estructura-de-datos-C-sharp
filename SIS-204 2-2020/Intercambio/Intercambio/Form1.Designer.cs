namespace Intercambio
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
            this.lstView = new System.Windows.Forms.ListView();
            this.txtElemento1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento2 = new System.Windows.Forms.TextBox();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this.lstView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento 1:";
            // 
            // lstView
            // 
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(46, 183);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(428, 57);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // txtElemento1
            // 
            this.txtElemento1.Location = new System.Drawing.Point(139, 58);
            this.txtElemento1.Name = "txtElemento1";
            this.txtElemento1.Size = new System.Drawing.Size(308, 20);
            this.txtElemento1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elemento 2:";
            // 
            // txtElemento2
            // 
            this.txtElemento2.Location = new System.Drawing.Point(139, 113);
            this.txtElemento2.Name = "txtElemento2";
            this.txtElemento2.Size = new System.Drawing.Size(308, 20);
            this.txtElemento2.TabIndex = 4;
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Location = new System.Drawing.Point(529, 46);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(108, 43);
            this.btnInsertar1.TabIndex = 5;
            this.btnInsertar1.Text = "Insertar 1";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(529, 113);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(108, 43);
            this.btnInsertar2.TabIndex = 6;
            this.btnInsertar2.Text = "Insertar 2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(544, 216);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(107, 50);
            this.btnIntercambiar.TabIndex = 7;
            this.btnIntercambiar.Text = "Intercambiar";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
            // 
            // lstView2
            // 
            this.lstView2.HideSelection = false;
            this.lstView2.Location = new System.Drawing.Point(46, 264);
            this.lstView2.Name = "lstView2";
            this.lstView2.Size = new System.Drawing.Size(428, 65);
            this.lstView2.TabIndex = 8;
            this.lstView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstView2);
            this.Controls.Add(this.btnIntercambiar);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnInsertar1);
            this.Controls.Add(this.txtElemento2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtElemento1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.TextBox txtElemento1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento2;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnIntercambiar;
        private System.Windows.Forms.ListView lstView2;
    }
}

