/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int[,] array = GetArray(4,4,0,5);
PrintArray(array);
Console.WriteLine();


void Result (int [,] inArray)
{   int sum = 0;
    int count = 0;
    int minSum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum = minSum + inArray[0,j];
    }

    for (int i = 0; i < inArray.GetLength(0); i++)
        
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    sum = sum + inArray[i,j];  
                }
                
                if (minSum > sum) 
                {
                    minSum = sum;  
                    count=i;
                }
                
                sum=0;
        }
        Console.WriteLine($"номер строки с наименьшей суммой элементов: {count+1}");

}
Console.WriteLine();
Result(array);