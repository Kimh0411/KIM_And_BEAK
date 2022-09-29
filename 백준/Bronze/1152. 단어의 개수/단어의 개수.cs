 int result = 0; //출력 카운트 초기화

            // Trim() 앞뒤 공백 제거
            string s = Console.ReadLine().Trim();
            
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    result++;
                }
            }
            if (s.Length == 0)
                Console.WriteLine(0);
            else
             
                Console.WriteLine(result+1);
