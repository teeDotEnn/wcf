using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    internal class Program
    {
        static double n1, n2;
        static void Main(string[] args)
        {
            CalculatorReference.CalculatorServiceClient client = new CalculatorReference.CalculatorServiceClient(); 
            string choice = "";
            
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Compare");
                Console.WriteLine("6. Exit");
                Console.Write("\tEnter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        LoadNumbers();
                        Console.WriteLine("The sum is : " + client.Add(n1, n2)) ;
                        break;
                    case "2":
                        LoadNumbers();
                        Console.WriteLine("The difference is : " + client.Sub(n1, n2));
                        break;
                    case "3":
                        LoadNumbers();
                        Console.WriteLine("The product is : " + client.Mul(n1, n2));
                        break;
                    case "4":
                        LoadNumbers();
                        Console.WriteLine("The quotient is : " + client.Div(n1, n2));
                        break;
                    case "5":
                        LoadNumbers();
                        Console.WriteLine("The greater number is: " + client.Compare(n1, n2));
                        break;
                }
            }
        }

        static void LoadNumbers()
        {
            Console.WriteLine("Enter Number 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            n2 = double.Parse(Console.ReadLine());
        }
    }
}
