// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine($"Введите размер массива M чисел");
int count = int.Parse(Console.ReadLine());

int NowNum(int array)

{
    Console.WriteLine("Введите число: ");
    int[] arr = new int[array];
    int count = 0;
    for (int i = 0; i < array; i++)
    {
        Console.Write($"{i + 1}: ");
        int number = int.Parse(Console.ReadLine());
        arr[i] = number;
        if (arr[i] > 0) count++;
    }
    return count;
}
int result = NowNum(count);
Console.WriteLine($"У вас {result} числа больше 0.");
