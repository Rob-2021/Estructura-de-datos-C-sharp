namespace Pregunta_5_Lista_triple
{
    partial class btnConcatenar
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
            this.txtElemento1 = new System.Windows.Forms.TextBox();
            this.txtElemento2 = new System.Windows.Forms.TextBox();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.lstElemento1 = new System.Windows.Forms.ListView();
            this.lstElemento2 = new System.Windows.Forms.ListView();
            this.lstElemento3 = new System.Windows.Forms.ListView();
            this.lstElemento4 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento 2:";
            // 
            // txtElemento1
            // 
            this.txtElemento1.Location = new System.Drawing.Point(124, 36);
            this.txtElemento1.Name = "txtElemento1";
            this.txtElemento1.Size = new System.Drawing.Size(145, 20);
            this.txtElemento1.TabIndex = 2;
            // 
            // txtElemento2
            // 
            this.txtElemento2.Location = new System.Drawing.Point(124, 82);
            this.txtElemento2.Name = "txtElemento2";
            this.txtElemento2.Size = new System.Drawing.Size(145, 20);
            this.txtElemento2.TabIndex = 3;
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Location = new System.Drawing.Point(336, 36);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(109, 25);
            this.btnInsertar1.TabIndex = 4;
            this.btnInsertar1.Text = "Insertar 1";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(336, 89);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(109, 25);
            this.btnInsertar2.TabIndex = 5;
            this.btnInsertar2.Text = "Insertar 2";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // lstElemento1
            // 
            this.lstElemento1.HideSelection = false;
            this.lstElemento1.Location = new System.Drawing.Point(40, 149);
            this.lstElemento1.Name = "lstElemento1";
            this.lstElemento1.Size = new System.Drawing.Size(405, 49);
            this.lstElemento1.TabIndex = 6;
            this.lstElemento1.UseCompatibleStateImageBehavior = false;
            // 
            // lstElemento2
            // 
            this.lstElemento2.HideSelection = false;
            this.lstElemento2.Location = new System.Drawing.Point(40, 226);
            this.lstElemento2.Name = "lstElemento2";
            this.lstElemento2.Size = new System.Drawing.Size(405, 49);
            this.lstElemento2.TabIndex = 7;
            this.lstElemento2.UseCompatibleStateImageBehavior = false;
            // 
            // lstElemento3
            // 
            this.lstElemento3.HideSelection = false;
            this.lstElemento3.Location = new System.Drawing.Point(40, 303);
            this.lstElemento3.Name = "lstElemento3";
            this.lstElemento3.Size = new System.Drawing.Size(405, 49);
            this.lstElemento3.TabIndex = 8;
            this.lstElemento3.UseCompatibleStateImageBehavior = false;
            // 
            // lstElemento4
            // 
            this.lstElemento4.HideSelection = false;
            this.lstElemento4.Location = new System.Drawing.Point(40, 380);
            this.lstElemento4.Name = "lstElemento4";
            this.lstElemento4.Size = new System.Drawing.Size(405, 49);
            this.lstElemento4.TabIndex = 9;
            this.lstElemento4.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Concatenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConcatenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstElemento4);
            this.Controls.Add(this.lstElemento3);
            this.Controls.Add(this.lstElemento2);
            this.Controls.Add(this.lstElemento1);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnInsertar1);
            this.Controls.Add(this.txtElemento2);
            this.Controls.Add(this.txtElemento1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btnConcatenar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento1;
        private System.Windows.Forms.TextBox txtElemento2;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.ListView lstElemento1;
        private System.Windows.Forms.ListView lstElemento2;
        private System.Windows.Forms.ListView lstElemento3;
        private System.Windows.Forms.ListView lstElemento4;
        private System.Windows.Forms.Button button1;
    }
}

