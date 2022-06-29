namespace imc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblcalcular = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(122, 111);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 0;
            // 
            // lblcalcular
            // 
            this.lblcalcular.AutoSize = true;
            this.lblcalcular.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalcular.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblcalcular.Location = new System.Drawing.Point(57, 59);
            this.lblcalcular.Name = "lblcalcular";
            this.lblcalcular.Size = new System.Drawing.Size(159, 19);
            this.lblcalcular.TabIndex = 1;
            this.lblcalcular.Text = "CALCULE SEU IMC";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(55, 153);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(63, 16);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(58, 112);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(55, 16);
            this.lblpeso.TabIndex = 3;
            this.lblpeso.Text = "Peso: ";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(122, 153);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btncalcular.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(56, 192);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(171, 40);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblimc.Location = new System.Drawing.Point(57, 247);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(49, 19);
            this.lblimc.TabIndex = 7;
            this.lblimc.Text = "IMC:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(112, 247);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 16);
            this.lblresultado.TabIndex = 8;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(106, 251);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 14);
            this.lblresult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 298);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblcalcular);
            this.Controls.Add(this.txtpeso);
            this.Name = "Form1";
            this.Text = "resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblcalcular;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblresult;
    }
}

