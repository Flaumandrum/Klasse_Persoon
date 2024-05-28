using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Persoon
{
    public class Persoon
    {
        // Velden 
        String _voornaam = "John";
        String _achternaam = "Doe";

        // Properties (Eigenschappen)
        public String PropVoornaam
        {
            get { return _voornaam; } 
            set { _voornaam = value; }
        }

        public String PropAchternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        // Methoden 
        /// <summary>
        /// Deze functie stuurt de volledige naam (voornaam achternaam) terug
        /// </summary>
        /// <returns></returns>
        public String VolledigeNaam ()
        {
            return $"{_voornaam} {_achternaam}"; 
        }

        /// <summary>
        /// Deze functie stuurt het mailadres weer in de vorm voornaam.achternaam@romerocollege.be
        /// </summary>
        /// <returns></returns>
        public String Mailadres()
        {
            return $"{_voornaam}.{_achternaam}@romerocollege.be".ToLower();
        }

        // Constructors
        public Persoon() { }

        public Persoon(string vn, string an) 
        { 
            _voornaam = vn;
            _achternaam = an;
        }
    }
}
