using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAProject
{
    class Brommer : Voertuig
    {
        public Brommer() : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De brommer rijdt...", ConsoleColor.Yellow);
        }
    }
}
