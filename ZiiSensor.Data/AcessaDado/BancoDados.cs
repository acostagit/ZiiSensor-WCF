using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZiiSensor.Data.AcessaDados
{
    public class BancoDados
    {
        static string strConn = ConfigurationManager.ConnectionStrings["connSensorDev"].ConnectionString;
        static MySqlConnection conexao = new MySqlConnection(strConn);

        private String _stringConexao = null;
        protected string ConsultarStringConexao()
        {
            if (this._stringConexao == null) _stringConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return _stringConexao;
        }

        public static void Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

        }

        public static void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }


        public static void ExecutarCommandoSQL(MySqlCommand cmd)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection.Open();
            var result = cmd.ExecuteNonQuery();
            var mensagem = "";
            if (result == 1)
            {
                mensagem = "Cadastra realizado com sucesso.";
            }
            else
            {
                mensagem = "Erro ao cadastrar. Consulte o Administrador do sistema.";
            }
        }
        //Conectar();
        //public SqlConnection Conectar()
        //{        
        //    var strConn = ConfigurationManager.ConnectionStrings["connSensorDevBanco"].ConnectionString;
        //    SqlConnection conexao = new SqlConnection(strConn);

        //    if (conexao.State == System.Data.ConnectionState.Closed)
        //    {
        //        conexao.Open();
        //    }

        //    return conexao;
        //}



        ////Desconectar();
        //public void Desconectar()
        //{

        //}
        //ExecutaComandoSQL(string procedure)

        ///////////////////////////////////////////////// OUTRA FORMA DE FAZER

    }
}
