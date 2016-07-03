using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imob.Site.Models.Repository
{
    public interface IRepository<T>
    {
        List<T> Obter();
        T Salvar(T obj);
        T Editar(T obj);
        T Excluir(T obj);

    }
}
