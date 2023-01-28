namespace Expresiones_Algebraicas
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
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnEvaluarExpresion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(56, 85);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(150, 20);
            this.txtExpresion.TabIndex = 0;
            // 
            // btnEvaluarExpresion
            // 
            this.btnEvaluarExpresion.Location = new System.Drawing.Point(289, 85);
            this.btnEvaluarExpresion.Name = "btnEvaluarExpresion";
            this.btnEvaluarExpresion.Size = new System.Drawing.Size(145, 33);
            this.btnEvaluarExpresion.TabIndex = 1;
            this.btnEvaluarExpresion.Text = "Evaluar Expresion";
            this.btnEvaluarExpresion.UseVisualStyleBackColor = true;
            this.btnEvaluarExpresion.Click += new System.EventHandler(this.btnEvaluarExpresion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evaluar expresiones aritmeticas o algebraicas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvaluarExpresion);
            this.Controls.Add(this.txtExpresion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnEvaluarExpresion;
        private System.Windows.Forms.Label label1;
    }
}

