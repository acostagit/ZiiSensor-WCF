using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSensor.Contratos.Temperatura;
using ZiiSensor.Data.AcessaDado;
using ZiiSensor.Data.Dado.Interface;

namespace ZiiSensor.Data.Dado
{
    public class TemperaturaDado : ITemperaturaServiceDado
    {

        public void Adicionar(TemperaturaTO temperaturaTO)
        {
            try
            {
                AcessaDados.BancoDados.Conectar();

                MySqlCommand cmd = new MySqlCommand("spr_adicionar_usuario");
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

        public List<TemperaturaTO> ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TemperaturaTO> ObterTodos()
        {
            List<TemperaturaTO> lista = null; // new List<TemperaturaTO>();

            lista = new List<TemperaturaTO>()
            {
                new TemperaturaTO {  ID = 1,
                TemperaturaAtual = 21,
                TemperaturaMaxima = 30,
                TemperaturaMinima = 19,
                DataHoraInclusao = DateTime.Now,
                IDDispositivo = 1,
                Altitude = -23.6938900,
                Longitude = -21.5847500,
                Latitude = -20.9434290,
                Humidade = 18
                },
                new TemperaturaTO()
                {
                     ID = 2,
                TemperaturaAtual = 23,
                TemperaturaMaxima = 28,
                TemperaturaMinima = 21,
                DataHoraInclusao = DateTime.Now,
                IDDispositivo = 1,
                Altitude = -23.65345500,
                Longitude = -21.5832200,
                Latitude = -20.94342300,
                Humidade = 19
                }

            };


            //Apenas para criar o banco
            ////using (MySqlCommand sqlCommand = new MySqlCommand())
            ////{
            ////    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            ////    sqlCommand.CommandText = "spr_TemperaturaConsultar";

            ////    using (MySqlConnection sqlConnection = new MySqlConnection(ConsultarStringConexao()))
            ////    {
            ////        sqlCommand.Connection = sqlConnection;
            ////        sqlConnection.Open();
            ////        MySqlDataReader dr = sqlCommand.ExecuteReader();
            ////        while (dr.Read())
            ////        {
            ////            TemperaturaTO temperatura = new TemperaturaTO();
            ////            temperatura = ConverterDataReaderParaObjeto(dr);
            ////            lista.Add(temperatura);

            ////        }
            ////    }
            ////}


            return lista;
        }

        private TemperaturaTO ConverterDataReaderParaObjeto(MySqlDataReader dr)
        {
            TemperaturaTO temperatura = new TemperaturaTO();
            temperatura.ID = Convert.ToInt32(dr["ID"]);
            temperatura.IDDispositivo = Convert.ToInt32(dr["IDDispositivo"]);
            temperatura.DataHoraInclusao = Convert.ToDateTime(dr["DataHora"]);
            temperatura.TemperaturaAtual = Convert.ToInt32(dr["TemperaturaAtual"]);
            temperatura.TemperaturaMaxima = Convert.ToInt32(dr["TemperaturaMaxima"]);
            temperatura.TemperaturaMinima = Convert.ToInt32(dr["TemperaturaMinima"]);
            temperatura.Humidade = Convert.ToInt32(dr["Humidade"]);
            temperatura.Latitude = Convert.ToInt32(dr["Latitude"]);
            temperatura.Longitude = Convert.ToInt32(dr["Longitude"]);
            temperatura.Altitude = Convert.ToInt32(dr["Altitude"]);
            return temperatura;
        }
    }
}
