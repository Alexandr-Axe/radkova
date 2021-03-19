using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radkova
{
    public class CharNo
    {
        public char Item { get; set; }
        public int ID { get; set; }
        public CharNo(char item, int id)
        {
            this.Item = item;
            this.ID = id;
        }
    }
    public class TelefonniCislo
    {
        public string Pismena { get; set; }
        public TelefonniCislo(string pismena)
        {
            this.Pismena = pismena;
        }
    }
    public class Telefon
    {
        public string ZalustiTelefon(string Sifra)
        {
            TelefonniCislo[] Cisla = new TelefonniCislo[] {
            new TelefonniCislo("ABC"),
            new TelefonniCislo("DEF"),
            new TelefonniCislo("GHI"),
            new TelefonniCislo("JKL"),
            new TelefonniCislo("MNO"),
            new TelefonniCislo("PQRS"),
            new TelefonniCislo("TUV"),
            new TelefonniCislo("WXYZ")
                                                         };
            string[] RozdelenaSifra = Sifra.Split(' ');
            Sifra = "";
            for (int i = 0; i < RozdelenaSifra.Length; i++)
            {
                Sifra += RozdelenaSifra[i];
            }
            char[] Znaky = Sifra.ToCharArray();
            return "";
        }
    }
}
