 int maxFreq = 0;
            int[] freq = Enumerable.Repeat(0, 32).ToArray(); //32개의 0값을 가지는 배열생성
            string word = Console.ReadLine().ToUpper(); //input string 대문자 변환
            foreach (char c in word)
            {
                int value = Convert.ToInt32(c);
                freq[value - 65] += 1;
            }
            maxFreq = freq.Max();
            int index_Fword = Array.IndexOf(freq, maxFreq);
            int index_Lword = Array.LastIndexOf(freq, maxFreq);

            if (index_Fword == index_Lword)
            {
                Console.WriteLine(Convert.ToChar(index_Fword + 65));
            }
            else
            {
                Console.WriteLine("?");
            }