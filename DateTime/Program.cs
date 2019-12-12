using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        public static void functie()
        {
            //introducere date
            Console.WriteLine("Introduceti anul nasterii, luna, ziua si sexul M/F. Exemplu: 1994 11 22 M");
            string[] str = Console.ReadLine().Split();
            //verificare date introduse
            while (str.Length != 4 || Int32.Parse(str[1]) > 12 || Int32.Parse(str[2]) > 30 || Int32.Parse(str[1]) <= 0 || Int32.Parse(str[2]) <= 0 || Int32.Parse(str[0]) <= 0 || Int32.Parse(str[0]) > DateTime.Today.Date.Year)
            {
                Console.WriteLine("Fiti atent la exemplu si nu introduceti baliverne. Exemplu: 1994 11 22 M");
                str = Console.ReadLine().Split();
            }
            //conversie la date de tip DateTime
            string data = str[0] + " " + str[1] + " " + str[2];
            DateTime birthdate = DateTime.Parse(data).Date;
            Nullable<Gender> gen;
            //Verificarea genului
            if (str[3] == "M" || str[3] == "m")
            {
                gen = Gender.Male;
            }
            else if (str[3] == "F" || str[3] == "f")
            {
                gen = Gender.Female;
            }
            else
            {
                gen = null;
            }
            //Aflarea varstei in functie de gen
            if (gen != null)
            {
                DateTime today = DateTime.Today.Date;
                if (gen == Gender.Male)
                {
                    int age = today.Year - birthdate.Year;
                    if (age < 65)
                    {
                        Console.WriteLine("Esti tanar si mai ai de muncit inca " + (65 - age) + " ani. Te vei pensiona in anul " + (today.Year + (65 - age)));
                    }
                    else
                    {
                        Console.WriteLine("Pensionare placuta!");
                    }
                }
                else
                {
                    int age = today.Year - birthdate.Year;
                    if (age < 63)
                    {
                        Console.WriteLine("Esti tanara si mai ai de muncit inca " + (63 - age) + " ani. Te vei pensiona in anul " + (today.Year + (63 - age)));
                    }
                    else
                    {
                        Console.WriteLine("Pensionare placuta!");
                    }
                }
            }
            //Posibilitatea reincercarii in caz de esec
            else
            {
                Console.WriteLine("Daca vreti sa va aflati varsta de pensionare, introduceti corect sexul, dupa cum este specificat. M/m pentru barbati si F/f pentru femei. Vreti sa aflati? Y/N");
                string raspuns = Console.ReadLine();
                if(raspuns == "Y")
                {
                    functie();
                }
                else
                {
                    Console.WriteLine("Sa va fie de bine. Zi faina!");
                }
            }
        }
        static void Main(string[] args)
        {
            functie();
            Console.ReadKey();
        }
    }
}
