using CutCraftEngineData.DataInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData
{
    internal class CutterEngineService
    {
        public CutterEngineService(string websocketEcho, string serviceName) 
        {
            Command command = new Command().Deserialize<Command>(websocketEcho);
            // from di get service by name with interface ICalculator


        }
    }
}
