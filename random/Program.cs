using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempt = 0, Easter = -69, rez = 0;
            Console.WriteLine("выбирите уровень сложности: легко(число 1-100, попытки 30)\n нормально(1-500 попытки 20)\n тяжелая(1-1000 попытки 10)\n 228(?)");
            string levl = Console.ReadLine();

            if (levl == "легко")
            {
                Console.WriteLine("выбрана легкая сложность, угадайте число от 1 до 100");
                Random rnd = new Random();
                int PCnumber, number;
                PCnumber = rnd.Next(1, 100+1);
                attempt = 30;

                do
                {
                    number = int.Parse(Console.ReadLine());

                    if (Easter == number)
                    { 
                        Console.WriteLine("Поза 69 — одна из наиболее известных поз для орального секса, дающая партнёрам возможность проводить взаимную оральную стимуляцию. Партнёры при этом располагаются относительно друг друга в перевёрнутом положении, как цифры в числе «69», отсюда и название.");
                        Console.WriteLine("интересный факт: Термин «soixante-neuf» (69) не прослеживался ранее, чем в «Катехизисах шлюхи», опубликованных в 1790-х годах во Франции, обычно приписываемых раннему лидеру Французской революции мадемуазель Теруань де Мерикур.");
                        break;
                    }

                    if (attempt == 0)
                    {
                        Console.WriteLine("вы проебали все попытки. И как пишеться в играх повезет в следующий раз");
                        break;
                    }

                    if (PCnumber > number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число больше");
                    }
                    else if (PCnumber < number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число меньше");
                    }
                } while (PCnumber != number); 
                {
                    Console.WriteLine("ну нормально");
                    Console.WriteLine($"попытки: {rez}");
                }
            }

            if (levl == "нормально")
            {
                Console.WriteLine("выбрана нормальная сложность, угадайте число от 1 до 500");
                Random rnd = new Random();
                int PCnumber, number;
                PCnumber = rnd.Next(1, 500 + 1);
                attempt = 20;

                do
                {
                    number = int.Parse(Console.ReadLine());

                    if (number == Easter)
                    {
                        Console.WriteLine("Поза 69 — одна из наиболее известных поз для орального секса, дающая партнёрам возможность проводить взаимную оральную стимуляцию. Партнёры при этом располагаются относительно друг друга в перевёрнутом положении, как цифры в числе «69», отсюда и название.");
                        Console.WriteLine("интересный факт: Термин «soixante-neuf» (69) не прослеживался ранее, чем в «Катехизисах шлюхи», опубликованных в 1790-х годах во Франции, обычно приписываемых раннему лидеру Французской революции мадемуазель Теруань де Мерикур.");
                        break;
                    }

                    if (attempt == 0)
                    {
                        Console.WriteLine("вы проебали все попытки. И как пишеться в играх повезет в следующий раз");
                        break;
                    }

                    if (PCnumber > number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число больше");
                    }
                    else if (PCnumber < number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число меньше");
                    }
                } while (PCnumber != number);
                {
                    Console.WriteLine("ну нихуёвенько");
                    Console.WriteLine($"попытки: {rez}");
                }
            }
            
            if (levl == "тяжелая")
            {
                Console.WriteLine("выбрана тяжелая сложность, угадайте число от 1 до 1000");
                Random rnd = new Random();
                int PCnumber, number;
                PCnumber = rnd.Next(1, 1000 + 1);
                attempt = 10;

                do
                {
                    number = int.Parse(Console.ReadLine());

                    if (number == Easter)
                    {
                        Console.WriteLine("Поза 69 — одна из наиболее известных поз для орального секса, дающая партнёрам возможность проводить взаимную оральную стимуляцию. Партнёры при этом располагаются относительно друг друга в перевёрнутом положении, как цифры в числе «69», отсюда и название.");
                        Console.WriteLine("интересный факт: Термин «soixante-neuf» (69) не прослеживался ранее, чем в «Катехизисах шлюхи», опубликованных в 1790-х годах во Франции, обычно приписываемых раннему лидеру Французской революции мадемуазель Теруань де Мерикур.");
                        break;
                    }

                    if (attempt == 0)
                    {
                        Console.WriteLine("вы проебали все попытки. И как пишеться в играх повезет в следующий раз");
                        break;
                    }

                    if (PCnumber > number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число больше");
                    }
                    else if (PCnumber < number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число меньше");
                    }
                } while (PCnumber != number);
                {
                    Console.WriteLine("ебать ты ёбнутая машина");
                    Console.WriteLine($"попытки: {rez}");
                }
            } else if (levl == "228")
            {
                int num1, num2, PCnumber, number;
                Random rnd = new Random();

                Console.WriteLine("Мы команда 228 мы с ноги все проги сносим. Настрой сам свою игру и играй.\n Для начала дай определим какое число будет максимальным:");
                num1 = int.Parse(Console.ReadLine());
                PCnumber = rnd.Next(1, num1 + 1);
                
                Console.WriteLine("супер, теперь определимся с количеством попыток:");
                num2 = int.Parse(Console.ReadLine());
                attempt = num2;

                Console.WriteLine($"отлично, случайное число будет выбрано в диапазоне от 1 до {num1}, количество попыток {attempt}\n ну а теперь давай пройдём");
                Console.WriteLine($"я загадал число от 1 до {num1}");

                do
                {
                    number = int.Parse(Console.ReadLine());

                    if (number == Easter)
                    {
                        Console.WriteLine("Поза 69 — одна из наиболее известных поз для орального секса, дающая партнёрам возможность проводить взаимную оральную стимуляцию. Партнёры при этом располагаются относительно друг друга в перевёрнутом положении, как цифры в числе «69», отсюда и название.");
                        Console.WriteLine("интересный факт: Термин «soixante-neuf» (69) не прослеживался ранее, чем в «Катехизисах шлюхи», опубликованных в 1790-х годах во Франции, обычно приписываемых раннему лидеру Французской революции мадемуазель Теруань де Мерикур.");
                        break;
                    }

                    if (attempt == 0)
                    {
                        Console.WriteLine("вы проебали все попытки. И как пишеться в играх повезет в следующий раз");
                        break;
                    }

                    if (PCnumber > number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число больше");
                    }
                    else if (PCnumber < number)
                    {
                        attempt--;
                        rez++;
                        Console.WriteLine($"осталось {attempt} попыток");
                        Console.WriteLine("назови число меньше");
                    }
                } while (PCnumber != number);
                {
                    Console.WriteLine("я тебя поздравляю, ты настроил и прошёл свою игру\n бонус предложение в скобках прочтёт только программист (,skj cltkfyj c k.,jdm.)");
                    Console.WriteLine($"попытки: {rez}");
                }
            }
            Console.ReadKey();
        }
    }
}