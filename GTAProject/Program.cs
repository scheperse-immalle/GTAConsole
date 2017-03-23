using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAProject
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Voertuig v = new Auto();
            Voertuig truck = new Vrachtwagen();
            Persoon Julie = new Persoon(true);
            Voertuig brommer = new Brommer();
            v.Rij();
            truck.Rij();
            brommer.Rij();
            Julie.Rijd();

            
        }
    }
}
