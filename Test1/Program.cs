using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        public static bool RecSearch(List<int> numbers, int searchNum)
        {
            if (numbers != null && numbers.Count>0) //listen ikke er tom
                if (numbers[0] == searchNum)  // searchNum is at the first position
                    return true;
                else
                {
                    //lav en ny liste udfra numbers uden det første element
                    List<int> restnumbers = numbers.GetRange(1, numbers.Count - 1);
                    return RecSearch(restnumbers,searchNum); //kald rekursivt med den reducerede list
                }
            else
            {
                return false; //Der er ikke mere at søge i og elementet er ikke fundet
            }
        }

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
            PrintHello();
        }


        public static void PrintHello(int numberOfCallsLeft)
        {
            if (numberOfCallsLeft > 0)
            {
                Console.WriteLine("Hello ");
                PrintHello(numberOfCallsLeft - 1);
            }
        }

        public static int Factorial(int n)
        {
            return (n <= 1) ? 1 : (n * Factorial(n - 1));
        }


        public static void TowersOfHanoi(string source, string extra, string target, int n)
        {
            if (n > 0)
            {
                TowersOfHanoi(source, target, extra, n - 1);
                Console.WriteLine($"Move disk {n}: {source}->{target}");
                TowersOfHanoi(extra, source, target, n - 1);
            }
        }

        public static int Fibonacci(int n)
        {
            return (n < 3) ? 1 : (Fibonacci(n - 1) + Fibonacci(n - 2));
        }



        static void Main(string[] args)
        {
            //PrintHello();
            //PrintHello(5);
            //Console.WriteLine(Factorial(3));
            TowersOfHanoi("A", "B", "C", 4);
            Console.WriteLine(Fibonacci(6));


            List<int> numbers = new List<int>();
            // Insert some values into the list…
            numbers.Add(100);
            numbers.Add(10);
            numbers.Add(47);
            numbers.Add(37);
            numbers.Add(75);

            //bool searchRec = RecSearch(numbers, 47);
            //Console.WriteLine($"Search for 47 {searchRec}");

            int valueToLookFor = 37;
            bool valueWasFound = false;
            // T = O(n)
            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == valueToLookFor)
                {
                    valueWasFound = true;
                }
            }

            // T = O(n*n)
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.WriteLine(numbers[i] * numbers[j]);
                }
            }

            // T = O(1)
            Console.WriteLine(numbers[0]);
            
            Console.ReadLine();
        }

        //public static bool RecSearch(List<int> numbers, int searchNum)
        //{
        //    if (numbers.Count > 0)
        //        if (searchNum == numbers[0])
        //            return true;
        //        else
        //        {
        //            List<int> restNumbers = numbers.GetRange(1, numbers.Count - 1);
        //            return RecSearch(restNumbers, searchNum);
        //        }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
