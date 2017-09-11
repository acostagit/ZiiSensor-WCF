using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSensor.Data.AcessaDado
{
    public class Base
    {
        static string strConn = ConfigurationManager.ConnectionStrings["connSensorDev"].ConnectionString;
        static MySqlConnection conexao = new MySqlConnection(strConn);

        private String _stringConexao = null;
        protected string ConsultarStringConexao()
        {
            if (this._stringConexao == null) _stringConexao = ConfigurationManager.ConnectionStrings["connSensorDev"].ConnectionString;
            return _stringConexao;
        }
    }
}
