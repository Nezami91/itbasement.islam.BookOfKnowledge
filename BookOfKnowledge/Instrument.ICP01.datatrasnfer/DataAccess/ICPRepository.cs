using Instrument.ICP01.datatrasnfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrument.ICP01.datatrasnfer.DataAccess
{
    public class ICPRepository
    {

        List<Models.RawData> listOfRawData = new List<Models.RawData>();
            
        public List<Models.RawData> GetRawData() {

            Models.RawData rawData1 = new Models.RawData 
            { 
                Id = 1,
                Analyse = "vand",
                Resultat = 3.5f,
                CreateDate = DateTime.Now
            };
            listOfRawData.Add(rawData1);
            
            Models.RawData rawData2 = new Models.RawData
            {
                Id = 2,
                Analyse = "jord",
                Resultat = 2.5f,
                CreateDate = DateTime.Now
            };
            listOfRawData.Add(rawData2);
            
            Models.RawData rawData3 = new Models.RawData
            {
                Id = 3,
                Analyse = "træ",
                Resultat = 4.5f,
                CreateDate = DateTime.Now
            };
            listOfRawData.Add(rawData3);

            return listOfRawData;      
        }

        public List<Models.RawData> SaveDataToDB(List<Models.RawData> rawDataList)
        {
            var listFromDB = GetRawData();

            foreach (var item in rawDataList)
            {
                listFromDB.Add(item);
            }

            return listFromDB;
        }

    }
}
