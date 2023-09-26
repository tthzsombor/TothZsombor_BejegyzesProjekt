﻿using System;
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

    }
}