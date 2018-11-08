namespace FactoresPrimosUI
{
    partial class MainView
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
            this.IngresarNumeroLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.factoresPrimosTextLbl = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.factoresPrimosLbl = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngresarNumeroLbl
            // 
            this.IngresarNumeroLbl.AutoSize = true;
            this.IngresarNumeroLbl.Location = new System.Drawing.Point(48, 34);
            this.IngresarNumeroLbl.Name = "IngresarNumeroLbl";
            this.IngresarNumeroLbl.Size = new System.Drawing.Size(131, 17);
            this.IngresarNumeroLbl.TabIndex = 0;
            this.IngresarNumeroLbl.Text = "Ingrese un numero ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            // 
            // factoresPrimosTextLbl
            // 
            this.factoresPrimosTextLbl.AutoSize = true;
            this.factoresPrimosTextLbl.Location = new System.Drawing.Point(254, 33);
            this.factoresPrimosTextLbl.Name = "factoresPrimosTextLbl";
            this.factoresPrimosTextLbl.Size = new System.Drawing.Size(109, 17);
            this.factoresPrimosTextLbl.TabIndex = 3;
            this.factoresPrimosTextLbl.Tag = "factoresPrimosLbl";
            this.factoresPrimosTextLbl.Text = "Factores primos";
            this.factoresPrimosTextLbl.Visible = false;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(51, 72);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(116, 22);
            this.txtBoxNumero.TabIndex = 6;
            // 
            // factoresPrimosLbl
            // 
            this.factoresPrimosLbl.AutoSize = true;
            this.factoresPrimosLbl.Location = new System.Drawing.Point(257, 76);
            this.factoresPrimosLbl.Name = "factoresPrimosLbl";
            this.factoresPrimosLbl.Size = new System.Drawing.Size(16, 17);
            this.factoresPrimosLbl.TabIndex = 7;
            this.factoresPrimosLbl.Text = "  ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(70, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.factoresPrimosLbl);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.factoresPrimosTextLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IngresarNumeroLbl);
            this.Name = "MainView";
            this.Text = "Factorizador";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngresarNumeroLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label factoresPrimosTextLbl;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label factoresPrimosLbl;
        private System.Windows.Forms.Button btnCalcular;
    }
}

