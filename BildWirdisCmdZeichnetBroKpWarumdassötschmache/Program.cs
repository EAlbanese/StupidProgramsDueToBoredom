using BildWirdisCmdZeichnetBroKpWarumdassötschmache.Manger;
using OfficeOpenXml;
using System;
using System.Drawing;

namespace BildWirdisCmdZeichnetBroKpWarumdassötschmache // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            args = new string[] { @"C:\Users\severin.senn\Documents\GitHub\StupidProgramsDueToBoredom\BildWirdisCmdZeichnetBroKpWarumdassötschmache\TestBilder\test44.jpg" };
            if (args.Length != 1 || args[0].Contains("help")) ConsoleInfoManger.PrintHelp();

            if (!File.Exists(args[0])) ConsoleInfoManger.FileNotExists();

            var ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
            if (!ImageExtensions.Contains(Path.GetExtension(args[0]).ToUpperInvariant())) ConsoleInfoManger.FileIsNotImage();


            Console.Clear();
            CreateExcelImage(args);
            //DrawInConsole(args);


        }

        static void CreateExcelImage(string[] args)
        {
            var bitmap = new Bitmap(args[0]);

            var excelSavePath = @"C:\Users\severin.senn\Documents\GitHub\StupidProgramsDueToBoredom\BildWirdisCmdZeichnetBroKpWarumdassötschmache\sample1.xlsx";
            if (File.Exists(excelSavePath)) File.Delete(excelSavePath);

            var package = new ExcelPackage(excelSavePath);
            var worksheet = package.Workbook.Worksheets.Add(args[0].Split(Path.DirectorySeparatorChar).Last());
            worksheet.DefaultColWidth = 2;

            var allPixelsCount = bitmap.Height * bitmap.Width;
            var pixelsMaped = 0;
            //TODO IF Max Limit of excel 1,048,576 rows by 16,384 columns
            //TODO Performce
            Console.Write("Performing Mapping... ");
            var progress = new ProgressBar();
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    worksheet.Cells[y + 1, x + 1].Style.Fill.SetBackground(color);

                    pixelsMaped++;
                    progress.Report((double)pixelsMaped / allPixelsCount);
                }

            }

            package.Save();
            Console.WriteLine("Done.");
        }

        static void DrawInConsole(string[] args)
        {

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
                    var consoleColor = ConsoleManger.ClosestConsoleColor(color.R, color.G, color.B);
                    Console.ForegroundColor = consoleColor;
                    Console.BackgroundColor = consoleColor;
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }








    }
}
