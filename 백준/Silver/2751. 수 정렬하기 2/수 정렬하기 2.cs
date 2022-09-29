using System.Text;
int count = int. Parse(Console.ReadLine());
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            StringBuilder sb = new StringBuilder(String.Join("\n", arr));

            Console.WriteLine(sb);   