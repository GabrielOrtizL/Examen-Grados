namespace Com_Grados
{
    partial class Compgrados
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cel1 = new System.Windows.Forms.TextBox();
            this.far1 = new System.Windows.Forms.TextBox();
            this.cel2 = new System.Windows.Forms.TextBox();
            this.far2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.Button();
            this.fah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERTIDOR DE GRADOS";
            // 
            // cel1
            // 
            this.cel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel1.Location = new System.Drawing.Point(10, 80);
            this.cel1.Name = "cel1";
            this.cel1.Size = new System.Drawing.Size(95, 22);
            this.cel1.TabIndex = 1;
            // 
            // far1
            // 
            this.far1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.far1.Location = new System.Drawing.Point(11, 188);
            this.far1.Name = "far1";
            this.far1.Size = new System.Drawing.Size(95, 22);
            this.far1.TabIndex = 2;
            // 
            // cel2
            // 
            this.cel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel2.Location = new System.Drawing.Point(157, 80);
            this.cel2.Name = "cel2";
            this.cel2.ReadOnly = true;
            this.cel2.Size = new System.Drawing.Size(95, 22);
            this.cel2.TabIndex = 3;
            // 
            // far2
            // 
            this.far2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.far2.Location = new System.Drawing.Point(157, 188);
            this.far2.Name = "far2";
            this.far2.ReadOnly = true;
            this.far2.Size = new System.Drawing.Size(95, 22);
            this.far2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Celcius a Farenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Farenheit a Celcius  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // cel
            // 
            this.cel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel.Location = new System.Drawing.Point(73, 108);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(145, 28);
            this.cel.TabIndex = 9;
            this.cel.Text = "CONVERTIR";
            this.cel.UseVisualStyleBackColor = true;
            this.cel.Click += new System.EventHandler(this.cel_Click);
            // 
            // fah
            // 
            this.fah.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fah.Location = new System.Drawing.Point(73, 216);
            this.fah.Name = "fah";
            this.fah.Size = new System.Drawing.Size(145, 28);
            this.fah.TabIndex = 10;
            this.fah.Text = "CONVERTIR";
            this.fah.UseVisualStyleBackColor = true;
            this.fah.Click += new System.EventHandler(this.fah_Click);
            // 
            // Compgrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fah);
            this.Controls.Add(this.cel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.far2);
            this.Controls.Add(this.cel2);
            this.Controls.Add(this.far1);
            this.Controls.Add(this.cel1);
            this.Controls.Add(this.label1);
            this.Name = "Compgrados";
            this.Size = new System.Drawing.Size(283, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cel1;
        private System.Windows.Forms.TextBox far1;
        private System.Windows.Forms.TextBox cel2;
        private System.Windows.Forms.TextBox far2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cel;
        private System.Windows.Forms.Button fah;
    }
}
