using BildWirdisCmdZeichnetBroKpWarumdassötschmache.Manger;
using System;
using System.Drawing;

namespace BildWirdisCmdZeichnetBroKpWarumdassötschmache // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { @"E:\Projekte\StupidProgramsDueToBoredom\BildWirdisCmdZeichnetBroKpWarumdassötschmache\TestBilder\test3.jpg" };
            if (args.Length != 1 || args[0].Contains("help")) ConsoleInfoManger.PrintHelp();

            if (!File.Exists(args[0])) ConsoleInfoManger.FileNotExists();

            var ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
            if (!ImageExtensions.Contains(Path.GetExtension(args[0]).ToUpperInvariant())) ConsoleInfoManger.FileIsNotImage();


            Console.Clear();

            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;

            //974 -> 90
            var bitmap = new Bitmap(args[0]);


            var jupWidth = (bitmap.Width / Console.WindowWidth);
            var jupHeight = (bitmap.Height / Console.WindowHeight);

            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    var color = bitmap.GetPixel(x * jupWidth, y * jupHeight);
                    var hexcolor = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                    var consoleColor = ClosestConsoleColor(color.R, color.G, color.B);
                    Console.ForegroundColor = consoleColor;
                    Console.BackgroundColor = consoleColor;
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }


        static ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
        {
            ConsoleColor ret = 0;
            double rr = r, gg = g, bb = b, delta = double.MaxValue;

            foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
            {
                var n = Enum.GetName(typeof(ConsoleColor), cc);
                var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n);
                var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
                if (t == 0.0)
                    return cc;
                if (t < delta)
                {
                    delta = t;
                    ret = cc;
                }
            }
            return ret;
        }



    }
}
