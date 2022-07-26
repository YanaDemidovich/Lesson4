﻿// ==== Урок 4. Рекурсия и двумерные массивы ====

string[,] table = new string[2, 4]; // 2 строки, 4 столбца == в [] указываются индексы, т.е.
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
