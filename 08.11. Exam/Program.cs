using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberCandidates = int.Parse(Console.ReadLine());
            int numberElected = int.Parse(Console.ReadLine());
            string mark = Console.ReadLine().ToUpper();
            string  FirstLine = ".............";
            string SecondLine = "...+-----+...";
            string  ThirdLine = "...|.....|...";
            string UpperMarkedLine = "...|.\\./.|...";
            string LowerMarkedLine = "...|./.\\.|...";
                        
            for (int i = 1; i <= numberCandidates; i++)
            {
                Console.WriteLine(FirstLine);
                Console.WriteLine(SecondLine);
                if(i == numberElected)
                {
                    if (mark == "X")
                    {
                        Console.WriteLine(UpperMarkedLine);
                        Console.WriteLine("{0}.|..{1}..|...", i < 10 ? "0" + i : i.ToString(), mark);
                        Console.WriteLine(LowerMarkedLine);
                    }
                    else
                    {
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine("{0}.|.\\./.|...", i < 10 ? "0" + i : i.ToString());
                        Console.WriteLine("...|..{0}..|...", mark);
                        
                    }
                }
                else
                {
                    Console.WriteLine(ThirdLine);
                    Console.WriteLine("{0}.|.....|...", i < 10 ? "0" + i : i.ToString());
                    Console.WriteLine(ThirdLine);
                }
                
                Console.WriteLine(SecondLine);
               
            }
            Console.WriteLine(FirstLine);
        }
    }
}
