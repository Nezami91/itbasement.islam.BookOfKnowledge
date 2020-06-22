using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrument.ICP01.datatrasnfer.Service
{
    public class ICPServicer
    {
        public void TransferData() {

            var listOfRawData = new DataAccess.ICPRepository().GetRawData();

            foreach (var item in listOfRawData)
            {

                // gem i databasen


            }

        
        }

    }
}
