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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TemperaturaServico : ITemperaturaServico
    {
        private ZiiSensor.Data.Dado.TemperaturaDado _temperaturaDado;

        private ZiiSensor.Data.Dado.TemperaturaDado TemperaturaDado
        {
            get
            {
                if (_temperaturaDado == null) _temperaturaDado = new ZiiSensor.Data.Dado.TemperaturaDado();
                return _temperaturaDado;
            }
        }

        public void Adicionar(TemperaturaTO temperaturaDTO)
        {
            ZiiSensor.Data.AcessaDados.BancoDados.Conectar();
        }

        public List<TemperaturaTO> ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        ////[WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Todos")]
        //[WebGet(
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "todos")]

        // [WebGet(UriTemplate = "/Todos?format=json", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "*", UriTemplate = "/todos",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        public List<TemperaturaTO> ObterTodos()
        {
            var retorno = TemperaturaDado.ObterTodos();

            return retorno;
        }
    }
}
