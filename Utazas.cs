using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasCLI
{
    class Utazasok
    {
        public int Id { get; set; }
        public string Orszag { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Hossz { get; set; }
        public int Ar { get; set; }
        public string Ellatas { get; set; }

        public Utazasok(int id, string orszag, int honap, int nap, int hossz, int ar, string ellatas)
        {
            this.Id = id;
            this.Orszag = orszag;
            this.Honap = honap;
            this.Nap = nap;
            this.Hossz = hossz;
            this.Ar = ar;
            this.Ellatas = ellatas;
        }

        public Utazasok(string line, char delimiter = ',')
        {
            List<string> splitLine = line.Split(delimiter).ToList();
            this.Id = Convert.ToInt32(splitLine[0]);
            this.Orszag = splitLine[1];
            this.Honap = Convert.ToInt32(splitLine[2]);
            this.Nap = Convert.ToInt32(splitLine[3]);
            this.Hossz = Convert.ToInt32(splitLine[4]);
            this.Ar = Convert.ToInt32(splitLine[5]);
            this.Ellatas = splitLine[6];
        }
    }
}