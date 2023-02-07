/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

System.Console.WriteLine("Enter the number of columns");
int ColumnsVol = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of rows");
int LinesVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[ColumnsVol, LinesVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Here is your array ");
PrintArray(numbers);
void FillArrayRandomNumbers(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}