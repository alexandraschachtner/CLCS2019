using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LastChanceCsharp
{
    public class Volunteer
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
        public string Licence { get; set; }

        public string Print() { return (First + " " + Last + " " + Phone + " " + Licence); }
        public string Convert() { return First + "," + Last + "," + Phone + "," + Licence; }

    }
}
