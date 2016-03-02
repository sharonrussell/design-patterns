using System;

namespace Composite
{
    public class Meerkat : IMeerkovan
    {
        public string Name { get; set; }

        public Meerkat(string name)
        {
            Name = name;
        }

        public void InviteMyMostStupendousParty()
        {
            Console.WriteLine("Fellow Meerkovan {0} please come to most stupendous party at house of Aleksandr tomorromabob", Name);
        }
    }
}