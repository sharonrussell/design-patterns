using System;

namespace Composite
{
    public static class Program
    {
        static void Main(string[] args)
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
            var bogdan = new Meerkat("Bogdan");

            var sergei = new Meerkat("Sergei");
            var mostBeautiousSisterofSergei = new Meerkat("Beautious Sister Of Sergei");

            var brotherOfSergeiAlwaysWithTheScratching = new Meerkat("Scratching Brother of Sergei");
            var wifeOfScratchingBrother = new Meerkat("Wife of Scratching Brother");
            var scratchyBaby = new Meerkat("Baby of Scratching Brother");

            var familyMeThinksHasFleas = new Mob
            {
                Name = "Sergei Scratchy Extended Family",
                Members = {brotherOfSergeiAlwaysWithTheScratching, wifeOfScratchingBrother, scratchyBaby}
            };

            var sergeiFamily = new Mob {Name = "family of Sergei", Members = {sergei, mostBeautiousSisterofSergei}};

            var mothermabobOfBogdan = new Meerkat("Mothermabob of Bogdan");
            var fathermabobOfBogdan = new Meerkat("Fathermabob of Bogdan");
            var bogdanFamily = new Mob {Name = "family of Bogdan", Members = {bogdan, mothermabobOfBogdan, fathermabobOfBogdan}};

            var meerkovaVillageFamilies = new Mob
            {
                Name = "Meerkova village families",
                Members = {sergeiFamily, bogdanFamily, familyMeThinksHasFleas}
            };

            var allVillagers = new Mob {Name = "All villagers", Members = {maiya, vassily, yakov, meerkovaVillageFamilies}};
            return allVillagers;
        }
    }
}
