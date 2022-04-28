using Testing;

var person = new Person() {
    Name = "Elia",
    Gener = "M"
};

var personcopy1 = person.Clone();
var personcopy2 = person;
person.Gener = "w";

Console.WriteLine(personcopy1);
