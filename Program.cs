// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Input numbers of array elements");
// int m = Convert.ToInt32(Console.Readlin());
// int sum = 0;
// int [] array = new int [m];
 
// void printArrayI(int m)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.WriteLine($"Input {i + 1} elements array");
//         array[i] = Convert.ToInt32(Console.Readlin());
//     }
// }
// int kol(int [] array)
// {
//     int i = 0;
//     int  sum = 0;


//     while (i < array.Length);
// }
// if(array[i] > 0)
// sum = sum + 1;
// i = i + 1;
// {
//     return sum ;
// }
 
//  printArrayI(m);
//  Console.WriteLine($" n numbers > 0 : {kol(array)}");







//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Input b1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());
e b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1");
doubl
double x = (b1 - b2)/(k2 -k1);
double y = k2 * x + b2;

Console.WriteLine($" two lines intersect X: {x}, Y: {y}");
