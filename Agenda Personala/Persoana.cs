using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Agenda_Personala
{
    class Persoana
    {
        private string Nume;
        private string Prenume;
        public List<Activitate>ListaActivitati{get;set;}
        public string CrearePersoana(string Nume,string Prenume)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
                if (!string.IsNullOrWhiteSpace(Nume) && !string.IsNullOrWhiteSpace(Prenume)) return Nume + " " + Prenume;
                else return ("Nume sau Prenume Invalid");
                
           
            
            
        }
    }
}
