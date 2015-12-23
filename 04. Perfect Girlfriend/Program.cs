using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Perfect_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {

            int PerfectGirlfrind = 0;
            string input = Console.ReadLine();
            while (input != "Enough dates!") 
            {
                string[] Splitted = input.Split('\\');
                string day = Splitted[0];
                string phone = Splitted[1];
                string bra = Splitted[2];
                string Name = Splitted[3];

                int result = 0;
                int numberOfDay = 0;
                //Days
                switch (day)
                {
                    case "Monday" : numberOfDay += 1; break;
                    case "Tuesday": numberOfDay += 2; break;
                    case "Wednesday": numberOfDay += 3; break;
                    case "Thirsday": numberOfDay += 4; break;
                    case "Friday": numberOfDay += 5; break;
                    case "Saturday": numberOfDay += 6; break;
                    case "Sunday": numberOfDay += 7; break;
                    default:
                        break;
                }
               // Console.WriteLine(numberOfDay);
                result += numberOfDay;
                int sumOfPhone = 0;
                //PhoneNumber calculation
                foreach (var ch in phone)
                {
                    sumOfPhone += (int)ch - 48;
                }
               // Console.WriteLine(sumOfPhone);
                result += sumOfPhone;
                // Bra calculation
               char BraLetter = (bra[bra.Length - 1]);
               int Brasize = int.Parse(bra.Substring(0, bra.Length-1));
               // Console.WriteLine(Brasize * BraLetter);
                
                result += (Brasize * BraLetter);
                // Name
                int FirstLetter = char.Parse(Name.Substring(0, 1));
                int NameSum = FirstLetter * Name.Length;
               // Console.WriteLine(NameSum);
                result -= NameSum;
                // Console.WriteLine(result);
                if (result < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", Name);
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you.", Name);
                    PerfectGirlfrind++;
                }

                input = Console.ReadLine();

            }
           
            Console.WriteLine(PerfectGirlfrind);
        }
    }
}
