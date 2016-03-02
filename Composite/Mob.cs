using System;
using System.Collections.Generic;

namespace Composite
{
    public class Mob : IMeerkovan
    {
        public string Name { get; set; }

        public List<IMeerkovan> Members { get; set; }

        public Mob()
        {
            Members = new List<IMeerkovan>();
        }

        public void InviteMyMostStupendousParty()
        {
            Console.WriteLine("To all the meerkat in {0}", Name);

            foreach (var meerkat in Members)
            {
                meerkat.InviteMyMostStupendousParty();
                Console.WriteLine();
            }
        }
    }
}