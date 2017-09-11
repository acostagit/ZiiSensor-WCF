using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ZiiSensor.Contratos.Temperatura;
using ZiiSensor.Data.Dado;

namespace ZiiSensor.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TemperaturaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TemperaturaService.svc or TemperaturaService.svc.cs at the Solution Explorer and start debugging.
   
    public class TemperaturaService : ITemperaturaService
    {
        private Data.Dado.TemperaturaDado _temperaturaDado;

        private Data.Dado.TemperaturaDado TemperaturaDado
        {
            get
            {
                if (_temperaturaDado == null) _temperaturaDado = new Data.Dado.TemperaturaDado();
                return _temperaturaDado;
            }
        }

        public void Adicionar(TemperaturaTO temperaturaDTO)
        {
            Data.AcessaDados.BancoDados.Conectar();
        }

        public IEnumerable<TemperaturaTO> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TemperaturaTO> ObterTodos()
        {
            return TemperaturaDado.ObterTodos();
        }
    }
}
