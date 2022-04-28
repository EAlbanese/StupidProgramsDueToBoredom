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
    //public class User
    //{
    //    public string Username { get; set; }
    //    public string Email { get; set; }
    //    public string IP { get; set; }
    //    public int ID { get; set; }
    //}
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            DateTime lunch = DateTime.Today.AddHours(12);
            DateTime workEndDay = DateTime.Today.AddHours(17);

            Console.WriteLine("Die Aktuelle Zeit: " + dateTime.ToString("HH:mm:ss") + " Uhr");
            Console.WriteLine();
            if(DateTime.Now <= lunch)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Du musst noch: {(lunch - dateTime):T} Stunden arbeiten bis du essen kannst");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Du musst noch: {(workEndDay - dateTime):T} Stunden arbeiten bis du nach Hause gehen kannst");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}