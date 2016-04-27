namespace OrganizacaoWFApp.FormViews {
    partial class FrmTipoProjeto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.txtTProjDescricao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTProjNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(301, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Location = new System.Drawing.Point(83, 11);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(315, 29);
            this.lblPrincipal.TabIndex = 7;
            this.lblPrincipal.Text = "Cadastro: Tipo de Projeto";
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.txtTProjDescricao);
            this.grpPrincipal.Controls.Add(this.label1);
            this.grpPrincipal.Controls.Add(this.txtTProjNome);
            this.grpPrincipal.Controls.Add(this.label7);
            this.grpPrincipal.Location = new System.Drawing.Point(13, 43);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(464, 183);
            this.grpPrincipal.TabIndex = 6;
            this.grpPrincipal.TabStop = false;
            // 
            // txtTProjDescricao
            // 
            this.txtTProjDescricao.Location = new System.Drawing.Point(75, 80);
            this.txtTProjDescricao.MaxLength = 350;
            this.txtTProjDescricao.Name = "txtTProjDescricao";
            this.txtTProjDescricao.Size = new System.Drawing.Size(374, 85);
            this.txtTProjDescricao.TabIndex = 12;
            this.txtTProjDescricao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição: ";
            // 
            // txtTProjNome
            // 
            this.txtTProjNome.Location = new System.Drawing.Point(72, 30);
            this.txtTProjNome.MaxLength = 150;
            this.txtTProjNome.Name = "txtTProjNome";
            this.txtTProjNome.Size = new System.Drawing.Size(365, 20);
            this.txtTProjNome.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome*: ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(402, 232);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmTipoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.grpPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "FrmTipoProjeto";
            this.Text = "Tipo de Projeto  - OrganizaçãoSys";
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.TextBox txtTProjNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtTProjDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}