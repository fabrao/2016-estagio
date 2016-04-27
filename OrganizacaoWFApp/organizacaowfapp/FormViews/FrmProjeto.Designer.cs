namespace OrganizacaoWFApp.FormViews {
    partial class FrmProjeto {
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
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.cboProjTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProjResponsavel = new System.Windows.Forms.ComboBox();
            this.cboProjArea = new System.Windows.Forms.ComboBox();
            this.nudProjTempo = new System.Windows.Forms.NumericUpDown();
            this.dtpProjConclusao = new System.Windows.Forms.DateTimePicker();
            this.dtpProjInicio = new System.Windows.Forms.DateTimePicker();
            this.txtProjNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDataInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDataConclusao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorResponsavel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArea = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataConclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(318, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Location = new System.Drawing.Point(138, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(217, 29);
            this.lblPrincipal.TabIndex = 5;
            this.lblPrincipal.Text = "Cadastro: Projeto";
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.chkTipo);
            this.grpPrincipal.Controls.Add(this.cboProjTipo);
            this.grpPrincipal.Controls.Add(this.label7);
            this.grpPrincipal.Controls.Add(this.cboProjResponsavel);
            this.grpPrincipal.Controls.Add(this.cboProjArea);
            this.grpPrincipal.Controls.Add(this.nudProjTempo);
            this.grpPrincipal.Controls.Add(this.dtpProjConclusao);
            this.grpPrincipal.Controls.Add(this.dtpProjInicio);
            this.grpPrincipal.Controls.Add(this.txtProjNome);
            this.grpPrincipal.Controls.Add(this.label6);
            this.grpPrincipal.Controls.Add(this.label5);
            this.grpPrincipal.Controls.Add(this.label4);
            this.grpPrincipal.Controls.Add(this.label3);
            this.grpPrincipal.Controls.Add(this.label2);
            this.grpPrincipal.Controls.Add(this.label1);
            this.grpPrincipal.Location = new System.Drawing.Point(12, 46);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(478, 295);
            this.grpPrincipal.TabIndex = 4;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "Projeto";
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Checked = true;
            this.chkTipo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTipo.Location = new System.Drawing.Point(390, 223);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(78, 17);
            this.chkTipo.TabIndex = 29;
            this.chkTipo.Text = "Atribuir tipo";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckStateChanged += new System.EventHandler(this.chkTipo_CheckStateChanged);
            // 
            // cboProjTipo
            // 
            this.cboProjTipo.Enabled = false;
            this.cboProjTipo.FormattingEnabled = true;
            this.cboProjTipo.Location = new System.Drawing.Point(120, 219);
            this.cboProjTipo.Name = "cboProjTipo";
            this.cboProjTipo.Size = new System.Drawing.Size(261, 21);
            this.cboProjTipo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tipo de Projeto: ";
            // 
            // cboProjResponsavel
            // 
            this.cboProjResponsavel.FormattingEnabled = true;
            this.cboProjResponsavel.Location = new System.Drawing.Point(120, 141);
            this.cboProjResponsavel.Name = "cboProjResponsavel";
            this.cboProjResponsavel.Size = new System.Drawing.Size(332, 21);
            this.cboProjResponsavel.TabIndex = 24;
            // 
            // cboProjArea
            // 
            this.cboProjArea.FormattingEnabled = true;
            this.cboProjArea.Location = new System.Drawing.Point(120, 182);
            this.cboProjArea.Name = "cboProjArea";
            this.cboProjArea.Size = new System.Drawing.Size(261, 21);
            this.cboProjArea.TabIndex = 23;
            // 
            // nudProjTempo
            // 
            this.nudProjTempo.Location = new System.Drawing.Point(148, 257);
            this.nudProjTempo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudProjTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProjTempo.Name = "nudProjTempo";
            this.nudProjTempo.Size = new System.Drawing.Size(63, 20);
            this.nudProjTempo.TabIndex = 22;
            this.nudProjTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpProjConclusao
            // 
            this.dtpProjConclusao.Location = new System.Drawing.Point(120, 106);
            this.dtpProjConclusao.Name = "dtpProjConclusao";
            this.dtpProjConclusao.Size = new System.Drawing.Size(196, 20);
            this.dtpProjConclusao.TabIndex = 20;
            this.dtpProjConclusao.Value = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.dtpProjConclusao.Leave += new System.EventHandler(this.dtpProjConclusao_Leave);
            // 
            // dtpProjInicio
            // 
            this.dtpProjInicio.Location = new System.Drawing.Point(120, 69);
            this.dtpProjInicio.Name = "dtpProjInicio";
            this.dtpProjInicio.Size = new System.Drawing.Size(196, 20);
            this.dtpProjInicio.TabIndex = 19;
            this.dtpProjInicio.Value = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            // 
            // txtProjNome
            // 
            this.txtProjNome.Location = new System.Drawing.Point(120, 33);
            this.txtProjNome.MaxLength = 150;
            this.txtProjNome.Name = "txtProjNome";
            this.txtProjNome.Size = new System.Drawing.Size(332, 20);
            this.txtProjNome.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trabalho Estimado (horas)*: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Área*: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Responsável*: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Conclusão*: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data de Início*: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome*: ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(415, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorDataInicio
            // 
            this.errorDataInicio.ContainerControl = this;
            // 
            // errorDataConclusao
            // 
            this.errorDataConclusao.ContainerControl = this;
            // 
            // errorResponsavel
            // 
            this.errorResponsavel.ContainerControl = this;
            // 
            // errorArea
            // 
            this.errorArea.ContainerControl = this;
            // 
            // FrmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.grpPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 420);
            this.MinimumSize = new System.Drawing.Size(520, 420);
            this.Name = "FrmProjeto";
            this.Text = "Projeto - OrganizaçãoSys";
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataConclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.ComboBox cboProjArea;
        private System.Windows.Forms.NumericUpDown nudProjTempo;
        private System.Windows.Forms.DateTimePicker dtpProjConclusao;
        private System.Windows.Forms.DateTimePicker dtpProjInicio;
        private System.Windows.Forms.TextBox txtProjNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProjTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProjResponsavel;
        private System.Windows.Forms.CheckBox chkTipo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorDataInicio;
        private System.Windows.Forms.ErrorProvider errorDataConclusao;
        private System.Windows.Forms.ErrorProvider errorResponsavel;
        private System.Windows.Forms.ErrorProvider errorArea;
    }
}