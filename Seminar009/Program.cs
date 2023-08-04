// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine(number);

int numberOne = number / 10;
Console.WriteLine(numberOne);

int numberTwo = number % 10;
Console.WriteLine(numberTwo);

if(numberOne > numberTwo)
{
    Console.WriteLine($"Наибольшая цифра числа {number} - {numberOne}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа {number} - {numberTwo}");
}
