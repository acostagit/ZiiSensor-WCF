using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSensor.Contratos.Usuario;
using ZiiSensor.Data.Dado.Interface;

namespace ZiiSensor.Data.Dado
{
    public class UsuarioDado : IUsuarioServiceDado
    {
        public void Adicionar(UsuatioDTO usuario)
        {
            try
            {
                AcessaDados.BancoDados.Conectar();

                MySqlCommand cmd = new MySqlCommand("spr_adicionar_usuario");
                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);
                cmd.Parameters.AddWithValue("@idperfil", usuario.IDPerfil);

                AcessaDados.BancoDados.ExecutarCommandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar Banco de Dados." + ex.Message);
            }
            finally
            {
                AcessaDados.BancoDados.Desconectar();
            }
        }

        public List<UsuatioDTO> ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuatioDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public UsuatioDTO ObterPorLoginSenha(string login, string senha)
        {
            UsuatioDTO usuario = new UsuatioDTO()
            {
                ID=1,
                Ativo = true,
                IDPerfil= 1,
                Login = login,
                Senha = senha
            };
            return usuario;
        }
    }
}
