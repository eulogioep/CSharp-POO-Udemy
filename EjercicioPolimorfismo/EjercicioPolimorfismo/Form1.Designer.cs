
namespace EjercicioPolimorfismo
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnInfo1 = new System.Windows.Forms.Button();
            this.btnInfo2 = new System.Windows.Forms.Button();
            this.btnInfo3 = new System.Windows.Forms.Button();
            this.btnInfo4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(384, 390);
            this.txtBox.TabIndex = 0;
            // 
            // btnInfo1
            // 
            this.btnInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo1.Location = new System.Drawing.Point(453, 111);
            this.btnInfo1.Name = "btnInfo1";
            this.btnInfo1.Size = new System.Drawing.Size(122, 40);
            this.btnInfo1.TabIndex = 1;
            this.btnInfo1.Text = "1 Parámetro";
            this.btnInfo1.UseVisualStyleBackColor = true;
            this.btnInfo1.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnInfo2
            // 
            this.btnInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo2.Location = new System.Drawing.Point(581, 111);
            this.btnInfo2.Name = "btnInfo2";
            this.btnInfo2.Size = new System.Drawing.Size(122, 40);
            this.btnInfo2.TabIndex = 2;
            this.btnInfo2.Text = "2 Parámetro";
            this.btnInfo2.UseVisualStyleBackColor = true;
            this.btnInfo2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfo3
            // 
            this.btnInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo3.Location = new System.Drawing.Point(709, 111);
            this.btnInfo3.Name = "btnInfo3";
            this.btnInfo3.Size = new System.Drawing.Size(122, 40);
            this.btnInfo3.TabIndex = 3;
            this.btnInfo3.Text = "3 Parámetro";
            this.btnInfo3.UseVisualStyleBackColor = true;
            this.btnInfo3.Click += new System.EventHandler(this.btnInfo3_Click);
            // 
            // btnInfo4
            // 
            this.btnInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo4.Location = new System.Drawing.Point(837, 111);
            this.btnInfo4.Name = "btnInfo4";
            this.btnInfo4.Size = new System.Drawing.Size(122, 40);
            this.btnInfo4.TabIndex = 4;
            this.btnInfo4.Text = "4 Parámetro";
            this.btnInfo4.UseVisualStyleBackColor = true;
            this.btnInfo4.Click += new System.EventHandler(this.btnInfo4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 537);
            this.Controls.Add(this.btnInfo4);
            this.Controls.Add(this.btnInfo3);
            this.Controls.Add(this.btnInfo2);
            this.Controls.Add(this.btnInfo1);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnInfo1;
        private System.Windows.Forms.Button btnInfo2;
        private System.Windows.Forms.Button btnInfo3;
        private System.Windows.Forms.Button btnInfo4;
    }
}

