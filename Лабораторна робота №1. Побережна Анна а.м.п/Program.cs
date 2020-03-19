using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота_1_а.м.п
{
    class Ownerofthecar //клас власника автомобіля
    {
        public string surname;
        public string carbrand;
        public string carnumber;
        public Ownerofthecar(string surname, string carbrand, string carnumber)
        {
            this.surname = surname;
            this.carbrand = carbrand;
            this.carnumber = carnumber;
        }

        public Ownerofthecar()
        { }

        public string carnumder { get; set; }
    }

    class Program
    {
        static void Recordfile() //функція запис у файл
        {
            Ownerofthecar[] owner = new Ownerofthecar[]
{
    new Ownerofthecar("Томсон", "Audi", "B34-61XM"),
    new Ownerofthecar("Шевченко", "BMW", "B72-12XM"),
    new Ownerofthecar("Демченко", "Bugatti", "B72-15XM"),
    new Ownerofthecar("Iванов", "Bentley", "B90-51XM"),
    new Ownerofthecar("Золотов", "Acura", "B72-15XM")
};
            StreamWriter str = new StreamWriter("INFO.TXT");
            for (int i = 0; i < 5; i++)
            {
                str.WriteLine(owner[i].surname);
                str.WriteLine(owner[i].carbrand);
                str.WriteLine(owner[i].carnumber);
            }
            str.Close();
        }

        static void Readingfile() //функція читання з файлу
        {
            string[] lines = System.IO.File.ReadAllLines("INFO.TXT");
            Ownerofthecar[] owner = new Ownerofthecar[5];
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                owner[i] = new Ownerofthecar();
            }
            for (int i = 0; i < lines.Length; i += 3)
            {
                owner[j].surname = lines[i];
                owner[j].carbrand = lines[i + 1];
                owner[j].carnumder = lines[i + 2];
                j = j + 1;
            }


            Console.WriteLine("Прiзвища власникiв автомобiлiв: ");
            int index = -1;
            int c = 0;
            do
            {
                index = Array.FindIndex(owner, index + 1, Number);
                if (index != -1)
                {
                    Console.WriteLine(owner[index].surname);
                    c = 1;
                }
            }
            while (index != -1);
            if (c == 0)
            {
                Console.WriteLine("Такого номера не має");
            }
        }


        static void Main(string[] args)
        {
            Recordfile();
            Readingfile();
        }


        private static bool Number(Ownerofthecar s)
        {
            if (s.carnumder.Contains("72-15"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}