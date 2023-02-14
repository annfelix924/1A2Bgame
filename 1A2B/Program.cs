using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");
            Random random = new Random();
            int[] answer = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int number = random.Next(0, 10);
                while (Array.IndexOf(answer, number) != -1)
                {
                    number = random.Next(0, 10);
                }
                answer[i] = number;
            }

            while (true)
            {
                Console.Write("請輸入 4 個數字：");
                string input = Console.ReadLine();
                if (input.Length != 4)
                {
                    Console.WriteLine("輸入格式錯誤，請重新輸入！");
                    continue;
                }

                int A = 0;
                int B = 0;
                for (int i = 0; i < 4; i++)
                {
                    int number = int.Parse(input[i].ToString());
                    if (answer[i] == number)
                    {
                        A++;
                    }
                    else if (Array.IndexOf(answer, number) != -1)
                    {
                        B++;
                    }
                }

                Console.WriteLine("判定結果是 " + A + "A" + B + "B");
                if (A == 4)
                {
                    Console.WriteLine("恭喜你！猜對了！！");
                    break;
                }

                Console.Write("你要繼續玩嗎？(y/n): ");
                string continueGame = Console.ReadLine();
                if (continueGame != "y")
                {
                    Console.WriteLine("遊戲結束，下次再來玩喔～");
                    break;
                }
            }

        }
    }
}