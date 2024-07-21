// See https://aka.ms/new-console-template for more information
using ReverseNums;

Console.WriteLine("Hello, World!");

int[] arr = { 1, 2, 3, 4};
int m = 1;

Console.WriteLine("arr original");
Rotate.PrintArray(arr);

Rotate.Right(arr, m);

Console.WriteLine($"arr rotado a la derecha {m} veses");
Rotate.PrintArray(arr);