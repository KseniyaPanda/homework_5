/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// метод инициализации массива
int[] InitArray(int length)
{
   int[] array = new int[length]; // объявляем новый массив
   Random rnd = new Random();
   for (int i = 0; i < length; i++) // заполняем массив рандомными числами
   {
      array[i] = rnd.Next(-100, 101); //-100, 101
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

int Summ(int[] array)
{
   int summ = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 != 0)
         summ += array[i];
   }
   return summ;
}

int[] arr = InitArray(10);
PrintArray(arr);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {Summ(arr)}");
