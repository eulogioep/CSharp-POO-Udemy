namespace Encapsulacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdadEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicionEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(172, 277);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(142, 38);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.Location = new System.Drawing.Point(284, 77);
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.Size = new System.Drawing.Size(144, 23);
            this.txtEmpleadoID.TabIndex = 2;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(284, 118);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(144, 23);
            this.txtNombreEmpleado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEdadEmpleado
            // 
            this.txtEdadEmpleado.Location = new System.Drawing.Point(284, 168);
            this.txtEdadEmpleado.Name = "txtEdadEmpleado";
            this.txtEdadEmpleado.Size = new System.Drawing.Size(144, 23);
            this.txtEdadEmpleado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad Empleado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPosicionEmpleado
            // 
            this.txtPosicionEmpleado.Location = new System.Drawing.Point(284, 217);
            this.txtPosicionEmpleado.Name = "txtPosicionEmpleado";
            this.txtPosicionEmpleado.Size = new System.Drawing.Size(144, 23);
            this.txtPosicionEmpleado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posición Empleado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 398);
            this.Controls.Add(this.txtPosicionEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdadEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpleadoID);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public System.Windows.Forms.Label label1;
        private Button btnEnviar;
        private TextBox txtEmpleadoID;
        private TextBox txtNombreEmpleado;
        public System.Windows.Forms.Label label2;
        private TextBox txtEdadEmpleado;
        public System.Windows.Forms.Label label3;
        private TextBox txtPosicionEmpleado;
        public System.Windows.Forms.Label label4;
    }
}