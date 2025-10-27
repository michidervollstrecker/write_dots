using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number up to 15:");
            string input = Console.ReadLine();
            try { Convert.ToInt32(input); 
            }
            catch
            {
                Console.WriteLine("Error: Invalid input");
                Console.ReadLine();
                return;
            }
            int us = Convert.ToInt32(input);
            if (us > 15)
            {
                Console.WriteLine("Error: Number too large");
                Console.ReadLine();
                return;
            }
            if (us <= 0)
            {
                Console.WriteLine("Error: Number must be positive");
                Console.ReadLine();
                return;
            }
            if (us.GetType() != typeof(int))
            {
                Console.WriteLine("Error: Invalid input");
                return;
            }
            string p = ".";
            int i = 0;
            string[] arr = new string[us];
            while (i < us)
            {
                for (int x = 0; x < i; x++)
                { p = p + ("."); };
                arr[i] = arr[i] + p;
                Console.WriteLine(arr[i]);
                i++;
            }
            while (i > 0)
            {
                Console.WriteLine(arr[i - 1]);
                i--;
            }
            Console.ReadLine();
          
        }
    }
}




