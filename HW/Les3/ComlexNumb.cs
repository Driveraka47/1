#region Автор Ткаченко Влад
#endregion
/*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/

using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            myComplex complexOne;
            complexOne.Re = 5;
            complexOne.Im = 10;

            myComplex complexTwo;
            complexTwo.Re = 10;
            complexTwo.Im = 5;

            var newCompNumb = complexOne.Plus(complexTwo);
            Console.WriteLine($"{newCompNumb.Re}+{newCompNumb.Im}*i");

            var newCompNumb2 = complexOne.Deduct(complexTwo);
            Console.WriteLine($"{newCompNumb2.Re}-{newCompNumb2.Im}*i");

            var newCompNumb3 = complexOne.MultiP(complexTwo);
            Console.WriteLine($"{newCompNumb3.Re}*{newCompNumb3.Im}*i");
        
        }

        struct myComplex
        {
            public double Im;
            public double Re;

            public myComplex Plus(myComplex complexX)
            {
                myComplex complexY;

                complexY.Re = Re + complexX.Re;
                complexY.Im = Im + complexX.Im;

                return complexY;
            
            
            }

            public myComplex Deduct(myComplex complexQ)

            {
                myComplex complexW;

                complexW.Re = Re - complexQ.Re;
                complexW.Im = Im - complexQ.Im;

                return complexW;
            
            }

            public myComplex MultiP(myComplex complexA)
            {
                myComplex complexB;

                complexB.Re = Re * complexA.Re;
                complexB.Im = Im * complexA.Im;

                return complexB;
            
            }
        }
    
    
    
    
    
    }

}
