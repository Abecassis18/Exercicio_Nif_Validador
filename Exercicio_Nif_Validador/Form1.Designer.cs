namespace Exercicio_Nif_Validador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtxtNif = new System.Windows.Forms.MaskedTextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensagemValidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtNif
            // 
            this.mtxtNif.Location = new System.Drawing.Point(120, 39);
            this.mtxtNif.Mask = "000000000";
            this.mtxtNif.Name = "mtxtNif";
            this.mtxtNif.Size = new System.Drawing.Size(100, 20);
            this.mtxtNif.TabIndex = 0;
            this.mtxtNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(260, 37);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIF";
            // 
            // lblMensagemValidade
            // 
            this.lblMensagemValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensagemValidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensagemValidade.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMensagemValidade.Location = new System.Drawing.Point(141, 82);
            this.lblMensagemValidade.Name = "lblMensagemValidade";
            this.lblMensagemValidade.Size = new System.Drawing.Size(164, 32);
            this.lblMensagemValidade.TabIndex = 3;
            this.lblMensagemValidade.Text = "label2";
            this.lblMensagemValidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 135);
            this.Controls.Add(this.lblMensagemValidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.mtxtNif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Validador Nif";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtNif;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensagemValidade;
    }
}

