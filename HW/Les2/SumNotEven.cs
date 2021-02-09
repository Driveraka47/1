#region Автор:Ткаченко Влад
#endregion
//*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;

namespace HomeWork2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 sumNe4 = 0;
            Int32 numb = 0;

            Console.WriteLine("\tВводите числа по очереди.");

            do
            {
                numb = int.Parse(Console.ReadLine());
                
                if (numb > 0 && numb % 2 == 1)
                    sumNe4 += numb;

            } while (numb != 0);

            Console.WriteLine($"Сумма всех нечетных положительных чисел:  {sumNe4}");
            
            Console.ReadLine();
           
        }
    }
}
