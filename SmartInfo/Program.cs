//Console.WriteLine("#####        #####     ################    ###           ###");
//Console.WriteLine("#####        #####     ################     ###         ###");
//Console.WriteLine("#####        #####     #####                 ###       ###");
//Console.WriteLine("#####        #####     #####                  ###     ###");
//Console.WriteLine("##################     ###########             ###   ###");
//Console.WriteLine("##################     ###########               #####");
//Console.WriteLine("#####        #####     #####                     #####");
//Console.WriteLine("#####        #####     #####                     #####");
//Console.WriteLine("#####        #####     ################          #####");
//Console.WriteLine("#####        #####     ################          #####");

string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
DateTime dateTimeNow = DateTime.Now;

bool option = true;
int wetterHeute = 1;
int wetterWoche = 2;
int mittag = 3;
int feierabend = 4;
int exit = 5;

DateTime dateTime = DateTime.Now;
DateTime lunch = DateTime.Today.AddHours(12);
DateTime workEndDay = DateTime.Today.AddHours(17);

while (option)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Hallo " + userName);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("Heute ist der: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(dateTimeNow.ToString("dddd, dd. MMMM yyyy"));
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Zurzeit ist es: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(dateTimeNow.ToString("HH:mm:ss"));
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("Was möchtest du nachsehen?");
    Console.WriteLine();
    Console.WriteLine("1) Wetter von heute");
    Console.WriteLine("2) Wetter für die ganzee Woche");
    Console.WriteLine("3) Wie lange noch bis zum Mittag?");
    Console.WriteLine("4) Wie lange noch bis zum Feierabend?");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("5) Programm beenden");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("Deine Eingabe: ");
    string input = Console.ReadLine();
    Console.Clear();
    int inputInt = int.Parse(input);

    if (inputInt == wetterHeute)
    {
        Console.WriteLine("1");
        Console.WriteLine();
        Console.WriteLine("Enter drücken für Hauptmenü");
        Console.ReadLine();
        Console.Clear();
    }
    else if (inputInt == wetterWoche)
    {
        Console.WriteLine("2");
        Console.WriteLine();
        Console.WriteLine("Enter drücken für Hauptmenü");
        Console.ReadLine();
        Console.Clear();
    }
    else if (inputInt == mittag && dateTime <= lunch)
    {
        TimeSpan ts = lunch - dateTime;
        DateTime mittagTime = new DateTime() + ts;
        Console.Write("Du musst noch: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write((mittagTime).ToString("HH:mm:ss"));
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(" Stunden arbeiten bis du essen kannst");
        Console.WriteLine("Enter drücken für Hauptmenü");
        Console.ReadLine();
        Console.Clear();
    }
    else if (inputInt == feierabend)
    {
        TimeSpan ts = workEndDay - dateTime;
        DateTime feierabendTime = new DateTime() + ts;
        Console.Write("Du musst noch: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write((feierabendTime).ToString("HH:mm:ss"));
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Stunden arbeiten bis du nach Hause gehen kannst");
        Console.WriteLine();
        Console.WriteLine("Enter drücken für Hauptmenü");
        Console.ReadLine();
        Console.Clear();
    }
    else if (inputInt == exit)
    {
        option = false;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Bitte wähle eine der oben genannten Nummern.");
    }
}