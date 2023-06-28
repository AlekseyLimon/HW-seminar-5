// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] ArrayRand(int size)
// {
//     int[] array = new int[size];
//         for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(99, 999);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int kol(int[] randomArray)
// {
// int kol = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
//     if (randomArray[i] % 2 == 0)
//         kol = kol + 1;
// }
// return kol;
// }

// int len = InputNum("Введите длину массива: ");
// int[] arr = ArrayRand(len);
// PrintArray(arr);
// int quantity = kol(arr);
// Console.WriteLine($"Количество четных элементов {quantity}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] ArrayRand(int size)
// {
//     int[] array = new int[size];
//         for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-999, 999);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int amount(int[] randomArray)
// {
// int sum = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
//     if (i %2 != 0)
//         sum = sum + randomArray[i];
// }
// return sum;
// }

// int len = InputNum("Введите длину массива: ");
// int[] arr = ArrayRand(len);
// PrintArray(arr);
// int sum = amount(arr);
// Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] ArrayRand(int size)
{
    double [] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(-1000, 1000)*0.01, 2);
        
    }
    return array;
}
// double[] ArrayRand(int size)
// {
//     double[] array = new double[size];
//     Random rand = new Random();
//         for (int i = 0; i < size; i++)
//     {
//             array[i] = rand.NextDouble() * 100;
//     }
//     return array;
// }

void PrintArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]:f2}   ");
    }
    Console.WriteLine();
}

double max(double[] randomArray)
{
    int index_max = 0;
    double max = randomArray[index_max];
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] > randomArray[index_max])
        max = randomArray[i];
}
return max;
}

double min(double[] randomArray)
{
    int index_min = 0;
    double min = randomArray[index_min];
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] < randomArray[index_min])
        min = randomArray[i];
}
return min;
}

int len = InputNum("Введите длину массива: ");
double[] arr = ArrayRand(len);
PrintArray(arr);
double maximum = max(arr);
double minimum = min(arr);
Console.WriteLine($"Разница между максимальным и минимальным значением равна {(maximum - minimum):f2}");