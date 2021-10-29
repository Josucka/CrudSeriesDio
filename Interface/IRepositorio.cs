using System.Collections.Generic;

namespace CrudSeriesDio.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insert(T entidade);

        void Delete(int id);

        void Update(int id, T entidade);

        int ProximoId();
    }
}
