/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// метод инициализации массива
int[] InitArray(int length)
{
   int[] array = new int[length]; // объявляем новый массив
   Random rnd = new Random();
   for (int i = 0; i < length; i++) // заполняем массив рандомными числами 
   {
      array[i] = rnd.Next(100, 1000);
   }
   return array; // возвращаем массив
}

// метод печати массива на экран
void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

int Count(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
         count++;
   }
   return count;
}

int[] arr = InitArray(10);
PrintArray(arr);
Console.WriteLine($"Количество четных элементов в массиве = {Count(arr)}");
