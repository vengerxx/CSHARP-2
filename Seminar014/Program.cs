// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

System.Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number)
{
    int sum = 0;
    for(int i = 1; i <= userNumber; i++)
{
    sum += i;
}
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {userNumber} равна {SumOfNumber(userNumber)}");