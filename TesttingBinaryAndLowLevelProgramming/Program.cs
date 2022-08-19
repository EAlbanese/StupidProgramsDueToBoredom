const string FilePath = @"C:\temp\Laax\GR_515\2020_07_06_0825\2020_07_06_0825.pcap";

byte[] readText = File.ReadAllBytes(FilePath);
var reader = new StreamReader(FilePath);
string line;
while ((line = reader.ReadLine()) != null) {
    Console.WriteLine(line);
}

