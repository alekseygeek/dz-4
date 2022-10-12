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
    PrintArray(numbers);
    Console.WriteLine();
    ArrangeNumber(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями");

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


}
Console.Clear();
Console.WriteLine("\n Выберите задачу, которую хотите посмотреть:\n\t1 - Задача 54 \n\t2 - Задача 56 \n\t3 - Задача 58 \n\t4 - Выход");
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
        Console.WriteLine("Вы вышли из программы");
        break;
}

