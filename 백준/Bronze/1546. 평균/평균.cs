//1 과목수
            int n = int.Parse(Console.ReadLine());

            //2 세준이 점수
            string[] inputScore = Console.ReadLine().Split(' ');
            float[] score = Array.ConvertAll(inputScore, float.Parse);

            //3 최댓값을 고르자
            
            float maxScore = float.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (maxScore < score[i])
                {
                    maxScore = score[i];
                }
            }
            //평균 출력
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                score[i] = (score[i] / maxScore) * 100;
                sum += score[i];
            }
            double scoreAverage = sum / n;

            Console.WriteLine("{0:#0.00####}", scoreAverage);