void task46()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);

    double[,] numbers = new double[rows, colums];

    FillArrayNumbers(numbers);
    PrintArray(numbers);

    void FillArrayNumbers(double[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
            }
        }
    }
    void PrintArray(double[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
void task50()
{
    //  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.Clear();
    Console.Write("введите номер строки до  3 :");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите номер столбца до 4 :");
    int colum = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    int[,] numbers = new int[3, 4];

    FillArrayNumbers(numbers);
    PrintArray(numbers);

    if (line > numbers.GetLength(0) || colum > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {line} строки и {colum} столбца равно {numbers[line - 1, colum - 1]}");
    }
    void FillArrayNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-100, 100) / 10;
            }
        }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }

}
void task52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Console.Clear();
    // Console.WriteLine("введите номер строки");
    // int line = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("введите номер столбца");
    // int colum = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int rows = random.Next(3, 6);
    int colums = random.Next(3, 6);
    int[,] numbers = new int[rows, colums];

    FillArrayNumbers(numbers);
    PrintArray(numbers);
    ArithmeticMeanNumber(numbers);

    void FillArrayNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(10, 100) / 10;
            }
        }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
    void ArithmeticMeanNumber(int[,] array)
    {
        Console.WriteLine();
        Console.Write("[");
        for (int i = 0; i < array.GetLength(1); i++)
        {
            double result = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                result += array[j, i];
            }
            if (i < array.GetLength(1) - 1) Console.Write(result / array.GetLength(0) + ", ");
            else Console.Write(result / array.GetLength(0) + "]: среднее арифметическое элементов в каждом столбце.");
        }
    }
}
Console.Clear();
Console.WriteLine("\n Выберите задачу, которую хотите посмотреть:\n\t1 - Задача 46 \n\t2 - Задача 50 \n\t3 - Задача 52 \n\t4 - Выход");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        task46();
        break;
    case 2:
        task50();
        break;
    case 3:
        task52();
        break;
    case 4:
        Console.WriteLine("Вы вышли из программы");
        break;
}

