using System.Text;
StringBuilder sb = new StringBuilder();

            while(true)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                if (a == 0 && b == 0)
                {
                    break;
                }
                sb.AppendLine((a + b).ToString());
            }
            Console.WriteLine(sb);