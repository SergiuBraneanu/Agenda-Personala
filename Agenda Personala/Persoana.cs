using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Personala
{


    class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<Activitate>ListaActivitati{get;set;}
        public string FullName
        {
            get 
            {
                if (!string.IsNullOrWhiteSpace(Nume) && !string.IsNullOrWhiteSpace(Prenume)) return Nume + " " + Prenume;
                else return ("Nume sau Prenume Invalid");
            }
        }
    }
}
