using System.Collections.Generic;

namespace OrganizacaoWebSys.Models {
    public class Dbase {
        private static int contIdAreas;
        private static int contIdColaboradores;
        private static int contIdTiposProjetos;
        private static int contIdProjetos;
        private static List<Area> lstAreas = new List<Area>();
        private static List<Colaborador> lstColaboradores = new List<Colaborador>();
        private static List<TipoProjeto> lstTiposProjetos = new List<TipoProjeto>();
        private static List<Projeto> lstProjetos = new List<Projeto>();

        public static void Salvar(Colaborador param) {
            param.ID = contIdColaboradores;
            lstColaboradores.Add(param);
            contIdColaboradores++;
        }
        public static void Salvar(Area param) {
            param.ID = contIdAreas;
            lstAreas.Add(param);
            contIdAreas++;
        }
        public static void Salvar(TipoProjeto param) {
            param.ID = contIdTiposProjetos;
            lstTiposProjetos.Add(param);
            contIdTiposProjetos++;
        }
        public static void Salvar(Projeto param) {
            param.ID = contIdProjetos;
            lstProjetos.Add(param);
            contIdProjetos++;
        }

        public static List<Colaborador> ListarColaboradores() {
            return lstColaboradores;
        }
        public static List<Area> ListarAreas() {
            return lstAreas;
        }
        public static List<TipoProjeto> ListarTiposProjetos() {
            return lstTiposProjetos;
        }
        public static List<Projeto> ListarProjetos() {
            return lstProjetos;
        }

        public static void Remove(Colaborador param) {
            lstColaboradores.Remove(param);
        }
        public static void Remove(Area param) {
            lstAreas.Remove(param);
        }
        public static void Remove(TipoProjeto param) {
            lstTiposProjetos.Remove(param);
        }
        public static void Remove(Projeto param) {
            lstProjetos.Remove(param);
        }

        public static Area GetArea(int id) {
            Area model = new Area();
            model = lstAreas.Find(Area => Area.ID == id);
            return model;
        }
        public static Colaborador GetColaborador(int id) {
            Colaborador model = new Colaborador();
            model = lstColaboradores.Find(Colaborador => Colaborador.ID == id);
            return model;
        }
        public static TipoProjeto GetTipoProjeto(int id) {
            TipoProjeto model = new TipoProjeto();
            model = lstTiposProjetos.Find(TipoProjeto => TipoProjeto.ID == id);
            return model;
        }
        public static Projeto GetProjeto(int id) {
            Projeto model = new Projeto();
            model = lstProjetos.Find(Projeto => Projeto.ID == id);
            return model;
        }
    }
}