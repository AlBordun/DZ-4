/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int SumAllDigits = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + SumAllDigits);