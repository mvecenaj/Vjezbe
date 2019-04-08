using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.labos
{
    class Film
    {
        public string naziv;
        public int godina;
        public List<Glumci> ListaGlumaca = new List<Glumci>();

        public void film(string naziv, int godina) {
            this.naziv = naziv;
            this.godina = godina;
        }

        public string IspisivanjeNaziva() {
            return naziv;
        }

        public int IspisivanjeGodina()
        {
            return godina;
        }

        public void IspisivanjeGlumaca()
        {
            foreach (Glumci glumac in ListaGlumaca)
            {
                Console.WriteLine(glumac.ime, glumac.prezime);
            }
        }



        public void DodavanjeGlumaca() {
            Glumci glumac = new Glumci();
            Console.WriteLine("Ime glumca: ");
            glumac.ime = Console.ReadLine();
            Console.WriteLine("Prezime glumca: ");
            glumac.prezime = Console.ReadLine();
            ListaGlumaca.Add(glumac);
        }

        public bool PretrazivanjeGlumaca(string ime, string prezime) {
            foreach (Glumci glumac in ListaGlumaca) {
                if (glumac.ime == ime && glumac.prezime == prezime) {
                    return true;
                }
            }
            return false;
            //throw new Exception("Ne postoji film u kojem glumi uneseni glumac");
        }
    }
}
