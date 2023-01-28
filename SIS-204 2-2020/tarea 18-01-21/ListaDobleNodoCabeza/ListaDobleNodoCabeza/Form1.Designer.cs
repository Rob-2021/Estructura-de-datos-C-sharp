namespace ListaDobleNodoCabeza
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
            this.btnINSERTAR = new System.Windows.Forms.Button();
            this.listMOSTRAR = new System.Windows.Forms.ListView();
            this.textELEMENTO = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.textCABEZA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnINSERTAR
            // 
            this.btnINSERTAR.Location = new System.Drawing.Point(148, 54);
            this.btnINSERTAR.Name = "btnINSERTAR";
            this.btnINSERTAR.Size = new System.Drawing.Size(75, 23);
            this.btnINSERTAR.TabIndex = 0;
            this.btnINSERTAR.Text = "INSERTAR";
            this.btnINSERTAR.UseVisualStyleBackColor = true;
            this.btnINSERTAR.Click += new System.EventHandler(this.btnINSERTAR_Click);
            // 
            // listMOSTRAR
            // 
            this.listMOSTRAR.Location = new System.Drawing.Point(30, 106);
            this.listMOSTRAR.Name = "listMOSTRAR";
            this.listMOSTRAR.Size = new System.Drawing.Size(288, 97);
            this.listMOSTRAR.TabIndex = 1;
            this.listMOSTRAR.UseCompatibleStateImageBehavior = false;
            // 
            // textELEMENTO
            // 
            this.textELEMENTO.Location = new System.Drawing.Point(30, 56);
            this.textELEMENTO.Name = "textELEMENTO";
            this.textELEMENTO.Size = new System.Drawing.Size(100, 20);
            this.textELEMENTO.TabIndex = 2;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(243, 53);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 3;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // textCABEZA
            // 
            this.textCABEZA.Location = new System.Drawing.Point(148, 235);
            this.textCABEZA.Name = "textCABEZA";
            this.textCABEZA.ReadOnly = true;
            this.textCABEZA.Size = new System.Drawing.Size(53, 20);
            this.textCABEZA.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 338);
            this.Controls.Add(this.textCABEZA);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.textELEMENTO);
            this.Controls.Add(this.listMOSTRAR);
            this.Controls.Add(this.btnINSERTAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnINSERTAR;
        private System.Windows.Forms.ListView listMOSTRAR;
        private System.Windows.Forms.TextBox textELEMENTO;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.TextBox textCABEZA;
    }
}

