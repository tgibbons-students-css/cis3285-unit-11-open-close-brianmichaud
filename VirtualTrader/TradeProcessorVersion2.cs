using AbstractTrader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTrader
{
    class TradeProcessorVersion2 : ITradeProcessor
    {
        public void ProcessTrades(Stream stream)
        //public void ProcessTrades(string url)
        {
            LogMessage("INFO: Using Updated Trade Processor Version 2");
            base.ProcessTrades(stream);
        }
        protected void LogMessage(string message, params object[] args)
        {
            Console.WriteLine(message, args);
            // added for Request 408
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log>" + message + "</log>", args);
            }
        }
    }
}
