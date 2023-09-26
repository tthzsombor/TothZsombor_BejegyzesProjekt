using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TothZsombor_BejegyzesProjekt
{
    internal class Feladatok
    {

        private List<Bejegyzes> bejegyzes;
        private List<Bejegyzes> beir;

        public Feladatok()
        {
           beir = new List<Bejegyzes>();
           bejegyzes = new List<Bejegyzes>();
           Beker();
           Beolvas();
           Likekiosztas();
           Bejegyzesmodositas();
           Kiir();
           Legnepszerubb();
           Liketobbmint();
           Kevesebblike();

        }

        public void Beker()
        {

            Console.Write("Adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 1 != 0)
            {
                Console.WriteLine("Természetes számot adjon meg");
            }
            else
            {
                for (int i = 0; i < szam; i++)
                {
                    Console.Write("Adja meg a bejegyzés szerzőjét: ");
                    string szerzo = Console.ReadLine();
                    Console.Write("Adja meg a bejegyzés tartalmát: ");
                    string tartalom = Console.ReadLine();
                    Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                    beir.Add(b);
                }
            }
        }

        private void Beolvas()
        {
            StreamReader sr = new StreamReader("bejegyzesek.cvs");
            while (!sr.EndOfStream)
            {
                string [] adatok = sr.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                int likeok = int.Parse(adatok[2]);
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                beir.Add(b);



            }
        }

        private void Likekiosztas()
        {
            Random r= new Random();
            int szam = 0;
            for (int i = 0; i < beir.Count*20; i++)
            {
                szam=r.Next(0, beir.Count);
                beir[szam].Like();

            }
            for (int i = 0;i < beir.Count;i++)
            {
                Console.WriteLine(beir[i].ToString());
            }
        }

        private void Bejegyzesmodositas()
        {
            Console.WriteLine("Adjon meg egy bejegyzés szöveget: ");
            string ujbejegyzes = Console.ReadLine();

            bejegyzes[1].Tartalom=ujbejegyzes;

           
        }


        private void Kiir()
        {
            for (int i = 0; i < beir.Count; i++)
            {
                Console.WriteLine(beir[i]);
            }
        }

        private void Legnepszerubb()
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < beir.Count; i++)
            {
                if (beir[i].Likeok>max)
                {
                    max = beir[i].Likeok;
                    index= i;
                }
            }
            Console.WriteLine(beir[index].Likeok);
        }

        private void Liketobbmint()
        {
            int darab = 0;
            for (int i = 0; i < beir.Count; i++)
            {
                if (beir[i].Likeok>35)
                {
                    darab++;
                }
            }
            if (darab>0)
            {
                Console.WriteLine("35-nél több likos posztok száma: {0}", darab);
            }
            else
            {
                Console.WriteLine("Nincs olyan poszt, ami 35 likenél nagyobb. ");
            }
        }

        private void Kevesebblike()
        {
            int darab = 0;

            for (int i = 0; i < beir.Count; i++)
            {
                if (beir[i].Likeok<15)
                {
                    darab++;
                }
            }
            Console.WriteLine(darab);
        }

        private void Csokkeno()
        {
            for (int i = 0; i < beir.Count; i++)
            {
                for (int j = 0; j < beir.Count; j++)
                {
                    if (beir[i].Likeok > beir[j].Likeok)
                    {
                        Bejegyzes valtozo = beir[i];
                        beir[i] = beir[j];
                        beir[j] = valtozo;
                    }
                }
            }
        }

    }
}
