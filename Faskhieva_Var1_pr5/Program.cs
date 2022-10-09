using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Faskhieva_Var1_pr5
{
    struct Horoscope
    {
        public string day;
        public string month;
        public string year;
        public string horos;
        public string horEast;

        public void show()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3, -15} {4, -15}", day, month, year, horos, horEast);
        }

        public string concat()
        {
            return day + ";" + month + ";" + year + ";" + horos + ";" + horEast;
        }
    }
    internal class Program
    {
        static void getData(string path, List<Horoscope> L)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] arr = sr.ReadLine().Split(';');
                    L.Add(new Horoscope()
                    {
                        day = arr[0],
                        month = arr[1],
                        year = arr[2]
                    });
                }
            }
        }
        static void printData(List<Horoscope> L)
        {
            foreach (Horoscope h in L)
            {
                h.show();
            }
        }
        static void createF(string path, List<Horoscope> L)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (Horoscope h in L)
                {
                    sw.WriteLine(h.concat());
                }
            }
        }
        static void entry(List<Horoscope> L)
        {
            for (int i = 0; i < L.Count; i++)
            {
                Horoscope h = L[i];
                int forParse = 0;

                if (h.day == "" || h.month == "" || !int.TryParse(h.day, out forParse) || !int.TryParse(h.month, out forParse))
                {
                    h.horos = "Невозможно определить знак зодиака!";
                }
                else
                {
                    if (((Convert.ToInt32(h.day) >= 22) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 11) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 0))
                    {
                        h.horos = "Знак зодиака - Козерог.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 0) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 18) && Convert.ToInt32(h.month) == 1))
                    {
                        h.horos = "Знак зодиака - Водолей.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 19) && (Convert.ToInt32(h.day) <= 28) && Convert.ToInt32(h.month) == 1) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 2))
                    {
                        h.horos = "Знак зодиака - Рыбы.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 2) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 19) && Convert.ToInt32(h.month) == 3))
                    {
                        h.horos = "Знак зодиака - Овен.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 20) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 3) || (Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 4)
                    {
                        h.horos = "Знак зодиака - Телец.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 4) || (Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 21) && Convert.ToInt32(h.month) == 5)
                    {
                        h.horos = "Знак зодиака - Близнецы.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 5) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 6))
                    {
                        h.horos = "Знак зодиака - Рак.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 6) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 7))
                    {
                        h.horos = "Знак зодиака - Лев.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 7) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 8))
                    {
                        h.horos = "Знак зодиака - Дева.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 8) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 23) && Convert.ToInt32(h.month) == 9))
                    {
                        h.horos = "Знак зодиака - Весы.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 24) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 9) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 10))
                    {
                        h.horos = "Знак зодиака - Скорпион.";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 10) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 21) && Convert.ToInt32(h.month) == 11))
                    {
                        h.horos = "Знак зодиака - Стрелец.";
                    }
                }
                if (h.year == "" || !int.TryParse(h.year, out forParse))
                {
                    h.horEast = "Невозможно определить Восточный гороскоп!";
                }
                else
                {
                    if (Convert.ToInt32(h.year) % 12 == 0)
                    {
                        h.horEast = "Восточный гороскоп - Обезьяна.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 1)
                    {
                        h.horEast = "Восточный гороскоп - Петух.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 2)
                    {
                        h.horEast = "Восточный гороскоп - Собака.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 3)
                    {
                        h.horEast = "Восточный гороскоп - Свинья.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 4)
                    {
                        h.horEast = "Восточный гороскоп - Крыса.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 5)
                    {
                        h.horEast = "Восточный гороскоп - Бык.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 6)
                    {
                        h.horEast = "Восточный гороскоп - Тигр.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 7)
                    {
                        h.horEast = "Восточный гороскоп - Кролик.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 8)
                    {
                        h.horEast = "Восточный гороскоп - Дракон.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 9)
                    {
                        h.horEast = "Восточный гороскоп - Змея.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 10)
                    {
                        h.horEast = "Восточный гороскоп - Лошадь.";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 11)
                    {
                        h.horEast = "Восточный гороскоп - Коза.";
                    }
                }
                L[i] = h;
            }
        }
        static void Main(string[] args)
        {
            List<Horoscope> horoscopes = new List<Horoscope>();
            getData("horoscopeEastern.csv", horoscopes);
            entry(horoscopes);
            printData(horoscopes);
            Console.WriteLine();
            createF("NewHoroscopeEastern.csv", horoscopes);
        }
    }
}