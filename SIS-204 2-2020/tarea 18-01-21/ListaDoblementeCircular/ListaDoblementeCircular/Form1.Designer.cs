namespace ListaDoblementeCircular
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
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.listMOSTRAR = new System.Windows.Forms.ListView();
            this.textELEMENTO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnINSERTAR
            // 
            this.btnINSERTAR.Location = new System.Drawing.Point(188, 67);
            this.btnINSERTAR.Name = "btnINSERTAR";
            this.btnINSERTAR.Size = new System.Drawing.Size(75, 23);
            this.btnINSERTAR.TabIndex = 0;
            this.btnINSERTAR.Text = "INSERTAR";
            this.btnINSERTAR.UseVisualStyleBackColor = true;
            this.btnINSERTAR.Click += new System.EventHandler(this.btnINSERTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(297, 66);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 1;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // listMOSTRAR
            // 
            this.listMOSTRAR.Location = new System.Drawing.Point(51, 139);
            this.listMOSTRAR.Name = "listMOSTRAR";
            this.listMOSTRAR.Size = new System.Drawing.Size(321, 97);
            this.listMOSTRAR.TabIndex = 2;
            this.listMOSTRAR.UseCompatibleStateImageBehavior = false;
            // 
            // textELEMENTO
            // 
            this.textELEMENTO.Location = new System.Drawing.Point(51, 70);
            this.textELEMENTO.Name = "textELEMENTO";
            this.textELEMENTO.Size = new System.Drawing.Size(100, 20);
            this.textELEMENTO.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 293);
            this.Controls.Add(this.textELEMENTO);
            this.Controls.Add(this.listMOSTRAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnINSERTAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnINSERTAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.ListView listMOSTRAR;
        private System.Windows.Forms.TextBox textELEMENTO;
    }
}

