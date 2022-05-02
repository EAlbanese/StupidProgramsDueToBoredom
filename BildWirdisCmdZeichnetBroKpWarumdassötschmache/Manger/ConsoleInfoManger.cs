using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildWirdisCmdZeichnetBroKpWarumdassötschmache.Manger
{
    public static class ConsoleInfoManger
    {

        public static void FileNotExists() {
            Console.WriteLine("Alter du spassti das file gits nöd. Da gits hilf du kranke sich");
            Console.WriteLine();
            Console.WriteLine();
            PrintHelp();
            KillProgram();

        }

        public static void FileIsNotImage() {
            Console.WriteLine("Alter du spassti das file isch keis Image. Da gits hilf du kranke sich");
            Console.WriteLine();
            Console.WriteLine();
            PrintHelp();
            KillProgram();
        }

        public static void PrintHelp() {
            Console.WriteLine("HELP");
            Console.WriteLine();
            Console.WriteLine("was du brusch hilf isch selbst verständlich. LUG!!!");
            Console.WriteLine();
            Console.WriteLine("executionpath [Path zum Bild]");
            Console.WriteLine("executionpath --help <--- für die hilf du missgeburt");
            Console.WriteLine();
            Console.WriteLine("So komplizirt du spasst");
            KillProgram();
        }

        public static void KillProgram() {
            Environment.Exit(0);
        }
    }
}
