using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TothZsombor_BejegyzesProjekt
{
    internal class Bejegyzes
    {
       


        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott=new DateTime();
        private DateTime szerkesztve=new DateTime();
        private List<Bejegyzes> bejegyzes;
        private List<Bejegyzes> beir;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            likeok = 0;
            letrejott = DateTime.Today;
            szerkesztve = DateTime.Today;
            
        }

        public string Szerzo { get => szerzo; }
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok; }
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get => szerkesztve; }


        public void Like()
        {
            this.likeok++;
        }


        public override string ToString()
        {


            string tostring= $"{this.szerzo} - {likeok} - {this.letrejott} \nSzerkesztve: {this.szerkesztve} \n{this.tartalom}";

            if (this.letrejott==this.szerkesztve)
            {
                tostring = $"{this.szerzo} - {likeok} - {this.letrejott} \nSzerkesztve: {this.szerkesztve} \n{this.tartalom}";
            }
            else
            {
                tostring = $"{this.szerzo} - {likeok} - {this.letrejott} \n{this.tartalom}";
            }
            return tostring;
                  

        }

        public void Beker()
        {
           
            Console.Write("Adjon meg egy számot: ");
            int szam=int.Parse(Console.ReadLine());
            if (szam%1!=0)
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
                    Bejegyzes b1=new Bejegyzes(szerzo, tartalom);
                    beir.Add(b1);
                }
            }
        }

        private void Beolvas()
        {
            StreamReader sr=new StreamReader("bejegyzesek.cvs");
            while(!sr.EndOfStream)
            {
                string sor=sr.ReadLine();

            }
        }




    }



  
}
