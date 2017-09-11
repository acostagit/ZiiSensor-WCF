using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZiiSensor.Contratos.Temperatura;

namespace ZiiSolution.SensorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITemperaturaServico
    {
        [OperationContract]
        void Adicionar(TemperaturaTO temperaturaDTO);

        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Temperatura")]
        List<TemperaturaTO> ObterTodos();

        [OperationContract]
        List<TemperaturaTO> ObterPorID(int id);
    }   
}
