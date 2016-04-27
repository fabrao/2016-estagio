using OrganizacaoWFApp.DataBase;

namespace OrganizacaoWFApp.Controllers {
    public class VerificarLogin {
        public bool VerificaUser(string login, string pass) {
            Usuario user = new Usuario(login, pass);
            bool result = DBOrganizacaoSys.lstUsuarios.Exists(Usuario => Usuario.Login.Equals(user.Login) && Usuario.Password.Equals(user.Password));
            return result;
        }
    }
}
