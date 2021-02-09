#region Автор: Ткаченко Владислав
#endregion
//*Написать метод, возвращающий минимальное из трех чисел.
using System;

namespace HomeWork2
{
    class Program
    {
        static Int32 Minimum3 (int a, int b, int c)
        {
            
           Int32 min1 = 0;
            if (a < b)
            {
                min1 = a;

            }
            if (c < min1)
            {
                min1 = c;
            }
            return min1;
        }
        static void Main(string[] args)
        {
            Int32 x, y, z, min2;
            
            Console.WriteLine("Ввелите 3 числа.");
            
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            z = Int32.Parse(Console.ReadLine());
            
            min2 = Minimum3 (x,y,z);
            
            
                Console.WriteLine("Минимальное из 3х чисел " + min2);
            
            

            

            Console.ReadLine();


        
        
        
        }
    }
}
