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
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti anul nasterii, luna, ziua si sexul M/F. Exemplu: 1994 11 22 M");
            string[] str = Console.ReadLine().Split();
            string data = str[0] + " " + str[1] + " " + str[2];
            DateTime birthdate = DateTime.Parse(data).Date;
            Nullable<Gender> gen;
            if (str[3] == "M" || str[3] == "m")
            {
                gen = Gender.Male;
            }
            else if(str[3] == "F" || str[3] == "f")
            {
                gen = Gender.Female;
            }
            else
            {
                gen = null;
            }

            if(gen != null)
            {
                if(gen == Gender.Male)
                {

                }
            }
            Console.WriteLine(gen);
            Console.ReadKey();
        }
    }
}
