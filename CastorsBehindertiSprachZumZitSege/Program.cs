using System;
using System.Windows.Forms;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //Verweiss im dll order Hinzufügen
        [STAThread]
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var firabig = new DateTime(now.Year, now.Month, now.Day, 16, 50, 0);

            var std = firabig.Hour - now.Hour;
            var min = firabig.Minute - now.Minute;
            var res = "nur no";

            for (int i = 1; i <= min; i++)
            {
                res += " 1 minute und no mal";
            }

            for (int i = 1; i <= std; i++)
            {
                res += " 1 Stund und no mal";
            }
            res = res.Substring(0, res.Length - 10);
            res += "bis zum firabig";
            Console.WriteLine("Wurde ins Clipboard kopiert");

            Clipboard.SetText(res);
        }
    }
}



