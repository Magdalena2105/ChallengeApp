
// liczby calkowite
using System;

int myAge = 120;
int newAge = myAge + 5;
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

// zmienne tekstowe
string name = "Magdalena";
string surname = "Antosik";
string result = name + surname + myAge;
//Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

// zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);