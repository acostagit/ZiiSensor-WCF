using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ZiiSensor.UI.TemperaturaService;
using ZiiSolution.SensorService;

namespace ZiiSolution.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma Imperativa
            //using (ServiceHost host =  new ServiceHost(typeof(TemperaturaService), new Uri[] { new Uri("net.tcp://localhost:63793"), new Uri("http://localhost:63793") }))
            using (ServiceHost host = new ServiceHost(typeof(TemperaturaServico), new Uri[] { new Uri("http://localhost:63793") }))
            {
                host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });

                //host.AddServiceEndpoint(typeof(ITemperaturaService), new NetTcpBinding(), "srv");
                host.AddServiceEndpoint(typeof(ZiiSensor.UI.TemperaturaService.ITemperaturaServico), new BasicHttpBinding(), "srv");

                //WSDL
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

                host.Open();
                Console.ReadLine();
            }

            //Forma declarativa
            //using (ServiceHost host = new ServiceHost(typeof(TemperaturaService), new Uri[] { }))
            //{
            //    host.Open();
            //    Console.ReadLine();
            //}
        }
    }
}
