namespace OrganizacaoWFApp.FormViews {
    partial class FrmColaborador {
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
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.cboColabSexo = new System.Windows.Forms.ComboBox();
            this.nudColabCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.dtpColabSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpColabEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpColabNasc = new System.Windows.Forms.DateTimePicker();
            this.txtColabNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDataNascimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDataEntrada = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDataSaida = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColabCargaHoraria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataNascimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPrincipal.Controls.Add(this.chkAtivo);
            this.grpPrincipal.Controls.Add(this.cboColabSexo);
            this.grpPrincipal.Controls.Add(this.nudColabCargaHoraria);
            this.grpPrincipal.Controls.Add(this.dtpColabSaida);
            this.grpPrincipal.Controls.Add(this.dtpColabEntrada);
            this.grpPrincipal.Controls.Add(this.dtpColabNasc);
            this.grpPrincipal.Controls.Add(this.txtColabNome);
            this.grpPrincipal.Controls.Add(this.label6);
            this.grpPrincipal.Controls.Add(this.label5);
            this.grpPrincipal.Controls.Add(this.label4);
            this.grpPrincipal.Controls.Add(this.label3);
            this.grpPrincipal.Controls.Add(this.label2);
            this.grpPrincipal.Controls.Add(this.label1);
            this.grpPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrincipal.Location = new System.Drawing.Point(12, 43);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(530, 259);
            this.grpPrincipal.TabIndex = 0;
            this.grpPrincipal.TabStop = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(396, 146);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(98, 20);
            this.chkAtivo.TabIndex = 28;
            this.chkAtivo.Text = "Em ativiade";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckStateChanged += new System.EventHandler(this.chkAtivo_CheckStateChanged);
            // 
            // cboColabSexo
            // 
            this.cboColabSexo.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Indefinido2"});
            this.cboColabSexo.FormattingEnabled = true;
            this.cboColabSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboColabSexo.Location = new System.Drawing.Point(141, 182);
            this.cboColabSexo.Name = "cboColabSexo";
            this.cboColabSexo.Size = new System.Drawing.Size(164, 24);
            this.cboColabSexo.TabIndex = 23;
            // 
            // nudColabCargaHoraria
            // 
            this.nudColabCargaHoraria.Location = new System.Drawing.Point(142, 221);
            this.nudColabCargaHoraria.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudColabCargaHoraria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColabCargaHoraria.Name = "nudColabCargaHoraria";
            this.nudColabCargaHoraria.Size = new System.Drawing.Size(67, 22);
            this.nudColabCargaHoraria.TabIndex = 22;
            this.nudColabCargaHoraria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpColabSaida
            // 
            this.dtpColabSaida.Enabled = false;
            this.dtpColabSaida.Location = new System.Drawing.Point(141, 144);
            this.dtpColabSaida.Name = "dtpColabSaida";
            this.dtpColabSaida.Size = new System.Drawing.Size(210, 22);
            this.dtpColabSaida.TabIndex = 21;
            this.dtpColabSaida.Value = new System.DateTime(2015, 11, 6, 0, 0, 0, 0);
            // 
            // dtpColabEntrada
            // 
            this.dtpColabEntrada.Location = new System.Drawing.Point(141, 106);
            this.dtpColabEntrada.Name = "dtpColabEntrada";
            this.dtpColabEntrada.Size = new System.Drawing.Size(210, 22);
            this.dtpColabEntrada.TabIndex = 20;
            this.dtpColabEntrada.Value = new System.DateTime(2015, 11, 6, 0, 0, 0, 0);
            // 
            // dtpColabNasc
            // 
            this.dtpColabNasc.Location = new System.Drawing.Point(141, 69);
            this.dtpColabNasc.Name = "dtpColabNasc";
            this.dtpColabNasc.Size = new System.Drawing.Size(210, 22);
            this.dtpColabNasc.TabIndex = 19;
            this.dtpColabNasc.Value = new System.DateTime(2015, 11, 6, 0, 0, 0, 0);
            // 
            // txtColabNome
            // 
            this.txtColabNome.Location = new System.Drawing.Point(141, 33);
            this.txtColabNome.MaxLength = 150;
            this.txtColabNome.Name = "txtColabNome";
            this.txtColabNome.Size = new System.Drawing.Size(353, 22);
            this.txtColabNome.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Carga Horária/mês*: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sexo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data de Saída: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Entrada*: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data de Nascimento*: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome*: ";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Location = new System.Drawing.Point(127, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(278, 29);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Cadastro: Colaborador";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(369, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(467, 312);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorDataNascimento
            // 
            this.errorDataNascimento.ContainerControl = this;
            // 
            // errorDataEntrada
            // 
            this.errorDataEntrada.ContainerControl = this;
            // 
            // errorDataSaida
            // 
            this.errorDataSaida.ContainerControl = this;
            // 
            // FrmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 341);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.grpPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 380);
            this.MinimumSize = new System.Drawing.Size(570, 380);
            this.Name = "FrmColaborador";
            this.Text = "Colaborador - OrganizaçãoSys";
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColabCargaHoraria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataNascimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.ComboBox cboColabSexo;
        private System.Windows.Forms.NumericUpDown nudColabCargaHoraria;
        private System.Windows.Forms.DateTimePicker dtpColabSaida;
        private System.Windows.Forms.DateTimePicker dtpColabEntrada;
        private System.Windows.Forms.DateTimePicker dtpColabNasc;
        private System.Windows.Forms.TextBox txtColabNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorDataNascimento;
        private System.Windows.Forms.ErrorProvider errorDataEntrada;
        private System.Windows.Forms.ErrorProvider errorDataSaida;
    }
}