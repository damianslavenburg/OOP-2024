using System.Runtime.CompilerServices;

namespace pokemonbattlesimulator
{
    public class pokebattle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
            Console.WriteLine("Enter the name of the Charmander:");
            string name = Console.ReadLine();
            Charmander charmander = new Charmander(name, "fire", "water");
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(charmander.battlecry());
                }   
        }
    }
}

   