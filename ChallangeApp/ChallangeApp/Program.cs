
// ==  równa się
// != nie równa się
// >= mniejsze równe
// <= większe równe
// && warunek "i"
// || warunek "lub"
// ! negacja

var age = 15;
var name = "Ewa";
string sex = "mężczyzna";

if (age < 30 && sex == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{

}
