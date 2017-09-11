using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSensor.Contratos.Usuario;
using ZiiSensor.Data.Dado.Interface;

namespace ZiiSensor.Negocio
{
    //Data.AcessaDados.BancoDados 
    public class Usuario: IUsuarioServiceDado
    {
        private Data.Dado.UsuarioDado dado = null;


        public Usuario()
        {
            dado = new Data.Dado.UsuarioDado();
        }

        public void Adicionar(UsuatioDTO temperaturaDTO)
        {
            throw new NotImplementedException();
        }

        public List<UsuatioDTO> ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        public UsuatioDTO ObterPorLoginSenha(string login, string senha)
        {
            return dado.ObterPorLoginSenha(login, senha);
        }

        public List<UsuatioDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
