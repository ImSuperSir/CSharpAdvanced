namespace _004._CompareTripplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



    }

    public class Result
    {

        public static List<int> CompareTripplets(List<int> a, List<int> b)
        {
            int[] lResultados = {  0, 0  };
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) 
                {
                    lResultados[0] += 1;
                }
                else if (a[i] < b[i]) { lResultados[1] +=1; }
            }

            return lResultados.ToList();
        }

    }
}
