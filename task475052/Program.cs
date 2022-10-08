void task46()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);

    double[,] numbers = new double[rows, colums];

    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    void FillArrayRandomNumbers(double[,] array)
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





}
void task52()
{





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
        Console.WriteLine("Досвидание");
        break;
}

