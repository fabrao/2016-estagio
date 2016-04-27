using System.Collections.Generic;

namespace OrganizacaoWFApp.DataBase {
    public interface IRepositorio<T> where T: class {
        string Inserir(T entidade);
        string Deletar(T entidade);
        string Editar(T entidade);

        T BuscarID(int id);
        IEnumerable<T> ListarTodos();
    }
}
