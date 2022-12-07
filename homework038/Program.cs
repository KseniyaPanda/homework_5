/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// метод инициализации массива
int[] InitArray(int length)
{
   int[] array = new int[length]; // объявляем новый массив
   Random rnd = new Random();
   for (int i = 0; i < length; i++) // заполняем массив рандомными числами
   {
      array[i] = rnd.Next(-100, 101);
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

(int, int) MinAndMax(int[] array)
{
   int min = 101; // больше самого максимального если rnd.Next(-100, 101)
   int max = -101; // меньше самого минимального если rnd.Next(-100, 101) 

   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < min)
      {
         min = array[i];
      }
      else if (array[i] > max)
      {
         max = array[i];
      }
   }
   return (min, max);
}

int[] arr = InitArray(10);
PrintArray(arr);
(int min, int max) = MinAndMax(arr);
Console.WriteLine($"Min = {min}. Max = {max}");
int diff = max - min;
Console.WriteLine($"Разница между Min и Max = {diff}");
