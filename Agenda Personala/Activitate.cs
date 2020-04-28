using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Personala
{
    class Activitate
    {
        public Activitate(string numeAc)
        {
            NumeAc = numeAc;
        }
        public string DataInceput { get; set; }
        public string DataSfarsit { get; set; }
        public string NumeAc { get; private set; }
    }
}
