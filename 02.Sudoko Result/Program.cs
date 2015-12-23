using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sudoko_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCounter = 0;
            double secondsTotal = 0;
            double totalTimeInSec = 0;
            string SudokoTime = Console.ReadLine();
            while (SudokoTime != "Quit")
            {
                string[] Splitted = SudokoTime.Split(':');
                string min = Splitted[0];
                string sec = Splitted[1];
                //minutesTotal += int.Parse(min);
                secondsTotal += (int.Parse(sec)) + (int.Parse(min)*60);
                gamesCounter++;
                
                SudokoTime = Console.ReadLine();
            }
            totalTimeInSec += secondsTotal;
            double averTime = totalTimeInSec / gamesCounter;
            int average = (int)Math.Ceiling(averTime);
            if (averTime < 720) 
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesCounter, average);
                return;
            }
            else 
            {
                Console.WriteLine("{0}", ((averTime >= 720) && (averTime < 1440)) ? "Silver Star" : "Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesCounter, average);
            }
        }
    }
}
