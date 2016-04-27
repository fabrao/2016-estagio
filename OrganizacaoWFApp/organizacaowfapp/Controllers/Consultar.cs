using OrganizacaoWFApp.Entidades;
using OrganizacaoWFApp.DataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class Consultar {
        public List<Colaborador> ListarColaboradores() {
            //ColaboradorRepositorio colaboradorRepo = new ColaboradorRepositorio();
            //return colaboradorRepo.ListarTodos().ToList();
            return DBOrganizacaoSys.lstColaboradores;
        }

        #region LIST_ENTITY_NAMES
        public static List<string> LstNomesColaboradores(DateTime param) {
            List<Colaborador> lstColab = DBOrganizacaoSys.lstColaboradores.FindAll(Colaborador => Colaborador.DataEntrada.CompareTo(param) <= 0);
            List<string> lstNomesColab = new List<string>();
            foreach (var n in lstColab) 
                lstNomesColab.Add(n.Nome);
            return lstNomesColab;
        }
        public static List<string> LstNomesAreas() {
            List<string> lstNomesAreas = new List<string>();
            foreach (var n in DBOrganizacaoSys.lstAreas) {
                lstNomesAreas.Add(n.Nome);
            }
            return lstNomesAreas;
        }
        public static List<string> LstNomesTiposProjetos() {
            List<string> lstNomesTiposProjetos = new List<string>();
            foreach (var n in DBOrganizacaoSys.lstTipoProjeto) {
                lstNomesTiposProjetos.Add(n.Nome);
            }
            return lstNomesTiposProjetos;
        }
        #endregion

        #region SEARCH_ENTITY_INDEX
        public int IndexOfEntity(Colaborador param) {
            int index = DBOrganizacaoSys.lstColaboradores.FindIndex(Colaborador => Colaborador.Id == param.Id);
            return index;
        }
        public int IndexOfEntity(Area param) {
            int index = DBOrganizacaoSys.lstAreas.FindIndex(Area => Area.Id == param.Id);
            return index;
        }
        public int IndexOfEntity(TipoProjeto param) {
            int index = DBOrganizacaoSys.lstTipoProjeto.FindIndex(TipoProjeto => TipoProjeto.Id == param.Id);
            return index;
        }
        public int IndexOfEntity(Projeto param) {
            int index = DBOrganizacaoSys.lstProjetos.FindIndex(Projeto => Projeto.Id == param.Id);
            return index;
        }
        #endregion

        #region SEARCH_ENTITY_NAME
        public List<Colaborador> ColaboadorNameSearch(string param, Label result) {
            List<Colaborador> lst = new List<Colaborador>();
            lst = DBOrganizacaoSys.lstColaboradores.FindAll(Colaborador => Colaborador.Nome.IndexOf(param, StringComparison.OrdinalIgnoreCase) >= 0);
            result.Text = lst.Count + "  resultado(s)";
            return lst;
        }
        public List<Area> AreaNameSearch(string param, Label result) {
            List<Area> lst = new List<Area>();
            lst = DBOrganizacaoSys.lstAreas.FindAll(Area => Area.Nome.IndexOf(param, StringComparison.OrdinalIgnoreCase) >= 0);
            result.Text = lst.Count + "  resultado(s)";
            return lst;
        }
        public List<TipoProjeto> TipoProjetoNameSearch(string param, Label result) {
            List<TipoProjeto> lst = new List<TipoProjeto>();
            lst = DBOrganizacaoSys.lstTipoProjeto.FindAll(TipoProjeto => TipoProjeto.Nome.IndexOf(param, StringComparison.OrdinalIgnoreCase) >= 0);
            result.Text = lst.Count + "  resultado(s)";
            return lst;
        }
        public List<Projeto> ProjetoNameSearch(string param, Label result) {
            List<Projeto> lst = new List<Projeto>();
            lst = DBOrganizacaoSys.lstProjetos.FindAll(Projeto => Projeto.Nome.IndexOf(param, StringComparison.OrdinalIgnoreCase) >= 0);
            result.Text = lst.Count + "  resultado(s)";
            return lst;
        }
        #endregion
    }
}