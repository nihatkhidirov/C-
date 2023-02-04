namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededinizi daxil edin");
            double e = Convert.ToDouble(Console.ReadLine());

            if (e < 100)
                Console.WriteLine("Duzgun daxil edilmemisdir");

            else if (e <= 999.999)
            {
                double f = e * 1000;
                double g = f % 1000;
                int h = (int)(f / 1000);

                Console.WriteLine(g + (h * 0.001));
            }

            else 
                Console.WriteLine("Bu say duzgun deyil");




        }
    }
}