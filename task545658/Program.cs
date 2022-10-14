void task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

    Console.Clear();
    Random random = new Random();
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];

    FillArrayNumbers(numbers);
    Console.ForegroundColor = ConsoleColor.Green;
    PrintArray(numbers);
    Console.WriteLine();
    ArrangeNumber(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    Console.WriteLine("массив с упорядоченными значениями");

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
    void ArrangeNumber(int[,] array)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int r = 0; r < numbers.GetLength(1) - 1; r++)
                {
                    if (numbers[i, r] < numbers[i, r + 1])
                    {
                        int temp = 0;
                        temp = numbers[i, r];
                        numbers[i, r] = numbers[i, r + 1];
                        numbers[i, r + 1] = temp;
                    }
                }
            }
        }
    }
}
void task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

    Console.Clear();
    Random random = new Random();
    int rows = 5;
    int colums = 3;
    int[,] numbers = new int[rows, colums];

    FillArrayNumbers(numbers);
    ArrangeNumber(numbers);
    PrintArray(numbers);

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
    void ArrangeNumber(int[,] array)
    {
        int minSum = 0;
        int sumRows = SmallestSum(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int temp = SmallestSum(array, i);
            if (sumRows > temp)
            {
                sumRows = temp;
                minSum = i;
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Наименьшая сумма элементов = {sumRows}, находится в {minSum + 1} строке.");
        int SmallestSum(int[,] array, int i)
        {
            int sum = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            return sum;
        }
    }
}
void task58()
{
    // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

    Console.Clear();
    int size = 2;
    int[,] matrixA = new int[size, size];
    int[,] matrixB = new int[size, size];
    int[,] matrixC = new int[size, size];

    void MultiplyMatrix(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 4);
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

    MultiplyMatrix(matrixA);
    MultiplyMatrix(matrixB);

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица: А");
    PrintArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица: В");
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц");
    PrintArray(matrixC);

}
void task64()
{
    // Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 5 -> 2, 4
    // M = 4; N = 8 -> 4, 6, 8

    Console.Clear();
    int IntNumber()
    {
        Console.Write("Введите число : ");
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    int n = IntNumber();
    int m = IntNumber();

    void AllEven(int bigNum, int lowNum)
    {
        if (lowNum <= bigNum)
        {
            if (lowNum % 2 == 0)
            {
                Console.Write($"{lowNum}, ");
                lowNum++;
                AllEven(bigNum, lowNum);
            }
            else
            {
                lowNum++;
                AllEven(bigNum, lowNum);
            }
        }
    }

    AllEven(m, n);
}
void task66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8 -> 30

    Console.Clear();
    int M = 4;
    int N = 8;
    int Recurs(int M, int N)
    {
        if (M == N)
            return N;
        return N + Recurs(M, N - 1);
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {Recurs(M, N)}");
}

void task68()
{
    // Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
    // M = 28; N = 7 -> 7

    Console.Clear();
    int M = 28;
    int N = 7;
    int Recurs(int M, int N)
    {
        if (N == 0)
        {
            return M;
        }
        else
            return Recurs(N, M % N);

    }
    int result = Recurs(M, N);
    Console.Write(result);

}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n Выберите задачу, которую хотите посмотреть:\n\t1 - Задача 54 \n\t2 - Задача 56 \n\t3 - Задача 58\n\t4 - Задача 64 \n\t5 - Задача 66 \n\t6 - Задача 68 \n\t7 - Выход");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        task54();
        break;
    case 2:
        task56();
        break;
    case 3:
        task58();
        break;
    case 4:
        task64();
        break;
    case 5:
        task66();
        break;
    case 6:
        task68();
        break;
    case 7:
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы вышли из программы");
        break;
}

