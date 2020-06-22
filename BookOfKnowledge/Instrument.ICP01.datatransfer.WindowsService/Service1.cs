using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Instrument.ICP01.datatransfer.WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            new Instrument.ICP01.datatrasnfer.Service.ICPServicer().TransferData();

        }

        protected override void OnStop()
        {
        }
    }
}
