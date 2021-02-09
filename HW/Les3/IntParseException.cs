#region Автор Ткаченко Влад

#endregion
/*а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/
using System;

namespace HomeWork3._2
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
                try
                {
                    numb = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("\tНеверный ввод символов! Вводите только цифры!!!") ;
                }
                

                if (numb > 0 && numb % 2 == 1)
                    sumNe4 += numb;

            } while (numb != 0);

            Console.WriteLine($"Сумма всех нечетных положительных чисел:  {sumNe4}");

            Console.ReadLine();
            
        }
    }
}
