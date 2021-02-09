#region Автор Ткаченко Влад
#endregion
/*Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.*/

using System;

namespace HomeWork2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "root";
            String password = "GeekBrains";

            Int32 count = 0;

            do
            {
                Console.WriteLine("\t Здравствуйте, введите логин.");
                String checkL = Console.ReadLine();

                Console.WriteLine("\tТеперь проверим ваш пароль: \n P.S. Не забудте про верний регистр!!!");
                String checkP = Console.ReadLine();

                if (login == checkL && password == checkP)
                {
                    Console.WriteLine("\t У вас отличная память, логин и пароль введены верно!");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("\tЧто то пошло не так, постарайтесь вспомнить логин и пароль!!!");

                ++count;

            } while (count < 3);

        }
    }
}
