namespace Encapsulacion
{
    partial class FrmDetalleEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Posición Empleado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Edad Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Empleado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(75, 223);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(142, 38);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Cerrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmDetalleEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FrmDetalleEmpleado";
            this.Text = "FrmDetalleEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label4;
        public Label label3;
        public Label label2;
        public Button btnEnviar;
    }
}