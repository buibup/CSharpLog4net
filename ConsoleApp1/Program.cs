using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator()]
namespace ConsoleApp1
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log4net.GlobalContext.Properties["AppName"] = Assembly.GetExecutingAssembly().FullName;


            _log.Info("App Started");

            try
            {
                throw new Exception("A fatal error as occurred.");
            }
            catch (Exception ex)
            {
                _log.Fatal("Fatal Error: ", ex);
            }

            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
        }
    }
}
