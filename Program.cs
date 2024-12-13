namespace Set2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdu al catelea termen din sirul lui Fibonacci vrei sa il afli: ");
            int n = int.Parse(Console.ReadLine());
            if(n <= 0)
            {
                Console.WriteLine("Introduceti un numar pozitiv");
                return;
            }

            Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este: {Fib(n)}");
        }
        static int Fib(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b= c;
            }
            return c;
        }
    }
}