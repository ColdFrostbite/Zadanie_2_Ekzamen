using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Childrens
{
    class Program
    {
        static void Main(string[] args)
        {
            int Child; //количество новорожденных в отобранной группе
            int Boys; //количество мальчиков в группе
            double Chill; //Вероятность рождения мальчика
            double P; //вероятность того, что в группе будет половина мальчиков
            Int32 Otvet;

      
            Boys = 3;
            Chill = 0.5;
            P = 0;

            Int32 Factorial(int x)
            {

                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }

            }

            double Bh(int n, int k)
            {
              
               return Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

            Console.Write("Введите количество новорожденных:  ");
            Child = Convert.ToInt32(Console.ReadLine());
            while (Child > 10)
            {
                Console.Write("Количество детей превышает допустимое");
                Console.Write("Хотите ли вы повторить ввод? (1-да/0-нет)");
                Otvet = Convert.ToInt32(Console.ReadLine()); 
                
                if (Otvet == 1)
                {
                    Console.Write("Введите количество новорожденных:  ");
                    Child = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    return;
                }
            }

                Console.Write("Введите количество мальчиков:  ");
                Boys = Convert.ToInt32(Console.ReadLine());
               
             
            P = Bh(Child, Boys)*Math.Pow(Chill,Boys)*Math.Pow(1-Chill,Child-Boys);           
            P = 100 * Math.Round(P, 2);


            Console.WriteLine("Вероятность равна: " + P + "%");
            Console.ReadLine();
        }
    
    }
}
