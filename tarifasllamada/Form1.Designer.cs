namespace tarifasllamada
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
            this.cbdestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el destino de su llamada:";
            // 
            // cbdestino
            // 
            this.cbdestino.FormattingEnabled = true;
            this.cbdestino.Items.AddRange(new object[] {
            "Estados Unidos",
            "Canadá",
            "Europa",
            "Resto del Mundo"});
            this.cbdestino.Location = new System.Drawing.Point(45, 71);
            this.cbdestino.Name = "cbdestino";
            this.cbdestino.Size = new System.Drawing.Size(121, 21);
            this.cbdestino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarifas llamadas internacionales.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese la duración total de su llamada:";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(77, 127);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(54, 20);
            this.txtduracion.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(65, 156);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(83, 192);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "label4";
            this.lbltotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 243);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbdestino);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tarifas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltotal;
    }
}

