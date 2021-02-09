#region Автор: Ткаченко Владислав
#endregion

//*Написать метод подсчета количества цифр числа.

using System;

namespace HomeWork2._2
{
    class Program
    {
        static Int32 CountDigit(Int32 x) 
        {
            var i = 0;
            while (x >= 1)
            {
                x = x / 10;
                i++;
                
            }
            return i;

        }

        static void Main(string[] args)
        {
            Int32 y;
            
            Console.WriteLine("Введите целое число.");
            y = Int32.Parse(Console.ReadLine());
            
            Int32 g = 0;
            g = CountDigit(y);
          
            Console.WriteLine("В числе такое количество цифр: " + g);
       

            Console.ReadLine();
        }

        
    }
}
