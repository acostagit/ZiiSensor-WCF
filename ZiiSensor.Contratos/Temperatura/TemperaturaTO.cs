using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSensor.Contratos.Temperatura
{
    [DataContract]
    public class TemperaturaTO
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int IDDispositivo { get; set; }

        [DataMember]
        public DateTime DataHoraInclusao { get; set; }

        [DataMember]
        public int TemperaturaMaxima { get; set; }

        [DataMember]
        public int TemperaturaMinima { get; set; }

        [DataMember]
        public int TemperaturaAtual { get; set; }

        [DataMember]
        public int Humidade { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public double Altitude { get; set; }
    }
}
