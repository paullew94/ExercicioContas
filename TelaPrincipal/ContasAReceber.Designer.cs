namespace TelaPrincipal
{
    partial class ContasAReceber
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
            this.ckbRecibido = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDataRecibimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.mtbValorRecibido = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ckbRecibido
            // 
            this.ckbRecibido.AutoSize = true;
            this.ckbRecibido.Location = new System.Drawing.Point(37, 273);
            this.ckbRecibido.Name = "ckbRecibido";
            this.ckbRecibido.Size = new System.Drawing.Size(68, 17);
            this.ckbRecibido.TabIndex = 11;
            this.ckbRecibido.Text = "Recibido";
            this.ckbRecibido.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Recibido";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(38, 79);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(93, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 6;
            // 
            // lblDataRecibimento
            // 
            this.lblDataRecibimento.AutoSize = true;
            this.lblDataRecibimento.Location = new System.Drawing.Point(38, 213);
            this.lblDataRecibimento.Name = "lblDataRecibimento";
            this.lblDataRecibimento.Size = new System.Drawing.Size(92, 13);
            this.lblDataRecibimento.TabIndex = 12;
            this.lblDataRecibimento.Text = "Data Recibimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 13;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(41, 95);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 20);
            this.mtbValor.TabIndex = 14;
            // 
            // mtbValorRecibido
            // 
            this.mtbValorRecibido.Location = new System.Drawing.Point(41, 139);
            this.mtbValorRecibido.Name = "mtbValorRecibido";
            this.mtbValorRecibido.Size = new System.Drawing.Size(100, 20);
            this.mtbValorRecibido.TabIndex = 16;
            // 
            // mtbDataRecebimento
            // 
            this.mtbDataRecebimento.Location = new System.Drawing.Point(41, 229);
            this.mtbDataRecebimento.Name = "mtbDataRecebimento";
            this.mtbDataRecebimento.Size = new System.Drawing.Size(100, 20);
            this.mtbDataRecebimento.TabIndex = 17;
            // 
            // ContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbDataRecebimento);
            this.Controls.Add(this.mtbValorRecibido);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataRecibimento);
            this.Controls.Add(this.ckbRecibido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "ContasAReceber";
            this.Text = "ContasAReceber";
            this.Load += new System.EventHandler(this.ContasAReceber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbRecibido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDataRecibimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.MaskedTextBox mtbValorRecibido;
        private System.Windows.Forms.MaskedTextBox mtbDataRecebimento;
    }
}