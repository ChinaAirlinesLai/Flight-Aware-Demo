using Getting_Started.FlightAwareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Started
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                FlightXML2SoapClient client = new FlightXML2SoapClient();

                // Treat the test certificate as trusted
                client.ClientCredentials.UserName.UserName = "MyUserName";
                client.ClientCredentials.UserName.Password = "MyPassword";

                EnrouteStruct r = client.Enroute("KAUS", 10, "", 0);
                foreach (EnrouteFlightStruct e in r.enroute)
                {
                    System.Console.WriteLine(e.ident);
                }

                System.Console.WriteLine(client.Metar("KAUS"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

            Console.WriteLine("...");
            Console.ReadLine();
        }
    }
}
