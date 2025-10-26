using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number up to 15:");
            int us = int.Parse(Console.ReadLine());
            if (us > 15)
            {
                Console.WriteLine("Error: Number too large");
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
        }
    }
}




