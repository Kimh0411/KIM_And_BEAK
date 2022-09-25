using System.Text;

int testCount = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < testCount; i++)
            {
                string[] testCases = Console.ReadLine().Split(' ');
                int spellRepeatCount = int.Parse(testCases[0]);
                string testString = testCases[1];

                for (int j = 0; j < testString.Length; j++)
                {
                    output.Append(testString[j], spellRepeatCount);
                }

                output.Append("\n");
            }

            Console.WriteLine(output.ToString());