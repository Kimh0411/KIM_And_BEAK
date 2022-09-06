int n = int.Parse(Console.ReadLine());

           
            int[] arr = new int[n];

          
            string[] s = Console.ReadLine().Split();
            
  
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            
     
            Array.Sort(arr);
            
 
            Console.WriteLine($"{arr[0]} {arr[n - 1]}");