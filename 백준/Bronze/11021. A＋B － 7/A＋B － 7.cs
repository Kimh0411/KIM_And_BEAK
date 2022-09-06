using System;
using System.Text;

namespace for문7
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
             
                string[] s = Console.ReadLine().Split();
                num[i] = int.Parse(s[0]) + int.Parse(s[1]);
                number.AppendLine($"Case #{i+1}: " + num[i].ToString());
            }
         
            Console.WriteLine(number.ToString());
        }
    }
}