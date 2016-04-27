namespace OrganizacaoWFApp.DataBase {
    public class Usuario {
        public string Login { get; set; }
        public string Password { get; set; }

        public Usuario(string login, string password) {
            Login = login;
            Password = password;
        }
    }
}