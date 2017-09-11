using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ZiiSensor.Contratos.Temperatura;

namespace ZiiSensor.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITemperaturaService" in both code and config file together.
    [ServiceContract]
    public interface ITemperaturaService
    {
        [OperationContract]
        void Adicionar(TemperaturaTO temperaturaDTO);

        [OperationContract]
        IEnumerable<TemperaturaTO> ObterTodos();

        [OperationContract]
        IEnumerable<TemperaturaTO> ObterPorId(int id);
    }
}
