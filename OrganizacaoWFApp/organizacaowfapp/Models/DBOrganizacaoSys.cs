using OrganizacaoWFApp.Entidades;
using System.Collections.Generic;

namespace OrganizacaoWFApp.DataBase {
    public class DBOrganizacaoSys {
        public static int contIdColaborador = 1;
        public static int contIdArea = 0;
        public static int contIdTipoProjeto = 0;
        public static int contIdProjeto = 0;

        public static List<Colaborador> lstColaboradores = new List<Colaborador>();
        public static List<Area> lstAreas = new List<Area>();
        public static List<TipoProjeto> lstTipoProjeto = new List<TipoProjeto>();
        public static List<Projeto> lstProjetos = new List<Projeto>();

        public static List<Usuario> lstUsuarios = new List<Usuario>();
    }
  
}