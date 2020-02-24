using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1
{
    class Adres
    {
        private string gorod = new string(' ', 20);
        private string ylica = new string(' ', 20);
        private int nomer_doma;

        public Adres()
        {
            this.gorod = "Город" ;
            this.ylica = "Улица" ;
            this.nomer_doma =0;
        }
        public Adres(string gorod, string ylica, int nomer_doma)
        {
            this.gorod = gorod;
            this.ylica = ylica;
            this.nomer_doma = nomer_doma;
        }
        public string Gorod
        {
            set
            {
                gorod = value;
            }
        }
        public string Ylica
        {
            set
            {
                ylica = value;
            }
        }
        public int Nomer_doma
        {
            set
            {
                nomer_doma = value;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Город - {0}; Улица -{1}; Номер дома - {2}.", gorod, ylica, nomer_doma);
        }
    }
}
