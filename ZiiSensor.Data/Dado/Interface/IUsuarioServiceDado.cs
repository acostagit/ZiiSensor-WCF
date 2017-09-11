using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSensor.Contratos.Usuario;

namespace ZiiSensor.Data.Dado.Interface
{
    public interface IUsuarioServiceDado: IServicoBase<UsuatioDTO>
    {
        UsuatioDTO ObterPorLoginSenha(string login, string senha);
    }
}
