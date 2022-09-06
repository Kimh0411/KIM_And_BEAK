using System;
using System.Text;

namespace for문8
{
    class Program
    {
        static void Main(string[] args)
        {
       
            StringBuilder number = new StringBuilder();

            
            int t = int.Parse(Console.ReadLine());

            int[] num = new int[t];

            for (int i = 0; i < t; i++)
            {
              
                string[] ab = Console.ReadLine().Split();
                num[i] = int.Parse(ab[0]) + int.Parse(ab[1]);
                number.AppendLine($"Case #{i + 1}: {ab[0]} + {ab[1]} = " + num[i].ToString());
            }
            
            Console.WriteLine(number.ToString());
        }
    }
}
