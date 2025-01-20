namespace Set2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("al n-lea termen din sirul lui Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este: {Fib(n)}");


        }
        static int Fib(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int fn = 0;
            for(int i = 2; i < n; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }
            return fn;
        }
    }
}