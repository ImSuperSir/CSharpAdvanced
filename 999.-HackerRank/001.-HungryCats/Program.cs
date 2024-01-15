using System.Linq;

namespace _001._HungryCats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NotHungryCats("\"O~~O~O~O F O~O~\"");
        }

        public static int NotHungryCats(string kitchen)
        {
            // split the map by position of food
            var cats = kitchen.Replace(" ", "").Split('F');

            // count on both sides
            var leftCount = cats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
            var rightCount = cats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');

            Console.WriteLine($"Izquierda {leftCount}, derecha {rightCount}");

            return leftCount + rightCount;
        }
    }
}

