/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0);i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(3,4,0,10);
PrintArray(array);
Console.WriteLine();

void Result (int [,] Arr)
{
    for(int i=0; i<Arr.GetLength(0);i++)
    {
        for(int j=0; j<Arr.GetLength(1); j++)
        {
             for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
}
    
Result(array);
PrintArray(array);
