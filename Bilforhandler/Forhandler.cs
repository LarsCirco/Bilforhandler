using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    internal class Forhandler
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public List<Bil> Biler { get; set; }


        public Forhandler()
        {
            Biler = new List<Bil>();
        }

        public Forhandler( string name, string adress)
        {
            Navn = name;
            Adresse = adress;
            Biler = new List<Bil>();
        }
        public void LeggTilBil(Bil bil)
        {
            Biler.Add(bil);
      
        }

        public List<Bil> HentGamleBiler(int NumberOfYear)
        {
            int gjeldeneÅr = DateTime.Now.Year;
            return Biler.Where(bil => (gjeldeneÅr - bil.Year) > NumberOfYear).ToList();
        }

        public List<Bil> MerEnnYKm(int GreaterThanKm)
        {
            return Biler.Where(bil => (bil.Kilometers) > GreaterThanKm).ToList();
        }

        public void RemoveBil (string regNummer)
        {
            var SjekkeRegNummer = Biler.FirstOrDefault(bil => bil.Regnummer == regNummer);
            if (SjekkeRegNummer != null)
            {
                Biler.Remove(SjekkeRegNummer);
            }
            
        }
    }
}
