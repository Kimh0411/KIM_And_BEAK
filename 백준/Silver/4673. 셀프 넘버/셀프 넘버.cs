using System;
using System.IO;
using System.Text;

int Creater(string num)
            {
                int result = int.Parse(num);
                for (int i = 0; i < num.Length; i++)
                {
                    result += int.Parse(num[i].ToString());
                }

                return result;
            }

            int[] created_Values = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                created_Values[i] = Creater(i.ToString());
            }

          
            StringBuilder selfNumber = new StringBuilder();

          
            bool isSelfNumber = true;
            for (int i = 0; i < 10001; i++)
            {
                for (int j = 0; j < created_Values.Length; j++)
                {
                    if (i == created_Values[j])
                    {
                        isSelfNumber = false;
                        break;
                    }
                    else
                    {
                        isSelfNumber = true;
                    }
                }

                if (isSelfNumber) selfNumber.AppendLine(i.ToString());
            }

         
            Console.WriteLine(selfNumber);

        