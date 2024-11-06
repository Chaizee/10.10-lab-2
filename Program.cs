using System.Dynamic;
using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] mus = new int[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            mus[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            int number = mus[i];
            int chet = 0;
            int prom = 0;
            while (number > 0) {
                if (( number % 10) % 2 == 0)
                {
                    chet++;
                }
                number/=10;
                prom++;
            }
            if (chet == prom)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}