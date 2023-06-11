using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {

            DictionaryCollection elements = new DictionaryCollection();
            elements.Add("Дерево", "Дерево", "Wood");
            elements.Add("Книга", "Книга", "Book");
            elements.Add("Мова", "Язык", "Language");
            elements.Add("Музика", "Музика", "Music");
            elements.Add("Вчитель", "Учитель", "Teacher");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1 - вивести весь словник; 2 - переклад на Английську; 3 - переклад на росийську");
                string nemu = Console.ReadLine();

                string scrin = default;
                string res = default;

                switch (nemu)
                {
                    case "1":
                        {
                            Console.WriteLine("Укр - рос - Англ\n");
                            foreach (Element item in elements)
                            {
                                item.WriteInfo();
                            }

                            Console.ReadKey();
                            continue;
                        }
                    case "2":
                        {

                            Console.Write("Яке словао перекласти: ");
                            scrin = Console.ReadLine();

                            res = elements.TranslationEN(scrin);

                            break;
                        }
                    case "3":
                        {
                            Console.Write("Яке словао перекласти: ");
                            scrin = Console.ReadLine();

                            res = elements.TranslationEN(scrin);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Схоже неправыльный пункт меню!");
                            break;
                        }
                }

                if (res != null)
                    Console.WriteLine($"Переклад слова {scrin} буде: {res}");
                else
                    Console.WriteLine("Уви но такго слова немае! Спробуйте ще!");

                Console.ReadKey();
                
            }



        }
    }
}
