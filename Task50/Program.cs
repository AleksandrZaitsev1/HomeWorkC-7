System.Console.WriteLine("Enter the number of rows");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of columns");
int b = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (a > numbers.GetLength(0) || b > numbers.GetLength (1))
{
    System.Console.WriteLine("There is no such element");
} 
else 
{
    System.Console.WriteLine($" the value of the {n} row and {m} column element is {numbers[n-1,m-1]}");

}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}