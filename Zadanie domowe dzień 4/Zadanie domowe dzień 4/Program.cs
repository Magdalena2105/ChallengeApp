// Zadanie domowe dzień 4
var age = 33;
bool woman = true;
string name = "Ewa";

if (age < 18 && woman == false)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (age < 30 && woman == true)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}