using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleElasticSearch
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                _log.Info("console test log " + i);  
            }
            
        }
    }
}
