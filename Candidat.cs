using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLicitatii
{
    public class Candidat : ICloneable
    {
        private int idCandidat;
        private string nume;
        private string prenume;

        private string numarTelefon;
        private string adresa;
        private string gen;


        public Candidat(int idCandidat, string nume, string prenume,
        string numarTelefon, string adresa, string gen)
        {
            this.idCandidat = idCandidat;
            this.nume = nume;
            this.prenume = prenume;
            this.numarTelefon = numarTelefon;
            this.adresa = adresa;

            this.gen = gen;


        }

        public Candidat()
        {
        }

        public int IdCandidat
        {
            get { return idCandidat; }
            set
            {
                if (value > 0)
                    idCandidat = value;

            }
        }



        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value != null)
                    prenume = value;
            }
        }


        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value != null)
                    adresa = value;
            }
        }

        public string NumarTelefon
        {

            get { return numarTelefon; }

            set
            {
                if (value != null)
                    numarTelefon = value;
            }
        }

        public string Gen
        {
            get { return gen; }
            set
            {
                if (value != null)
                    gen = value;
            }

        }
        public object Clone()
        {
            Candidat clona = (Candidat)this.MemberwiseClone();

            clona.nume = this.nume;
            clona.adresa = this.adresa;
            clona.numarTelefon = this.numarTelefon;

            return clona;
        }


        public override string ToString()
        {
            return nume + ", " + adresa + ", numar de telefon: " + numarTelefon;
        }


    }

}
