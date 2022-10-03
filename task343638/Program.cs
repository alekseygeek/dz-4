void task1()

{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.

    //[345, 897, 568, 234] -> 2
    //[345, 897, 568, 234] -> 2

    Console.Clear();
    Console.WriteLine("Задача 34:Задайте массив заполненный случайными положительными трёхзначными числами .\n Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("-----------------------------------------------------------------------------------");
    int[] LenArray(int leghth, int x, int y)
    {
        int[] array = new int[leghth];
        Random random = new Random();
        for (int i = 0; i < leghth; i++)
        {
            array[i] = random.Next(x, y);
        }
        return array;
    }
    void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + String.Join(",", arr) + "]");
    }
    int[] array1 = LenArray(5, 99, 999);
    PrintArray(array1);
    void FillArray(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) count++;
        }
        //  Console.WriteLine("[" + String.Join(",", array1) + "]");
        Console.WriteLine($" количество чётных чисел : {count}");
    }
    FillArray(array1);

}
void task2()
{

    // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

    Console.Clear();
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. ");
    Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("----------------------------------------------------------------------");

    int[] array = BillArray(4, 1, 10);

    int[] BillArray(int size, int min, int max)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(min, max);
        }
        return arr;
    }

    PrintArray(array);
    SumValues(array);

    void PrintArray(int[] array)
    {
        Console.WriteLine("[" + String.Join(",", array) + "]");

    }
    void SumValues(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                result += array[i];
            }
        }
        Console.WriteLine($" сумма нечётных позиций : {result}");
    }
}
void task3()
{

    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76
    Console.Clear();
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел.  ");
    Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine("-------------------------------------------------------------------");
    double[] array = FiilArray();
    PrintArray(array);
    SumValues(array);

    double[] FiilArray()
    {
        Random size = new Random();
        double[] array = new double[size.Next(2, 10)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((size.NextDouble() + size.Next(1, 10)), 1);
        }
        return array;
    }
    void PrintArray(double[] array)
    {
        Console.WriteLine("[" + String.Join("; ", array) + "]");
    }

    void SumValues(double[] array)
    {
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }

        Console.WriteLine("разница между min и max элементами массива равна :" + Math.Round((max - min), 1));
    }

}

Console.WriteLine("Введите номер задачи от 1 до 3: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
}



