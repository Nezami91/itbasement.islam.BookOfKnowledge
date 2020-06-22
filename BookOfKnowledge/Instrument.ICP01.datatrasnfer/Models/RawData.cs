using System;

namespace Instrument.ICP01.datatrasnfer.Models
{
    public class RawData
    {
        public int ID { get; set; }
        public string Analyse { get; set; }
        public float Resultat { get; set; }
        public int Blind { get; set; }
        public DateTime   CreateDate { get; set; }

    }
}