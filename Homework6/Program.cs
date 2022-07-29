// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}
int PositivNumbers(int[] array) // метод поиска числет больше 0
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) a++; // определяем число больше 0 и считаем его
    }
    return a;
}
void Print(int[] array) // метод, который выводит массив
{
    for(int i = 0; i < array.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(5, -50, 50); // указываем параметры массива: кол-во чисел, от min, до max
Print(myArray); // выводим рандомные числа массива
Console.WriteLine("Кол-во чисел больше 0 = " + PositivNumbers(myArray)); // выводим кол-во


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
