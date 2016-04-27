using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.Entidades;
using OrganizacaoWFApp.DataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmConsultar : Form {
        Consultar cs = new Consultar();
        public FrmConsultar(int tab) {
            InitializeComponent();
            tbcBusca.SelectedIndex = tab;
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEditar = new ToolStripMenuItem("Editar");
            ToolStripMenuItem mnuApagar = new ToolStripMenuItem("Apagar");
            mnuEditar.Click += new EventHandler(mnuEditar_Click);
            mnuApagar.Click += new EventHandler(mnuApagar_Click);
            mnu.Items.AddRange(new ToolStripItem[] { mnuEditar, mnuApagar });
            grdColaboradores.ContextMenuStrip = mnu;
            grdAreas.ContextMenuStrip = mnu;
            grdTiposProjetos.ContextMenuStrip = mnu;
            grdProjetos.ContextMenuStrip = mnu;

            grdColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAreas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTiposProjetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProjetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //grdAreas.Columns[1].Width = (grdAreas.Columns[1].HeaderText.Length)*30;
            //GridView1.Columns[2].ItemStyle.Width = widestData * 30;
            //GridView1.Columns[2].ItemStyle.Wrap = false;
        }

        #region EVENTOS
        private void btnNovo_Click(object sender, EventArgs e) {
            try {
                switch (tbcBusca.SelectedIndex) {
                    case 0:
                        FrmColaborador frmCadColaborador = new FrmColaborador();
                        frmCadColaborador.MdiParent = MdiParent;
                        frmCadColaborador.Show();
                        break;
                    case 1:
                        FrmArea frmArea = new FrmArea();
                        frmArea.MdiParent = MdiParent;
                        frmArea.Show();
                        break;
                    case 2:
                        FrmTipoProjeto frmTipoProjeto = new FrmTipoProjeto();
                        frmTipoProjeto.MdiParent = MdiParent;
                        frmTipoProjeto.Show();
                        break;
                    case 3:
                        FrmProjeto frmProjeto = new FrmProjeto();
                        frmProjeto.MdiParent = MdiParent;
                        frmProjeto.Show();
                        break;
                }
            } catch { }
        }
        private void btnEditar_Click(object sender, EventArgs e) {
            try {
                switch (tbcBusca.SelectedIndex) {
                    case 0:
                        Colaborador editColaborador = (Colaborador)grdColaboradores.CurrentRow.DataBoundItem;
                        FrmColaborador frmCadColaborador = new FrmColaborador(editColaborador);
                        frmCadColaborador.MdiParent = MdiParent;
                        frmCadColaborador.Show();
                        break;
                    case 1:
                        Area editArea = (Area)grdAreas.CurrentRow.DataBoundItem;
                        FrmArea frmArea = new FrmArea(editArea);
                        frmArea.MdiParent = MdiParent;
                        frmArea.Show();
                        break;
                    case 2:
                        TipoProjeto editTipoProjeto = (TipoProjeto)grdTiposProjetos.CurrentRow.DataBoundItem;
                        FrmTipoProjeto frmTipoProjeto = new FrmTipoProjeto(editTipoProjeto);
                        frmTipoProjeto.MdiParent = MdiParent;
                        frmTipoProjeto.Show();
                        break;
                    case 3:
                        Projeto editProjeto = (Projeto)grdProjetos.CurrentRow.DataBoundItem;
                        FrmProjeto frmProjeto = new FrmProjeto(editProjeto);
                        frmProjeto.MdiParent = MdiParent;
                        frmProjeto.Show();
                        break;
                }
            } catch { }
        }
        private void btnApagar_Click(object sender, EventArgs e) {
            Remover rm = new Remover();
            switch (tbcBusca.SelectedIndex) {
                case 0:
                    rm.RemoverLinhaGrid(grdColaboradores, "colaborador");
                    break;
                case 1:
                    rm.RemoverLinhaGrid(grdAreas, "area");
                    break;
                case 2:
                    rm.RemoverLinhaGrid(grdTiposProjetos, "tipoProjeto");
                    break;
                case 3:
                    rm.RemoverLinhaGrid(grdProjetos, "projeto");
                    break;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e) {
            Consultar cns = new Consultar();
            switch (tbcBusca.SelectedIndex) {
                case 0:
                    preencherGridView(cns.ColaboadorNameSearch(txtBusca.Text, lblResultaoBusca), grdColaboradores);
                    break;
                case 1:
                    preencherGridView(cns.AreaNameSearch(txtBusca.Text, lblResultaoBusca), grdAreas);
                    break;
                case 2:
                    preencherGridView(cns.TipoProjetoNameSearch(txtBusca.Text, lblResultaoBusca), grdTiposProjetos);
                    break;
                case 3:
                    preencherGridView(cns.ProjetoNameSearch(txtBusca.Text, lblResultaoBusca), grdProjetos);
                    break;
            }
        }
        private void btnExpExcel_Click(object sender, EventArgs e) {
            ExportToExcel export = new ExportToExcel();
            switch (tbcBusca.SelectedIndex) {
                case 0:
                    export.ToExcel(grdColaboradores);
                    break;
                case 1:
                    export.ToExcel(grdAreas);
                    break;
                case 2:
                    export.ToExcel(grdTiposProjetos);
                    break;
                case 3:
                    export.ToExcel(grdProjetos);
                    break;
            }
        }
        private void btnSair_Click(object sender, EventArgs e) {
            GerenciarCampos grCampos = new GerenciarCampos();
            if (grCampos.ConfirmaSair())
                Close();
        }

        private void mnuApagar_Click(object sender, EventArgs e) {
            btnApagar.PerformClick();
        }
        private void mnuEditar_Click(object sender, EventArgs e) {
            btnEditar.PerformClick();
        }

        private void grdAreas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                grdAreas.CurrentCell = grdAreas[e.ColumnIndex, e.RowIndex];
        }
        private void grdColaboradores_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                grdColaboradores.CurrentCell = grdColaboradores[e.ColumnIndex, e.RowIndex];
        }
        private void grdProjetos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                grdProjetos.CurrentCell = grdProjetos[e.ColumnIndex, e.RowIndex];
        }
        private void grdTiposProjetos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                grdTiposProjetos.CurrentCell = grdTiposProjetos[e.ColumnIndex, e.RowIndex];
        }

        private void tbpAreas_Enter(object sender, EventArgs e) {
           
            preencherGridView(DBOrganizacaoSys.lstAreas, grdAreas);
        }
        private void tbpColaboradores_Enter(object sender, EventArgs e) {
            preencherGridView(cs.ListarColaboradores(), grdColaboradores);
        }
        private void tbpProjetos_Enter(object sender, EventArgs e) {
            preencherGridView(DBOrganizacaoSys.lstProjetos, grdProjetos);
        }
        private void tbpTipoProjetos_Enter(object sender, EventArgs e) {
            preencherGridView(DBOrganizacaoSys.lstTipoProjeto, grdTiposProjetos);
        }
        private void FrmConsultar_Activated(object sender, EventArgs e) {
            txtBusca.Text = "";
            btnBuscar.PerformClick();
            lblResultaoBusca.Text = "";
        }
        #endregion

        private void preencherGridView<T>(List<T> data, DataGridView grd) {
            var source = new BindingSource(data, null);
            grd.DataSource = source;
        }
    }
}