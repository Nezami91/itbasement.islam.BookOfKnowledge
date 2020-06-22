using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Instrument.ICP01.datatrasnfer
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("#Transfering data..."); //1



            while (true) // 2
            {
                new Service.ICPServicer().TransferData(); // 3
                Thread.Sleep(1000 * 60 * 10); // 4
                //System.Console.ReadLine();
            }


        } 
    }
}
