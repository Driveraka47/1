#region Автор Ткаченко Влад
#endregion
/*Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.*/
using System;

namespace HomeWorke4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            myMassive myArray = new myMassive(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.ReadLine();
        }

        public class myMassive
        {
            private int[] am;
          
            public myMassive(int n, int min, int max)
            {
                am = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                    am[i] = random.Next(min, max);
            }

            
            public int Divisibility3()
            {
                
                    int count = 0;
                    for (int i = 0; i < am.Length - 1; i++)
                    {
                        if (am[i] % 3 == 0 || am[i + 1] % 3 == 0)
                            count++;
                        Console.WriteLine("Пара чисел: {0} и {1}", am[i], am[i + 1]);
                    }
                    Console.WriteLine("Количество пар: " + count);
                    return count;
                
            }

           
            override public string ToString()
            {
                string stringarray = "";
                foreach (int x in am)
                    stringarray = stringarray + x + " ";
                return stringarray;
            }
        }
    }
    
}
