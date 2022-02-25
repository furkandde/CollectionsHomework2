using System;
using System.Collections;

namespace CollectionsHomework2
{
    internal class Program
    {
        static ArrayList primeNumbers = new ArrayList();
        static ArrayList nonprimeNumbers = new ArrayList(); 
        static int numaricValue;
        static void Main(string[] args)
        {           
            for (int i = 1; i < 21; i++)
            {               
                while (true)
                {
                    Console.WriteLine("Enter the {0}. positive number: ", i);
                    int value;
                    bool isNumber = int.TryParse(Console.ReadLine(), out value);
                    if (!isNumber || value < 0)
                    {
                        Console.WriteLine("Enter a valid number!");
                    }
                    else
                    {
                        numaricValue=value;
                        break;
                    }                                     
                }
                primeOrNot(numaricValue);
            }
             
            primeNumbers.Sort();
            nonprimeNumbers.Sort();
            Console.WriteLine("Prime Numbers :");
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.Write(" " + primeNumbers[i]);
            Console.WriteLine(" ");
            Console.WriteLine("Non-Prime Numbers :");
            for (int i = 0; i < nonprimeNumbers.Count; i++)
                Console.Write(" "+ nonprimeNumbers[i]);
            Console.ReadKey();
        }
        static void primeOrNot(int value)
        {
            
            if (value == 2)
            {
                primeNumbers.Add(value);
            }
            if (value > 2)
            {
                for (int i = 2; i < value; i++)
                {
                    if (value % i == 0)
                    {
                        nonprimeNumbers.Add(value);
                        return;
                    }
                }
                primeNumbers.Add(value);
            }           
        }

    }
}
