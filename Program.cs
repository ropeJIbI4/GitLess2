using System;
using static System.Console;
WriteLine("Введите размер массива!");
int size = int.Parse(ReadLine());
string [] arrayA = new string [size];
WriteLine("Введите данные через пробел");
arrayA = (ReadLine()).Split(' ',StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Ваши данные:{String.Join(" ",arrayA)}");
