namespace TelaPrincipal
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
            this.btnContasAReceber = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContasAReceber
            // 
            this.btnContasAReceber.Location = new System.Drawing.Point(12, 51);
            this.btnContasAReceber.Name = "btnContasAReceber";
            this.btnContasAReceber.Size = new System.Drawing.Size(92, 70);
            this.btnContasAReceber.TabIndex = 0;
            this.btnContasAReceber.Text = "Contas a receber";
            this.btnContasAReceber.UseVisualStyleBackColor = true;
            this.btnContasAReceber.Click += new System.EventHandler(this.btnContasAReceber_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(139, 75);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAPagar
            // 
            this.btnAPagar.Location = new System.Drawing.Point(257, 55);
            this.btnAPagar.Name = "btnAPagar";
            this.btnAPagar.Size = new System.Drawing.Size(75, 66);
            this.btnAPagar.TabIndex = 2;
            this.btnAPagar.Text = "Contas a pagar";
            this.btnAPagar.UseVisualStyleBackColor = true;
            this.btnAPagar.Click += new System.EventHandler(this.btnAPagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 468);
            this.Controls.Add(this.btnAPagar);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnContasAReceber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContasAReceber;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAPagar;
    }
}

