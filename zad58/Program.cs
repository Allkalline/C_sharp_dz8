/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */ 

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

int[,] array = GetArray(3,3,0,5);
int[,] array2 = GetArray(3,3,0,5);
int[,] arrayRes = new int [3,3];
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

void Result(int[,] Arr1, int[,] Arr2, int[,] resArr)
{
  for (int i = 0; i < resArr.GetLength(0); i++)
  {
    for (int j = 0; j < resArr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Arr1.GetLength(1); k++)
      {
        sum += Arr1[i,k] * Arr2[k,j];
      }
      resArr[i,j] = sum;
    }
  }
}

Result (array,array2,arrayRes);
PrintArray(arrayRes);