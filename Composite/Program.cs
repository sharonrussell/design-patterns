using System;

namespace Composite
{
    public static class Program
    {
        public static void Main()
        {   
            var allVillagers = AllVillagers();
            allVillagers.InviteMyMostStupendousParty();

            Console.ReadLine();
        }

        private static Mob AllVillagers()
        {
            var maiya = new Meerkat("Maiya");
            var vassily = new Meerkat("Vassily");
            var yakov = new Meerkat("Yakov");

            var sergeiFamily = CreateSergeiFamily();
            var bogdanFamily = CreateBogdanFamily();

            var allVillagers = new Mob
            {
                Name = "All villagers",
                Members = {maiya, vassily, yakov, sergeiFamily, bogdanFamily}
            };

            return allVillagers;
        }

        private static Mob CreateBogdanFamily()
        {
            var bogdan = new Meerkat("Bogdan");
            var mothermabobOfBogdan = new Meerkat("Mothermabob of Bogdan");
            var fathermabobOfBogdan = new Meerkat("Fathermabob of Bogdan");

            var bogdanFamily = new Mob
            {
                Name = "family of Bogdan",
                Members = {bogdan, mothermabobOfBogdan, fathermabobOfBogdan}
            };

            return bogdanFamily;
        }

        private static Mob CreateSergeiFamily()
        {
            var sergei = new Meerkat("Sergei");
            var mostBeautiousSisterofSergei = new Meerkat("Beautious Sister Of Sergei");
            var familyMeThinksHasFleas = CreateFamilyMeThinksHasFleas();

            var sergeiFamily = new Mob
            {
                Name = "family of Sergei",
                Members = {sergei, mostBeautiousSisterofSergei, familyMeThinksHasFleas}
            };

            return sergeiFamily;
        }

        private static Mob CreateFamilyMeThinksHasFleas()
        {
            var brotherOfSergeiAlwaysWithTheScratching = new Meerkat("Scratching Brother of Sergei");
            var wifeOfScratchingBrother = new Meerkat("Wife of Scratching Brother");
            var scratchyBaby = new Meerkat("Baby of Scratching Brother");

            var familyMeThinksHasFleas = new Mob
            {
                Name = "Sergei Scratchy Extended Family",
                Members = {brotherOfSergeiAlwaysWithTheScratching, wifeOfScratchingBrother, scratchyBaby}
            };

            return familyMeThinksHasFleas;
        }
    }
}
