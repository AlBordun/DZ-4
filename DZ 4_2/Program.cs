//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write("Введите ряд чисел : ");
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
int[] GenArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    {
        System.Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[array.Length - 1]}");
    }
    System.Console.WriteLine("]");
}
int Length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение: ");
int max = Prompt("Конечное значение: ");
int[] array = GenArray(Length, min, max);

PrintArray(array);