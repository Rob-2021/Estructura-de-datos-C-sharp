namespace Herencia
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.btnAgregarPer = new System.Windows.Forms.Button();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.btnAgregarEmpl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carnet de identidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contrato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(156, 199);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(130, 20);
            this.txtContrato.TabIndex = 6;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(156, 145);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(130, 20);
            this.txtCI.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(156, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(130, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(156, 244);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(130, 20);
            this.txtsueldo.TabIndex = 9;
            // 
            // btnAgregarPer
            // 
            this.btnAgregarPer.Location = new System.Drawing.Point(395, 54);
            this.btnAgregarPer.Name = "btnAgregarPer";
            this.btnAgregarPer.Size = new System.Drawing.Size(131, 41);
            this.btnAgregarPer.TabIndex = 10;
            this.btnAgregarPer.Text = "Agregar Persona";
            this.btnAgregarPer.UseVisualStyleBackColor = true;
            this.btnAgregarPer.Click += new System.EventHandler(this.btnAgregarPer_Click);
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(395, 134);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(131, 41);
            this.btnAgregarCli.TabIndex = 11;
            this.btnAgregarCli.Text = "Agregar Cliente";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // btnAgregarEmpl
            // 
            this.btnAgregarEmpl.Location = new System.Drawing.Point(395, 223);
            this.btnAgregarEmpl.Name = "btnAgregarEmpl";
            this.btnAgregarEmpl.Size = new System.Drawing.Size(131, 41);
            this.btnAgregarEmpl.TabIndex = 12;
            this.btnAgregarEmpl.Text = "Agregar Empleado";
            this.btnAgregarEmpl.UseVisualStyleBackColor = true;
            this.btnAgregarEmpl.Click += new System.EventHandler(this.btnAgregarEmpl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnAgregarEmpl);
            this.Controls.Add(this.btnAgregarCli);
            this.Controls.Add(this.btnAgregarPer);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Button btnAgregarPer;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.Button btnAgregarEmpl;
    }
}

