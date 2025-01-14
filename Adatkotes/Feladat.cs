using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatkotes
{
    internal class Feladat
    {
        public  int FeladatId { get; set; }
        public string? Leiras { get; set; }
        public DateTime Hatarido { get; set; }
        public bool Kesz { get; set;}
        public int Prioritas { get;set; }
        public bool Keso 
        {
            get
            {
                return Hatarido < DateTime.Now;
            }
        }
    }
}
