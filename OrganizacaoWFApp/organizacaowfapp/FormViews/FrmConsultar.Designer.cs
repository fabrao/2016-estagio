namespace OrganizacaoWFApp.FormViews
{
    partial class FrmConsultar
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
            this.tbcBusca = new System.Windows.Forms.TabControl();
            this.tbpColaboradores = new System.Windows.Forms.TabPage();
            this.grdColaboradores = new System.Windows.Forms.DataGridView();
            this.tbpAreas = new System.Windows.Forms.TabPage();
            this.grdAreas = new System.Windows.Forms.DataGridView();
            this.tbpTipoProjetos = new System.Windows.Forms.TabPage();
            this.grdTiposProjetos = new System.Windows.Forms.DataGridView();
            this.tbpProjetos = new System.Windows.Forms.TabPage();
            this.grdProjetos = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExpExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultaoBusca = new System.Windows.Forms.Label();
            this.tbcBusca.SuspendLayout();
            this.tbpColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColaboradores)).BeginInit();
            this.tbpAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAreas)).BeginInit();
            this.tbpTipoProjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposProjetos)).BeginInit();
            this.tbpProjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcBusca
            // 
            this.tbcBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcBusca.Controls.Add(this.tbpColaboradores);
            this.tbcBusca.Controls.Add(this.tbpAreas);
            this.tbcBusca.Controls.Add(this.tbpTipoProjetos);
            this.tbcBusca.Controls.Add(this.tbpProjetos);
            this.tbcBusca.Location = new System.Drawing.Point(8, 42);
            this.tbcBusca.Name = "tbcBusca";
            this.tbcBusca.SelectedIndex = 0;
            this.tbcBusca.Size = new System.Drawing.Size(873, 314);
            this.tbcBusca.TabIndex = 0;
            // 
            // tbpColaboradores
            // 
            this.tbpColaboradores.Controls.Add(this.grdColaboradores);
            this.tbpColaboradores.Location = new System.Drawing.Point(4, 22);
            this.tbpColaboradores.Name = "tbpColaboradores";
            this.tbpColaboradores.Padding = new System.Windows.Forms.Padding(3);
            this.tbpColaboradores.Size = new System.Drawing.Size(865, 288);
            this.tbpColaboradores.TabIndex = 0;
            this.tbpColaboradores.Text = "Colaboradores";
            this.tbpColaboradores.UseVisualStyleBackColor = true;
            this.tbpColaboradores.Enter += new System.EventHandler(this.tbpColaboradores_Enter);
            // 
            // grdColaboradores
            // 
            this.grdColaboradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColaboradores.Location = new System.Drawing.Point(0, 0);
            this.grdColaboradores.Name = "grdColaboradores";
            this.grdColaboradores.ReadOnly = true;
            this.grdColaboradores.Size = new System.Drawing.Size(865, 288);
            this.grdColaboradores.TabIndex = 0;
            this.grdColaboradores.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdColaboradores_CellMouseDown);
            // 
            // tbpAreas
            // 
            this.tbpAreas.Controls.Add(this.grdAreas);
            this.tbpAreas.Location = new System.Drawing.Point(4, 22);
            this.tbpAreas.Name = "tbpAreas";
            this.tbpAreas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAreas.Size = new System.Drawing.Size(865, 288);
            this.tbpAreas.TabIndex = 1;
            this.tbpAreas.Text = "Áreas";
            this.tbpAreas.UseVisualStyleBackColor = true;
            this.tbpAreas.Enter += new System.EventHandler(this.tbpAreas_Enter);
            // 
            // grdAreas
            // 
            this.grdAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAreas.Location = new System.Drawing.Point(0, 0);
            this.grdAreas.Name = "grdAreas";
            this.grdAreas.ReadOnly = true;
            this.grdAreas.Size = new System.Drawing.Size(865, 288);
            this.grdAreas.TabIndex = 1;
            this.grdAreas.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdAreas_CellMouseDown);
            // 
            // tbpTipoProjetos
            // 
            this.tbpTipoProjetos.Controls.Add(this.grdTiposProjetos);
            this.tbpTipoProjetos.Location = new System.Drawing.Point(4, 22);
            this.tbpTipoProjetos.Name = "tbpTipoProjetos";
            this.tbpTipoProjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTipoProjetos.Size = new System.Drawing.Size(865, 288);
            this.tbpTipoProjetos.TabIndex = 2;
            this.tbpTipoProjetos.Text = "Tipos de Projetos";
            this.tbpTipoProjetos.UseVisualStyleBackColor = true;
            this.tbpTipoProjetos.Enter += new System.EventHandler(this.tbpTipoProjetos_Enter);
            // 
            // grdTiposProjetos
            // 
            this.grdTiposProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTiposProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTiposProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTiposProjetos.Location = new System.Drawing.Point(0, 0);
            this.grdTiposProjetos.Name = "grdTiposProjetos";
            this.grdTiposProjetos.ReadOnly = true;
            this.grdTiposProjetos.Size = new System.Drawing.Size(865, 288);
            this.grdTiposProjetos.TabIndex = 1;
            this.grdTiposProjetos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTiposProjetos_CellMouseDown);
            // 
            // tbpProjetos
            // 
            this.tbpProjetos.Controls.Add(this.grdProjetos);
            this.tbpProjetos.Location = new System.Drawing.Point(4, 22);
            this.tbpProjetos.Name = "tbpProjetos";
            this.tbpProjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProjetos.Size = new System.Drawing.Size(865, 288);
            this.tbpProjetos.TabIndex = 3;
            this.tbpProjetos.Text = "Projetos";
            this.tbpProjetos.UseVisualStyleBackColor = true;
            this.tbpProjetos.Enter += new System.EventHandler(this.tbpProjetos_Enter);
            // 
            // grdProjetos
            // 
            this.grdProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjetos.Location = new System.Drawing.Point(0, 0);
            this.grdProjetos.Name = "grdProjetos";
            this.grdProjetos.ReadOnly = true;
            this.grdProjetos.Size = new System.Drawing.Size(865, 288);
            this.grdProjetos.TabIndex = 1;
            this.grdProjetos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdProjetos_CellMouseDown);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(545, 15);
            this.txtBusca.MaxLength = 100;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(253, 21);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(496, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro:";
            // 
            // btnExpExcel
            // 
            this.btnExpExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExpExcel.Location = new System.Drawing.Point(611, 366);
            this.btnExpExcel.Name = "btnExpExcel";
            this.btnExpExcel.Size = new System.Drawing.Size(173, 28);
            this.btnExpExcel.TabIndex = 3;
            this.btnExpExcel.Text = "Exportar para o Excel >>";
            this.btnExpExcel.UseVisualStyleBackColor = true;
            this.btnExpExcel.Click += new System.EventHandler(this.btnExpExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(804, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(8, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 24);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(298, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 24);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(379, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 24);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(812, 366);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 28);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResultaoBusca
            // 
            this.lblResultaoBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultaoBusca.AutoSize = true;
            this.lblResultaoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultaoBusca.Location = new System.Drawing.Point(12, 359);
            this.lblResultaoBusca.Name = "lblResultaoBusca";
            this.lblResultaoBusca.Size = new System.Drawing.Size(0, 13);
            this.lblResultaoBusca.TabIndex = 9;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 406);
            this.Controls.Add(this.lblResultaoBusca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExpExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.tbcBusca);
            this.MinimumSize = new System.Drawing.Size(909, 445);
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar - OrganizaçãoSys";
            this.Activated += new System.EventHandler(this.FrmConsultar_Activated);
            this.tbcBusca.ResumeLayout(false);
            this.tbpColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdColaboradores)).EndInit();
            this.tbpAreas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAreas)).EndInit();
            this.tbpTipoProjetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposProjetos)).EndInit();
            this.tbpProjetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBusca;
        private System.Windows.Forms.TabPage tbpColaboradores;
        private System.Windows.Forms.TabPage tbpAreas;
        private System.Windows.Forms.TabPage tbpTipoProjetos;
        private System.Windows.Forms.TabPage tbpProjetos;
        private System.Windows.Forms.DataGridView grdColaboradores;
        private System.Windows.Forms.DataGridView grdAreas;
        private System.Windows.Forms.DataGridView grdTiposProjetos;
        private System.Windows.Forms.DataGridView grdProjetos;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExpExcel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResultaoBusca;
    }
}