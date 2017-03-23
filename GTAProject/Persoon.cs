using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAProject
{
    class Persoon
    {
        private bool heeftRijbewijs = false;
        public Persoon(bool heeftRijbewijs)
        {
            this.heeftRijbewijs = heeftRijbewijs;
            if (heeftRijbewijs == true)
            {
                Console.WriteLine("Er werd een nieuwe persoon met een rijbewijs!");
            }
            if (heeftRijbewijs == false)
            {
                Console.WriteLine("Er werd een nieuwe persoon zonder rijbewijs!");
            }
        }
        public virtual void Rijd()
        {
            Console2.WriteLine(" rijdt");gf
        }

    }
}
