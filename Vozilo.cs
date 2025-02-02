﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaProvjeru
{
    internal class Vozilo
    {
        String vrsta, naziv, marka;
        DateTime GodPro;
        int snaga;

        public Vozilo(string vrsta, string naziv, string marka, DateTime godPro, int snaga)
        {
            this.vrsta = vrsta;
            this.naziv = naziv;
            this.marka = marka;
            GodPro = godPro;
            this.snaga = snaga;
        }

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Marka { get => marka; set => marka = value; }
        public DateTime GodPro1 { get => GodPro; set => GodPro = value; }
        public int Snaga { get => snaga; set => snaga = value; }

        public override string ToString()
        {
            String ispis = "Vrsta: " + this.Vrsta + "\nMarka: " + this.Marka + "\nNaziv: " + this.Naziv + "\nGodina proizvodnje: " + this.GodPro.Year
                + "\nSnaga: " + this.Snaga + " KS";
            return ispis;
        }
    }
}
