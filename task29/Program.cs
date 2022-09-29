//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int lenArray = ReadInt("введите массив мз N элементов : ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(-10,10);
    Console.Write(randomArray[i] + ", ");
}
int ReadInt(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}
