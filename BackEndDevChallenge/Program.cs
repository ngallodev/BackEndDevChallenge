using System;
using System.Collections;
using System.Collections.Generic;

namespace BackEndDevChallenge
{
    class Program
    {

        public static List<int> getRecordsByAgeGroup(int ageStart, int ageEnd, int bpDiff)
        {

            return new List<int>();
        }
        public static long maximumSum(List<int> arr)
        {
            //long high = 0;
            long max = 0;
            if (arr.Count > 0)
            {
               
                long maxCurrent = 0;

                for (int x = 0; x < arr.Count; x++)
                {
                    if (arr[x] < 1)
                        continue;
                    maxCurrent = arr[x];
                    for (int y = x + 1; y < arr.Count; y++)
                    {
                        maxCurrent += arr[y];
                        if (maxCurrent > max)
                            max = maxCurrent;
                    }
                }
            }
            return max;
        }

        static int maxTickets(List<int> tickets)
        {


            List<int> counter = new List<int>();
            
            //ar.Add(newList);
            tickets.Sort();
            //int currentNumber = 0;
            for (int x= 0; x< tickets.Count; x++)
            {
                List<int> newList = new List<int>();
                newList.Add(tickets[x]);
                for (int y =x+1; y<tickets.Count; y++)
                {
                    if(Math.Abs(tickets[x]-tickets[y])<=1)
                    {
                        newList.Add(tickets[y]);
                    }
                }
                counter.Add(newList.Count);
           
            }
            counter.Sort();
            foreach(int i in counter)
                Console.WriteLine(i);
            //Console.WriteLine(counter.ToString());

            return counter[counter.Count-1];

        }
        public static void fizzBuzz(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                //if multiple of 3 and 5 print FizzBuzz
                //if 3 ! 5 Fizz
                //if 5 not 3 Buzz
                //else print n
                if (x % 3 == 0 && x % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (x % 3 == 0 && x % 5 != 0)
                    Console.WriteLine("Fizz");
                else if (x % 3 != 0 && x % 5 == 0)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            List<int> results = getRecordsByAgeGroup(28, 30, 63);
            foreach(int i in results)
                Console.WriteLine(i);
            Console.ReadLine();
            List<int> ints = new List<int> { 4, -1, -2, 1, 3 };
            Console.WriteLine(maximumSum(ints) );
            Console.ReadLine();
            List<int> tick = new List<int> { 4,4,13,2,3};
            Console.WriteLine(maxTickets(tick));
            Console.ReadLine();
            //fizzBuzz(5);
            //Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
