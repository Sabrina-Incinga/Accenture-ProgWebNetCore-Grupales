namespace WindowsFactura
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
            this.txt_producto1 = new System.Windows.Forms.TextBox();
            this.txt_producto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_producto1
            // 
            this.txt_producto1.Location = new System.Drawing.Point(124, 110);
            this.txt_producto1.Multiline = true;
            this.txt_producto1.Name = "txt_producto1";
            this.txt_producto1.Size = new System.Drawing.Size(160, 132);
            this.txt_producto1.TabIndex = 0;
            // 
            // txt_producto2
            // 
            this.txt_producto2.Location = new System.Drawing.Point(354, 110);
            this.txt_producto2.Multiline = true;
            this.txt_producto2.Name = "txt_producto2";
            this.txt_producto2.Size = new System.Drawing.Size(163, 132);
            this.txt_producto2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_producto2);
            this.Controls.Add(this.txt_producto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_producto1;
        private System.Windows.Forms.TextBox txt_producto2;
    }
}

