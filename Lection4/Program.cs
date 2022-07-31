// ==== Урок 4. Рекурсия и двумерные массивы ====

// string[,] table = new string[2, 4]; // 2 строки, 4 столбца == в [] указываются индексы, т.е.
// table[0,0] table[0,1] table[0,2] table[0,3]
// table[1,0] table[1,1] table[1,2] table[1,3]

// индекс [индекс первой строки 0, индекс первого столбца 0] [индекс первой строки 0, индекс второго столбца 1] и т.д.
// индекс [индекс второй строки 1, индекс первого столбца 0] [индекс второй строки 1, индекс второго столбца 1] и т.д.

/* table[1, 2] = "слово";
for (int str = 0; str < 1; str++)
{
    for(int collums = 0; collums < 2; collums++)
    {
        Console.WriteLine($"-{table[str, collums]}-");
    }
}*/

/* int[,] matrix = new int[3, 4];
for (int str = 0; str < matrix.GetLength(0); str++) // тоже что и длинна массива str < 3
{
    for(int collums = 0; collums < matrix.GetLength(1); collums++) // тоже что и длинна массива collums < 4
    {
        Console.Write($"{matrix[str, collums]} ");
    }
Console.WriteLine();
}*/


/* void PrintArray(int[,] matr)
{
    for (int str = 0; str < matr.GetLength(0); str++) // тоже что и длинна массива str < 3
    {
        for(int collums = 0; collums < matr.GetLength(1); collums++) // тоже что и длинна массива collums < 4
        {
            Console.Write($"{matr[str, collums]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 10];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);*/


// ==== Двумерные массивы ====
// Нарисовать и раскрасить объект

/* int[,] pic = new int[,]

{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0 },
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image) // Метод, который выводит картинку
{
    for (int i = 0; i < image.GetLength(0); i++) // строки
    {
        for(int j = 0; j < image.GetLength(1); j++) // коллонки
        {
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
} 

void FillImage(int row, int col) // метод, который закрашивает картинку
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic); //вызов результата (вывод контура картинки)
FillImage(10,6); //выбираем точку откуда начнем закрашивание
PrintImage(pic); */ //вызов результата (вывод закрашенной картинки)

// Рекурсия функция, которая вызывает саму себя

// Задача: Написать метод, который будет принимать число и находить факториал этого числа

     // long - целочисленный тип данных на 64 бита, а int на 32 бита.
     // double - вещественный тип данных с плавающей запятой
/* double Factorial(int n) // метод поиска факториала
{
    if(n == 0 || n == 1) return 1; // 0! = 1 и 1! = 1 - правило факториала
    else return n * Factorial(n - 1);
}

// Console.Write("Input number: "); - запрос числа
// int num = Convert.ToInt32(Console.ReadLine()); - конвертация в значение num
// Console.WriteLine($"{num}! = {Factorial(num)}"); - вывод факториала запрошенного числа

for (int i = 0; i < 41; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */




