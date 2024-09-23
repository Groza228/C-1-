// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Xml.Schema;

Console.WriteLine("Hello, World!");
//Завдання №1 Парні від 1 до 20
/*int number = 0;
while (number != 20)
{
    number += 1;
    if (number % 2 == 0)
        Console.WriteLine(number);
}*/

// Завдання №2 Сума чисел від 1 до 100
/*int number = 0, sum_of_numbers  =  0;
while (number != 100)
{
    number += 1;
    sum_of_numbers += number;
}
Console.WriteLine(sum_of_numbers);*/

//Завдання №3 Таблиця множення
/*int number, multiplier = 0, result = 0;
Console.WriteLine("Введiть число для виведення таблицi множення: ");
number = int.Parse(Console.ReadLine());
while (multiplier != 10)
{
    multiplier += 1;
    result = number * multiplier;
    Console.WriteLine($"{number} * {multiplier} = {result}");
}*/

//Завдання №4 Факторіал
/*int factorial, result = 1, multiplier = 0;
Console.WriteLine("Введiть факторiал: ");
factorial = int.Parse(Console.ReadLine());
while (multiplier != factorial)
{
    multiplier += 1;
    result *= multiplier;
}
Console.WriteLine($"Факторiал {factorial} дорiвнює {result}");*/

//Завдання №5 Сума простих чисел від 1 до 50
/*int result = 17, number = 0;
while (number != 50)
{
    number += 1;
    if ((number % 2 != 0) && (number % 3 != 0 ) && (number % 5 != 0) && (number % 7 != 0))
         { result += number;
    }
}
Console.WriteLine(result);*/

//Завдання №6 Перевод числа у двійкову систему 
/*string result = "";
int number, actual_number;  
Console.WriteLine("Введiть число:");
number = int.Parse(Console.ReadLine());
while (number > 0)
{
    actual_number = number % 2;
    result = actual_number + result;
    number /= 2;
    
}
Console.WriteLine(result);*/

//Завдання №7 Сума чисел Фібоначі
/*int count = 0, fibonachi_0 = 0, fibonachi_1 = 1, fibonachi_next, sum_of_fibonachi_number = 0, limit;
Console.WriteLine("Введiть число");
limit = int.Parse(Console.ReadLine());
while (fibonachi_0 < limit)
{
    sum_of_fibonachi_number += fibonachi_0;
    count += 1;
    fibonachi_next = fibonachi_0 + fibonachi_1;
    fibonachi_0 = fibonachi_1;
    fibonachi_1 = fibonachi_next;
}
Console.WriteLine(sum_of_fibonachi_number);
Console.WriteLine(count);*/

//Завдання №8 Найбільший спільний дільник
/*int number_1, number_2, divider = 0, count = 0, max_number;
Console.WriteLine("Введiть перше число");
number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть друге число");
number_2 = int.Parse(Console.ReadLine());

max_number = Math.Max(number_1, number_2);
while (count != max_number)
{
    count += 1;
    if ((number_1 % count == 0) && (number_2 % count == 0))
        divider = count;
}

Console.WriteLine(divider);*/