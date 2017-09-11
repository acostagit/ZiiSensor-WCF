using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSensor.Data.Dado.Interface
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity temperaturaDTO);

        List<TEntity> ObterTodos();

        List<TEntity> ObterPorID(int id);
    }
}
