void task1()
{
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
//[345, 897, 568, 234] -> 2


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
void LookArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}
int[] array1 = LenArray(10, 50, 99);
LookArray(array1);
void FillArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine(count);
}
FillArray(array1);}

void task2(){

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0




}
void task3(){

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




}
Console.WriteLine("Введите номер задачи от 1 до 3");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task1();
if (Num == 2) task2();
if (Num == 3) task3();
if (Num != 1 && Num != 2 && Num != 3) Console.WriteLine("Неверное значение. Введите только цифру 1, 2 или 3.");
