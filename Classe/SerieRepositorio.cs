using CrudSeriesDio.Interface;
using System.Collections.Generic;

namespace CrudSeriesDio.Classe
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();

        public void Delete(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insert(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        public void Update(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }
    }
}
