using System;
using static System.Console;
WriteLine("Введите размер массива!");
int size = int.Parse(ReadLine());
string [] arrayA = new string [size];
WriteLine("Введите данные через пробел");
arrayA = (ReadLine()).Split(' ',StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Ваши данные:{String.Join(" ",arrayA)}");
WriteLine($"Данные после выполнения Алгоритма:{String.Join(" ",GetArrayDoCondition(arrayA))}");

string [] GetArrayDoCondition(string [] arr )
{
string [] result = new string [arr.Length];
for (int i = 0; i < arr.Length; i++)
{
 if (arr[i].Length<=3)
 {
    result[i] = Convert.ToString(arr[i]);
 }
}
return result;
}