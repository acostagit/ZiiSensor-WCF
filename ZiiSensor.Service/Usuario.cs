using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZiiSensor.Contratos.Usuario;
using ZiiSensor.Data.Dado.Interface;

namespace ZiiSensor.Service
{
    public class Usuario : IUsuarioServiceDado
    {
        Data.Dado.UsuarioDado usuario = new Data.Dado.UsuarioDado();

        public void Adicionar(UsuatioDTO temperaturaDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuatioDTO> ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        public UsuatioDTO ObterPorLoginSenha(string login, string senha)
        {
            try
            {
                return usuario.ObterPorLoginSenha(login, senha);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<UsuatioDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}