//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] arr = new int[arrayLenght];

FillArray(arr);
PrintArray(arr);
SortArray(arr);


void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-10, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
          if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    }
}

void SortArray(int[] array)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.Write(" ]");

}