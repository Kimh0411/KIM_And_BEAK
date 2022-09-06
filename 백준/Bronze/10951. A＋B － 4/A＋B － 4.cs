 while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] inputNum = input.Split();
                int numA = int.Parse(inputNum[0]);
                int numB = int.Parse(inputNum[1]);
                int addNum = numA + numB;
                Console.WriteLine(addNum);
            }