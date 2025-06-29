
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading;





namespace test_git
{
    
   
        
    
    internal class Program
    {
        static object consoleLock = new object();


        private static List<work_1> ocu = new List<work_1>();
        
        static void Main(string[] args)
        {
            int total, length;
            char c = ' ' ;
            
            while (true)
            {
            start:
                Console.Write("nhap cong viec Y/N: ");
                try { c = Convert.ToChar(Console.ReadLine()); }
                catch (Exception)
                {

                }

                while (c != 'Y' && c != 'N')
                {
                    Console.Write("nhap sai dinh dang: ");
                    goto start;
                }
                if (c == 'Y')
                {
                    goto Action;
                }
                else
                {
                    goto printf;
                }
            Action:
                work_1 peo = new work_1();
                Console.WriteLine("nhap cong viec: ");
                peo.Name = Console.ReadLine();
                Console.WriteLine("nhap thoi gian : ");
                peo.Toltal_time = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap do dai : ");
                peo.Length = int.Parse(Console.ReadLine());
                ocu.Add(peo);
               
            }
        printf:
            if (ocu.Count > 0)
            {
                goto dooo;
            }
            else
            {
                goto End;
            }

        dooo:
            int d = 0;
            float[] A = new float[2];
            
                for (int j = 0 ; j <= ocu[0].Toltal_time; j++) 
                {
                    foreach (work_1 a in ocu)
                    {
                        a.Trang_thai_1 = a.Trang_thai( j);
                    A = a.time(j);
                    a.Remaning_time = A[0];
                    a.Con_time = (int)A[1];
                        Console.WriteLine(a);
                    }
                    Thread.Sleep(1000);
                    clear(ocu.Count);
                }
        End:
            Console.WriteLine("end...");


        }
        private void Calculator_1(int a, int b)
        {

            Console.WriteLine("tong :" + (a + b));
            Console.WriteLine("hiêu : " + (a - b));
            Console.WriteLine("tich  :" + (a * b));
            Console.WriteLine("thuong : " + (a / b));
            Console.WriteLine("so du : " + (a % b));

        }
        static void tryparse_1(string a)
        {
            int b;
            int.TryParse(a, result: out b);
            Console.WriteLine(b);
        }
        static void convert_1(string a)
        {
            int b;
            try { b = Convert.ToInt32(a); }
            catch (FormatException)
            {
                Console.WriteLine("loi format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("tran bo nho");
            }

        }
        static void old_1(String c)
        {
            DateTime b;
            while (!DateTime.TryParse(c, out b))
            {
                Console.WriteLine("nhap lai ");
                c = Console.ReadLine();
            }
            Console.WriteLine(Convert.ToInt32((DateTime.Now - b).TotalDays / 365) + "  tuổi  " + Convert.ToInt32((DateTime.Now - b).TotalDays % 365) + "  ngay");
            Console.WriteLine((DateTime.Now.Year - b.Year));
        }
        static void clock_1(int a)
        {
            int c = 0;
            Console.WriteLine("start clock .....");
            for (int i = a; i >= 0; i--)
            {
                Console.WriteLine(i);
                thanhtrangthai(c, a);
                Thread.Sleep(2000);
                clear_1(2);
                c++;


            }

            //clear_1(2);
            Console.WriteLine("end clock .....");

        }
        static void clear_1(int a)
        {
            int c;
            if ((Console.CursorTop - a) > 0) { c = Console.CursorTop - 1; }
            else { c = Console.CursorTop; }
            Console.SetCursorPosition(0, c);
            Console.WriteLine("  ", Console.WindowWidth);
            Console.WriteLine("  ", Console.WindowWidth);
            Console.SetCursorPosition(0, c);
        }
        static void thanhtrangthai(int a,int s)
        { 
            int b;
            if(a!= 0) 
            {  
                b = 50 -(int)(50 * a / s); 
            }
            else { b = 50; }



                for (int j = 0; j < 50-b; j++)
                {
                    Console.Write(" ");
                }
            for (int j = 0; j < b + 1; j++)
            {
                Console.Write(":");
            }
        }
        static void snt(int a)
        {
            int b = Convert.ToInt32(Math.Sqrt(a));
            bool c = false;
            for (int i = 2; i <= b; i++)
            {
                if (a % i == 0)
                {
                    c = true;
                    break;
                }
                else
                {
                    c = false;
                }
            }
            if (c)
            {
                Console.WriteLine("ko phai snt");
            }
            else
            {
                Console.WriteLine(" snt");

            }

        }
        static void check_string_1(string c)
        {
            int a = c.Length;
            int letter =0, digital=0, whitespace= 0;
            for (int i = 0; i < a; i++)
            {
                if (Char.IsLetter(c[i]))
                {
                    letter++;
                }
                else if (Char.IsDigit(c[i]))
                {
                    digital++;
                }
                else if (Char.IsWhiteSpace(c[i]))
                {
                    whitespace++;
                }

            }
            Console.WriteLine(letter);
            Console.WriteLine( whitespace);
            Console.WriteLine( digital );
        }
        static void clear(int num_line)
        {
            int a;
            if ((Console.CursorTop - num_line) > 0)
            { a = Console.CursorTop - num_line; }
            else { a = Console.CursorTop; }
            Console.SetCursorPosition(0, a);
            for (int j = 0; j < num_line; j++) { Console.Write(new string(' ', Console.WindowWidth)); }
            Console.SetCursorPosition(0, a);

        }

    }
}

