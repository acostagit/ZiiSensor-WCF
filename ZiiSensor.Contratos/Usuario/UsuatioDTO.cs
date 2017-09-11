using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSensor.Contratos.Usuario
{
    public class UsuatioDTO
    {
        public int ID { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public int IDPerfil { get; set; }


    }
}
