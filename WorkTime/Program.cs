using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorkTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            int mittag = 1;
            int feierabend = 2;
            int beenden = 3;
            bool workTime = true;
            DateTime dateTime = DateTime.Now;
            DateTime lunch = DateTime.Today.AddHours(12);
            DateTime workEndDay = DateTime.Today.AddHours(17);

            while (workTime)
            {
                Console.Clear();
                Console.WriteLine("Hallo, du willst eine bestimmte Zeit wissen?");
                Console.WriteLine();
                Console.WriteLine("Es ist " + dateTime.ToString("HH:mm:ss") + " Uhr");
                Console.WriteLine();
                Console.WriteLine("1) Wie lange noch bis zum Mittag?");
                Console.WriteLine("2) Wie lange noch bis zum Feierabend?");
                Console.WriteLine("3) Programm beenden");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Deine Eingabe: ");
                string input = Console.ReadLine();
                Console.Clear();
                int inputInt = int.Parse(input);

                if (inputInt == mittag)
                {
                    TimeSpan ts = lunch - dateTime;
                    DateTime mittagTime = new DateTime() + ts;
                    Console.WriteLine("Du musst noch: " + (mittagTime).ToString("HH:mm:ss") + " Stunden arbeiten bis du essen kannst");
                    Console.WriteLine();
                    Console.WriteLine("Enter drücken für Hauptmenü");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (inputInt == feierabend)
                {
                    TimeSpan ts = workEndDay - dateTime;
                    DateTime feierabendTime = new DateTime() + ts;
                    Console.WriteLine("Du musst noch: " + (feierabendTime).ToString("HH:mm:ss") + " Stunden arbeiten bis du nach Hause gehen kannst");
                    Console.WriteLine();
                    Console.WriteLine("Enter drücken für Hauptmenü");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (inputInt == beenden)
                {
                    workTime = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Bitte wähle eine der oben genannten Nummern.");
                }
            }

        }
    }
}