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
            
            // 宣告亂數
            Random rand = new Random();

            // 宣告執行次數n
            int n = 0;
            
            // 創建迴圈
            while (n<10)
            {
                

             // 美化   
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               大         樂         透               ║");
                Console.WriteLine("╠══════╦═══════╦═══════╦═══════╦═══════╦═══════╦═══════╣");
             
             // 宣告6個從1~43取出的亂數   
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);
             
             // 把字改紅色   
                Console.ForegroundColor = ConsoleColor.Red;

             // 印出亂數
                Console.WriteLine("║【FN】║  {1:00}   ║  {2:00}   ║  {3:00}   ║  {4:00}   ║  {5:00}   ║  {6:00}   ║", n,r1, r2, r3, r4, r5, r6);

             // 執行完後迴圈次數n+1
                n++;

             // 美化
                Console.WriteLine("╚══════╩═══════╩═══════╩═══════╩═══════╩═══════╩═══════╝");
                
                

            }

            // 結束
            Console.ReadLine();

            

             
        }
    }
}
