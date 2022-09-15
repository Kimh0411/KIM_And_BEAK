 int[] arr = new int[9];

            int max = 0; //최댓값
            int num = 0; // 배열변호 저장

            for(int i = 0; i<9; i++) //입력
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; //현재값이 max보다 크면 max에 저장
                    num = i + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(num);