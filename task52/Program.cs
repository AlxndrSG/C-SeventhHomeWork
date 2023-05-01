// Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

Console.Clear();

int rows = Prompt("Введите количество строк массива: ", "Ошибка! Введены некорректные данные!");
int columns = Prompt("Введите количество столбцов массива: ", "Ошибка! Введены некорректные данные!");

int[,] array = GetArray(rows, columns);

PrintArray(array);

ColumnsSum(array);

void ColumnsSum(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = (sum + array[i, j]);
        }
        sum = Math.Round(sum / rows, 1);
        Console.Write(sum + "; ");
    }
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Prompt(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

