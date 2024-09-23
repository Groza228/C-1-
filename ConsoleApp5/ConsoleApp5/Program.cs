// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
// Завдання 1 "Перевірка числа"
/*int digit;
Console.WriteLine("Введіть число: ");
digit = int.Parse(Console.ReadLine());

if (digit < 0)
    Console.WriteLine("Число вiд'ємне");
else if (digit == 0)
    Console.WriteLine("Число рiвне нулю");
else
    Console.WriteLine("Число додатнє");
*/
// Завдання 2 "Чи є рік високосним"
/*int year;
Console.WriteLine("Введiть рiк: ");
year = int.Parse(Console.ReadLine());
if ((year % 4 == 0) & (year % 100 != 0))
{
    Console.WriteLine("Високосний");
}
else if ((year % 400 == 0))
{
    Console.WriteLine("Високосний");
}
else
{
    Console.WriteLine("Не високосний");
}
*/
// Завдання 3 "Податок на дохід"
/*int income, tax;
Console.WriteLine("Введiть рiчний дохiд: (грн)");
income = int.Parse(Console.ReadLine());
if ((income >= 0) & (income <= 3000))
{
    tax = income / 100 * 5;
    Console.WriteLine($"Податок становить {tax} грн");
}
else if ((income > 3000) & (income <= 4000))
{
    tax = income / 100 * 10;
    Console.WriteLine($"Податок становить {tax} грн");
}
else if ((income > 4000) & (income <= 5000))
{
    tax = income / 100 * 15;
    Console.WriteLine($"Податок становить {tax} грн");
}
*/
// Завдання 4 "Чи символ є голосним"
/*string symbol, lower_symbol;
Console.WriteLine("Введiть букву: ");
symbol = Console.ReadLine();
lower_symbol = symbol.ToLower();
if ((lower_symbol == "a") || (lower_symbol == "e") || (lower_symbol == "i") || (lower_symbol == "o") || (lower_symbol == "u"))
    Console.WriteLine("Голосна");
else
    Console.WriteLine("Приголосна");
*/
//Завдання 5 "Більше з чисел"
/*int numeric_1, numeric_2, numeric_3, max_1, max_final;
Console.WriteLine("Введiть перше число");
numeric_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть друге число");
numeric_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть третє число");
numeric_3 = int.Parse(Console.ReadLine());

max_1 = Math.Max(numeric_1, numeric_2);
max_final = Math.Max(max_1, numeric_3);
Console.WriteLine(max_final);*/
// Завдання 6 "Чи є введені роки підліткові?"
/*
int age;
Console.WriteLine("Введiть вiк:");
age = int.Parse(Console.ReadLine());
if ((age >= 12) & (age <= 18))
    Console.WriteLine("Пiдлiтковий вiк");
else
    Console.WriteLine("Не пiдлiтковий вiк");
*/
// Завдання 7 "Чи є число парним та чи ділиться на 3"
/*int numeric;
Console.WriteLine("Введiть числло");
numeric = int.Parse(Console.ReadLine());

if (numeric % 2 == 0)
{
    if (numeric % 3 == 0)
    { Console.WriteLine($"Число {numeric} парне та дiлиться на 3"); }
    else
    { Console.WriteLine($"Число {numeric} парне, але не дiлиться на 3"); }
}
else if (numeric % 2 != 0)
{
    if (numeric % 3 == 0)
    { Console.WriteLine($"Число {numeric} не парне, але дiлиться на 3"); }
    else
    { Console.WriteLine($"Число {numeric} не парне та не дiлиться на 3"); }
}*/
// Завдання 8 "Найдовша сторона"
/*int side_a,  side_b, side_c, max_1, max_final;
Console.WriteLine("Введiть значення сторони а: ");
side_a = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть значення сторони b: ");
side_b = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть значення сторони c: ");
side_c = int.Parse(Console.ReadLine());
max_1 = Math.Max(side_a, side_b);
max_final = Math.Max(max_1, side_c);

if (max_final == side_a)
    Console.WriteLine($"Найдовша сторона a з довжиною {max_final} см");
else if (max_final == side_b)
    Console.WriteLine($"Найдовша сторона b з довжиною {max_final} см");
else if (max_final == side_c)
    Console.WriteLine($"Найдовша сторона c з довжиною {max_final} см");*/