// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int[] array = new int[] {1, 3, 4, 5, 6, 7, 8, 9};
// Console.WriteLine("Массив");
// Console.WriteLine(string.Join (", " , array));

void f()
{
var rnd = new Random();
var array = new int[8];
for(int i = 0;i < array.Length;i++)
{
    array[i] = rnd.Next(0,10);
    Console.Write(array[i] + " ");
}
}
f();