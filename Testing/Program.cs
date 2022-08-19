using Testing;

var rnd = new Random();
while (true) { 
    Console.WriteLine($"{rnd.Next(0,100)}");

    Console.ReadLine();
}



//Test Cloing of Objects

var person = new Person()
{
    Name = "Elia",
    Gener = "M"
};
var personcopy1 = person.Clone();
var personcopy2 = person;
person.Gener = "w";
Console.WriteLine(personcopy1);
var test = "asdsad,,ad123".Split(",");
foreach (var item in test)
{
    Console.WriteLine(item);

}


//Testing what a Extension can do
person = new Person()
{
    Name = "Severin",
    Gener = "W"
};
person.ChangeGenderToM();
Console.WriteLine(person.ToString());


//Comparing strings with tolerance
Console.WriteLine("Comparing strings with tolerance\n");
Console.WriteLine(LevenshteinDistance.Compute("aunt", "aunt"));

Console.WriteLine("yield Testing");

Console.WriteLine(Integers().First());
Console.WriteLine(Integers().First());

IEnumerable<int> Integers()
{
    var listofStrings = new List<int>() { 31, 21, 41 };
    foreach (var x in listofStrings)
    {
        yield return x;
    }
    yield return 1;
    yield return 2;
    yield return 4;
    yield return 8;
    yield return 16;
    yield return 16777216;
}

//Testing Equals
Console.WriteLine("\n ---- Testing Equals ---- \n");

var per1 = new Person() { Gener = "M", Name = "Test" };
var per2 = new Person() { Gener = "M", Name = "Test" };
var per3 = per1;
//https://coding.abel.nu/2014/09/net-and-equals/
Console.WriteLine("object Equals: new object same Data: " + (object.Equals(per1, per2) ? "ja" : "nein"));
Console.WriteLine("object Equals: wiht per3 ref per1:   " + (object.Equals(per1, per3) ? "ja" : "nein"));
