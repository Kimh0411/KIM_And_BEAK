 // 현재 시간에 + 조리시간 => 최종 조리까지 다 되는 시간
            string[] duck = Console.ReadLine().Split(' ');
            int h = int.Parse(duck[0]);
            int m = int.Parse(duck[1]);        
            int Total = int.Parse(Console.ReadLine());

            m += Total; // m = m + Total

            while (m >= 60)
            {
                h++;
                m-=60;
               
            }

            if(h>=24)
            {
                h -= 24;
            }

            Console.WriteLine(h + " " + m);