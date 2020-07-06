using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLicitatii
{
    public class Oferta

    {
        public string denumireProdus;
        public float pret;
        public int cod;

        public Oferta(int cod, float pret, string denumireProdus)
        {
            this.cod = cod;
            this.pret = pret;
            this.denumireProdus = denumireProdus;

        }

        
        public string DenumireProdus
        {
            get { return denumireProdus; }

            set
            {
                if (value != null)
                    denumireProdus = value;
            }
       
        }


        public float Pret
        {
            get { return pret; }
            set
            {
                if (value > 0)
                    pret = value;
            }

        }

        public int Cod
        {
            get { return cod; }
            set
            {
                if (value > 0)
                    cod = value;
                    
            }
        }


        public override string ToString()
        {
            return "Codul produsului este " + cod + "cu pretul " + pret + " si denumirea " + denumireProdus;
        }

    }
}
