
            string[] str = Console.ReadLine().Split(' ');
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(str[2]);

            if (A == B && B == C) // 첫번째 상황
            {
                Console.WriteLine(10000 + (A * 1000));
            }
            else if (A == B) // 두번째 상황
            {
                Console.WriteLine(1000 + A* 100);
            }
            else if (A == C)
            {
                Console.WriteLine(1000 + A * 100);
            }
            else if (B == C)
            {
                Console.WriteLine(1000 + B* 100);
            }

            else // 세번째 상황, 숫자가 모두 다를때
            {
                if(A > B && A > C) //첫번째 숫자가 다 클때
                {
                    Console.WriteLine(100 * A);
                }
                else if(B>C)
                {
                    Console.WriteLine(100 * B);
                }
                else
                {
                    Console.WriteLine(100 * C);
                }
            }
        