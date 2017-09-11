using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZiiSensor.Contratos.Temperatura;

namespace ZiiSensor.UI.Temperatura
{
    public partial class Diario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ZiiSensor.Contratos.Temperatura.TemperaturaTO temperaturaTO = new Contratos.Temperatura.TemperaturaTO();
            //GeraGraficoSemanal();

            //if (temperaturas == null)
            //{
            //    Response.Redirect("Dashboard.aspx");
            //}

        }

        public TemperaturaTO[] GeraGraficoSemanal()
        {
            var resultado = "";
            List<TemperaturaTO> lista = new List<TemperaturaTO>();
            TemperaturaService.TemperaturaServicoClient client = new TemperaturaService.TemperaturaServicoClient();
            var temperaturas = client.ObterTodos();

            if (temperaturas != null)
            {
                return temperaturas;
                ////JavaScriptSerializer js = new JavaScriptSerializer();
                ////resultado = js.Serialize(temperaturas);
                ////return resultado;
            }
            else
            {
                throw new Exception("ERRO: Diario");
            }
             
            //return Json(resultado, JsonRequestBehavior.AllowGet);

        }
    }
}