﻿// === Задача 1: Переводим десятеричное число в двоичное

/* string ChangeNumber(int number)
{
    string result = string.Empty;    
    while(number >= 1)
    {
    // пусто = новый остаток "number % 2" приклеили к предыдущему остатку "result" - и так по кругу
        result = number % 2 + result;
        number /= 2; // аналогично number = number / 2;
    }
    return result;
}

Console.WriteLine(ChangeNumber(10)); */

// === Задача 2: Напишите программу, которая перевернет одномерный массив
// последний будет на первом, а первый на последнем
// выносит ошибку int, не понимаю в чем проблема((

/* int CreateRandomArr(int size, int min, int max) // метод, который преобразует и выводит рандомный массив на экран
{
    int[] arr = new int[size];  
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max +1);
    }
    return arr;
}

void ShowArr (int[] arr) // это для чего???
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] ReversArr (int[] arr) // метод, который переворачивает массив
{
    int j = arr.Length - 1;
    int temp = 0;
    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[1];
        arr[i] = arr[j];
        arr [j] = temp;
        j--;
    }
    return arr;
}

int[] myArray = CreateRandomArr(5, 1, 10);
ShowArr(myArray);
ShowArr(ReversArr(myArray)); */


// === Задача 3: Напишите программу, которая принимает 3 числа и проверяет может ли существовать 
// треугольник с такими длинами сторон.
// Правило: каждая из сторон должны быть строго меньше суммы 2-х других, а именно: a < b + c

/* bool Checking (int dot1, int dot2, int dot3) // метод проверки сторон правилу a < b + c
{
    if (dot1 < dot2 + dot3 && dot2 < dot1 + dot3 && dot3 < dot1 + dot2)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Длина первой стороны ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Длина второй стороны ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Длина третьей стороны ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Checking(num1, num2, num3)); */

// === Задача 4: Без применения рекурсии, написать метод, который выведет "n" чисел Фибоначчи
// необходимо запрашивать и первые 2 числа Фибоначчи.
// 3 3 6 9 15 24 39, n = 24 + 39 и т.д.

/* int[] Fibonachi (int numForm1, int numForm2, int dlina) // метод вычисления формулы Фиббоначи
{
    int[] array = new int[dlina];
    array[0] = numForm1;
    array[1] = numForm2;
    for (int i = 2; i < dlina; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

void ShowArr (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите первое число начала Фиббоначи ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число начала Фиббоначи ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину Фиббоначи ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Fibonachi(num1, num2, num3)); */
// на выходе выдает ответ "System.Int32[]" - не знаю в чем проблема. Хотя на семинаре у студента всё работало