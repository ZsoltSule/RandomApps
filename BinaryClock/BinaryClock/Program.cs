using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock
{
     class Program
    {
        static void Main()
        {
            // Afisam decimal
            string time = string.Format("{0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine($"The Curent Time in Decimal is : {time}");

            // Afisam Binar
            char[] sep = new char[] { ' ', ',', ':' };
            string[] nr = time.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int ora1 = Convert.ToInt32(nr[0]);
            int min1 = Convert.ToInt32(nr[1]);
            int sec1 = Convert.ToInt32(nr[2]);
            int ora2 = Convert.ToInt32(Convert.ToString(ora1, 2));
            int min2 = Convert.ToInt32(Convert.ToString(min1, 2));
            int sec2 = Convert.ToInt32(Convert.ToString(sec1, 2));
            Console.WriteLine($"The Curent Time in Base 2 is : {ora2}:{min2}:{sec2}\n");

            // Tabelul Binar
            // Vom folosi X pentru aprins si O pentru stins
            Console.WriteLine("----------------------");
            Console.WriteLine("|    Binary Clock    |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| H  H | M  M | S  S |");
            Console.WriteLine("----------------------");

            firstRow();
            secondRow();
            thirdRow();
            fourthRow();
            Refresh();

            // Primul rand
            static void firstRow()
            {
                DateTime now = DateTime.Now;
                int h = now.Hour % 10;
                int m = now.Minute % 10;
                int s = now.Second % 10;
                string hPrint = "O";
                string mPrint = "O";
                string sPrint = "O";

                if (h > 7) hPrint = "X";
                if (m > 7) mPrint = "X";
                if (s > 7) sPrint = "X";

                Console.WriteLine($"|    {hPrint} |    {mPrint} |    {sPrint} |");
                Console.WriteLine("----------------------");
            }

            // Al doilea rand
            static void secondRow()
            {
                DateTime now = DateTime.Now;
                int h = now.Hour % 10;
                int m1 = now.Minute / 10;
                int m2 = now.Minute % 10;
                int s1 = now.Second / 10;
                int s2 = now.Second % 10;
                string hPrint = "O";
                string m1Print = "O";
                string m2Print = "O";
                string s1Print = "O";
                string s2Print = "O";

                if (h > 3 && h < 8)
                    hPrint = "X";
                if (m2 > 3 && m2 < 8)
                    m2Print = "X";
                if (m1 > 3)
                    m1Print = "X";
                if (s2 > 3 && s2 < 8)
                    s2Print = "X";
                if (s1 > 3)
                    s1Print = "X";
                Console.WriteLine($"|    {hPrint} | {m1Print}  {m2Print} | {s1Print}  {s2Print} |");
                Console.WriteLine("----------------------");
            }

            //Al treilea rand
            static void thirdRow()
            {
                DateTime now = DateTime.Now;
                int h1 = now.Hour / 10;
                int h2 = now.Hour % 10;
                int m1 = now.Minute / 10;
                int m2 = now.Minute % 10;
                int s1 = now.Second / 10;
                int s2 = now.Second % 10;
                string h1Print = "O";
                string h2Print = "O";
                string m1Print = "O";
                string m2Print = "O";
                string s1Print = "O";
                string s2Print = "O";

                if (h2 == 2 || h2 == 3 || h2 == 6 || h2 == 7)
                    h2Print = "X";
                if (h1 == 2 || h1 == 3 || h1 == 6 || h1 == 7)
                    h1Print = "X";
                if (m2 == 2 || m2 == 3 || m2 == 6 || m2 == 7)
                    m2Print = "X";
                if (m1 == 2 || m1 == 3 || m1 == 6 || m1 == 7)
                    m1Print = "X";
                if (s2 == 2 || s2 == 3 || s2 == 6 || s2 == 7)
                    s2Print = "X";
                if (s1 == 2 || s1 == 3 || s1 == 6 || s1 == 7)
                    s1Print = "X";
                Console.WriteLine($"| {h1Print}  {h2Print} | {m1Print}  {m2Print} | {s1Print}  {s2Print} |");
                Console.WriteLine("----------------------");
            }

            // Al patrulea rand
            static void fourthRow()
            {
                DateTime now = DateTime.Now;
                int h1 = now.Hour / 10;
                int h2 = now.Hour % 10;
                int m1 = now.Minute / 10;
                int m2 = now.Minute % 10;
                int s1 = now.Second / 10;
                int s2 = now.Second % 10;
                string h1Print = "O";
                string h2Print = "O";
                string m1Print = "O";
                string m2Print = "O";
                string s1Print = "O";
                string s2Print = "O";

                if (h2 % 2 == 1)
                    h2Print = "X";
                if (h1 == 1)
                    h1Print = "X";
                if (m2 % 2 == 1)
                    m2Print = "X";
                if (m1 % 2 == 1)
                    m1Print = "X";
                if (s2 % 2 == 1)
                    s1Print = "X";
                if (s1 % 2 == 1)
                    s1Print = "X";
                Console.WriteLine($"| {h1Print}  {h2Print} | {m1Print}  {m2Print} | {s1Print}  {s2Print} |");
                Console.WriteLine("----------------------");
            }

            // Refresh in fiecare secunda
            static void Refresh()
            {
                Thread.Sleep(1000);
                Console.Clear();
                Main();
            }
        }
     }
}
