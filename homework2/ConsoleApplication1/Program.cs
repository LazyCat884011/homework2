using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //設亂數
            Random rand = new Random();
            //設迴圈次數的變數
            int n = 0;
            //設迴圈跑20次
            while (n<=20)
            {
                
                //設外框
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               大         樂         透               ║");
                Console.WriteLine("╠══════╦═══════╦═══════╦═══════╦═══════╦═══════╦═══════╣");
                //設從1~43隨機取6個數字
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);
                //改字的顏色
                Console.ForegroundColor = ConsoleColor.Red;
                //讀出6個亂數
                Console.WriteLine("║【FN】║  {1:00}   ║  {2:00}   ║  {3:00}   ║  {4:00}   ║  {5:00}   ║  {6:00}   ║", n,r1, r2, r3, r4, r5, r6);
                //每執行一次資加一次迴圈次數N
                n++;
                Console.WriteLine("╚══════╩═══════╩═══════╩═══════╩═══════╩═══════╩═══════╝");
                //讓系統暫停0.05秒
                System.Threading.Thread.Sleep(50);
                

            }
            Console.ReadLine();

            

             
        }
    }
}
