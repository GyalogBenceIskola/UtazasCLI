using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtazasCLI;

namespace UtazasCLI
{
    class UtazasRepository
    {
        public static string Path { get; set; }
        public static char Delimiter { get; set; } = ',';
        public static bool SkipHeader { get; set; }

        public static List<Utazasok> FindAll()
        {
            StreamReader r = new StreamReader(Path, true);
            if (SkipHeader) { r.ReadLine(); }

            List<Utazasok> adatok = new List<Utazasok> { };

            while (!r.EndOfStream)
            {
                adatok.Add(new Utazasok(r.ReadLine(), Delimiter));
            }
            return adatok;
        }

    }
}