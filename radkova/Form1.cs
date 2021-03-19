using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radkova
{
    public partial class Form1 : Form
    {
        char[] ABC = new char[] { 'A', 'B', 'C', 'D', 'E', 'F',
                                      'G', 'H', 'I', 'J', 'K', 'L',
                                      'M', 'N', 'O', 'P', 'Q', 'R',
                                      'S', 'T', 'U', 'V', 'W', 'X',
                                      'Y', 'Z'};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Sifra = "marta je taková partička hehe".ToUpper();
            string[] RozdelenaSifra = Sifra.Split(' ');
            Sifra = "";
            for (int i = 0; i < RozdelenaSifra.Length; i++)
            {
                Sifra += RozdelenaSifra[i];
            }
            CharNo[] ABC = new CharNo[Sifra.Length];

        }

        private void copyRadkovka_Click(object sender, EventArgs e)
        {
            string Zalusteno = string.Empty;
            string kod = kodTB.Text;
            string[] zachyt = new string[kod.Length];
            int rad = 0;
            foreach (char Item in kod)
            {
                zachyt[rad] = (Convert.ToInt64(Item.ToString()) - 1).ToString();
                rad++;
            }
            int poradi = 0;
            int nasobic = kod.Length;
            string Sifra = RTB_Radkova.Text.ToUpper();
            while (Sifra.Length % kod.Length != 0)
            {
                Sifra += "x";
            }
            string[] a = Sifra.Split(' ');
            Sifra = "";
            for (int i = 0; i < a.Length; i++)
            {
                Sifra += a[i];
            }
            char[] Sifra_Znaky = Sifra.ToCharArray();
            for (int i = 0; i < Sifra_Znaky.Length; i++)
            {
                if (Convert.ToInt64(zachyt[poradi]) - kod.Length + nasobic > Sifra_Znaky.Length - 1)
                {
                    poradi += 1;
                    nasobic = kod.Length;
                }
                Zalusteno += Sifra_Znaky[Convert.ToInt32(zachyt[poradi]) - kod.Length + nasobic];
                nasobic += kod.Length;
            }
            //RTB_Radkova.Text = Zalusteno;
            Clipboard.SetText(Zalusteno);
        }

        private void copyPosunka_Click(object sender, EventArgs e)
        {
            string Sifra = RTB_Posunka.Text.ToUpper();
            string Zalusteno = string.Empty;
            int Posunuti = Convert.ToInt16(posunutiNUD.Value);
            int Pozice;
            bool strana = rightRB.Checked;
            string[] Slova_Sifry = Sifra.Split(' ');
            while (Posunuti > ABC.Length)
            {
                Posunuti -= ABC.Length;
            }
            foreach (char Item in Sifra)
            {
                if (Item != ' ')
                {
                    Pozice = Array.IndexOf(ABC, Item);
                    if (strana)
                    {
                        if (Pozice - Posunuti < 0) Zalusteno += $"{ABC[(Pozice - Posunuti) + ABC.Length]}";
                        else Zalusteno += $"{ABC[(Pozice - Posunuti)]}";
                    }
                    else
                    {
                        if (Pozice + Posunuti < ABC.Length) Zalusteno += $"{ABC[Pozice + Posunuti]}";
                        else Zalusteno += $"{ABC[(Pozice + Posunuti) - ABC.Length]}";
                    }
                }
                else Zalusteno += ' ';
            }
            //RTB_Posunka.Text = Zalusteno;
            Clipboard.SetText(Zalusteno);
        }

        private void RTB_Radkova_TextChanged(object sender, EventArgs e)
        {
            string[] Slova = RTB_Radkova.Text.Split(' ');
            int pocetznaku = 0;
            for (int i = 0; i < Slova.Length; i++)
            {
                foreach (char Item in Slova[i])
                {
                    pocetznaku++;
                }
            }
            numberofchars.Text = pocetznaku.ToString();
        }

        private void copyLogickaCisla_Click(object sender, EventArgs e)
        {
            string Sifra = RTB_logickaCisla.Text.ToUpper();
            int Pozice;
            string[] RozdelenaSifra = Sifra.Split(' ');
            int KdyPrestat = RozdelenaSifra.Length;
            int UzPrestat = 0;
            Sifra = "";
            foreach (string Slovo in RozdelenaSifra)
            {
                foreach (char Item in Slovo)
                {
                    KdyPrestat = Slovo.Length - 1;
                    Pozice = Array.IndexOf(ABC, Item);
                    Sifra += $"{(UzPrestat == KdyPrestat ? $"{Pozice}=" : $"{Pozice}+")}";
                    UzPrestat++;
                }
                UzPrestat = 0;
            }
            Clipboard.SetText(Sifra);
        }
    }
}
