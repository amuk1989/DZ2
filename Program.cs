using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = new Worker[10];//массив работников
            for (int i = 0; i< worker.Count(); i++)//
            {
                Console.WriteLine($"Работник {i+1}");
                worker[i] = new Worker();
                worker[i].Salary = Calculation(); 
            }
            Console.ReadKey();
        }

        static string Inner(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static double Calculation()//миетнод рсчиетнываиетн зарплатну
        {
            while (true)
            {

                try//данные о зарплате работника
                {
                    double salary = Convert.ToDouble(Inner("Ставка работника в час или в месяц: "));

                    string msg = Inner("Условия сотрудника. 1 - на ставке, 0 - на почасовой: ");
                    if (msg == "1")
                    {
                        Mothly result = new Mothly();
                        return result.Money(salary);
                        break;
                    }
                    else
                    if (msg == "0")
                    {
                        int hours = Convert.ToInt32(Inner("Сколько часов отработал сотрудник? "));
                        Hourly result = new Hourly();
                        return result.Money(salary, hours);
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода!");
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода!");
                }



            }
        }


    }
}
