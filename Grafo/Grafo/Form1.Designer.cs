namespace Grafo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVertice = new System.Windows.Forms.TextBox();
            this.btnInsertarVertice = new System.Windows.Forms.Button();
            this.lstViewVertices = new System.Windows.Forms.ListView();
            this.btnEliminarVertice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerticeX = new System.Windows.Forms.TextBox();
            this.btnInsertarArco = new System.Windows.Forms.Button();
            this.lstViewArcos = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerticeY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vertice:";
            // 
            // txtVertice
            // 
            this.txtVertice.Location = new System.Drawing.Point(90, 24);
            this.txtVertice.Margin = new System.Windows.Forms.Padding(2);
            this.txtVertice.Name = "txtVertice";
            this.txtVertice.Size = new System.Drawing.Size(84, 20);
            this.txtVertice.TabIndex = 1;
            // 
            // btnInsertarVertice
            // 
            this.btnInsertarVertice.Location = new System.Drawing.Point(211, 20);
            this.btnInsertarVertice.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarVertice.Name = "btnInsertarVertice";
            this.btnInsertarVertice.Size = new System.Drawing.Size(119, 25);
            this.btnInsertarVertice.TabIndex = 2;
            this.btnInsertarVertice.Text = "Insertar vértice";
            this.btnInsertarVertice.UseVisualStyleBackColor = true;
            this.btnInsertarVertice.Click += new System.EventHandler(this.btnInsertarVertice_Click);
            // 
            // lstViewVertices
            // 
            this.lstViewVertices.HideSelection = false;
            this.lstViewVertices.Location = new System.Drawing.Point(17, 71);
            this.lstViewVertices.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewVertices.Name = "lstViewVertices";
            this.lstViewVertices.Size = new System.Drawing.Size(471, 73);
            this.lstViewVertices.TabIndex = 4;
            this.lstViewVertices.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarVertice
            // 
            this.btnEliminarVertice.Location = new System.Drawing.Point(356, 20);
            this.btnEliminarVertice.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarVertice.Name = "btnEliminarVertice";
            this.btnEliminarVertice.Size = new System.Drawing.Size(119, 25);
            this.btnEliminarVertice.TabIndex = 5;
            this.btnEliminarVertice.Text = "Eliminar vértice";
            this.btnEliminarVertice.UseVisualStyleBackColor = true;
            this.btnEliminarVertice.Click += new System.EventHandler(this.btnEliminarVertice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarVertice);
            this.groupBox1.Controls.Add(this.lstViewVertices);
            this.groupBox1.Controls.Add(this.btnInsertarVertice);
            this.groupBox1.Controls.Add(this.txtVertice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(512, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar y mostrar vértice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vertice x:";
            // 
            // txtVerticeX
            // 
            this.txtVerticeX.Location = new System.Drawing.Point(68, 28);
            this.txtVerticeX.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerticeX.Name = "txtVerticeX";
            this.txtVerticeX.Size = new System.Drawing.Size(84, 20);
            this.txtVerticeX.TabIndex = 1;
            // 
            // btnInsertarArco
            // 
            this.btnInsertarArco.Location = new System.Drawing.Point(334, 26);
            this.btnInsertarArco.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarArco.Name = "btnInsertarArco";
            this.btnInsertarArco.Size = new System.Drawing.Size(119, 25);
            this.btnInsertarArco.TabIndex = 2;
            this.btnInsertarArco.Text = "Insertar arco";
            this.btnInsertarArco.UseVisualStyleBackColor = true;
            this.btnInsertarArco.Click += new System.EventHandler(this.btnInsertarArco_Click);
            // 
            // lstViewArcos
            // 
            this.lstViewArcos.HideSelection = false;
            this.lstViewArcos.Location = new System.Drawing.Point(17, 71);
            this.lstViewArcos.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewArcos.Name = "lstViewArcos";
            this.lstViewArcos.Size = new System.Drawing.Size(471, 73);
            this.lstViewArcos.TabIndex = 4;
            this.lstViewArcos.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vertice y:";
            // 
            // txtVerticeY
            // 
            this.txtVerticeY.Location = new System.Drawing.Point(226, 29);
            this.txtVerticeY.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerticeY.Name = "txtVerticeY";
            this.txtVerticeY.Size = new System.Drawing.Size(84, 20);
            this.txtVerticeY.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVerticeY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstViewArcos);
            this.groupBox2.Controls.Add(this.btnInsertarArco);
            this.groupBox2.Controls.Add(this.txtVerticeX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(512, 168);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar y mostrar arco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVertice;
        private System.Windows.Forms.Button btnInsertarVertice;
        private System.Windows.Forms.ListView lstViewVertices;
        private System.Windows.Forms.Button btnEliminarVertice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerticeX;
        private System.Windows.Forms.Button btnInsertarArco;
        private System.Windows.Forms.ListView lstViewArcos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVerticeY;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

