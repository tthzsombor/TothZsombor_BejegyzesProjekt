using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TothZsombor_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private List<Bejegyzes>lista1=new List<Bejegyzes>();
        private List<Bejegyzes> lista2 = new List<Bejegyzes>();


        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott=new DateTime();
        private DateTime szerkesztve=new DateTime();

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




    }



  
}
