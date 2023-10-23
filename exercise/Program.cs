using System;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // B1:
            Console.WriteLine("Nhap so vao day: ");
            int a = int.Parse(Console.ReadLine());
            if( a < 0)
            {
                Console.WriteLine("Day la so am");
            }

            // B2:
            Console.WriteLine("Nhap so vao day: ");
            int b = int.Parse(Console.ReadLine());
            if (b > 0)
            {
                Console.WriteLine("Day la so duong");
            }
            // B3:
            Console.WriteLine("Nhap so can kiem tra: ");
            int c = int.Parse(Console.ReadLine());
            if (c > 0)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine("Day la so chan duong");
                }
                else { Console.WriteLine("Day la so le duong"); }
            }
            else { Console.WriteLine("Day la so am"); }
            // B4:
            string mes = "- Hello World";
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + mes);
            }
            //B5:

        }
    }
}