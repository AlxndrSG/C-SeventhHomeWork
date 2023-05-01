//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();

int rows = Prompt("Введите количество строк массива: ", "Ошибка! Введены некорректные данные!");
int columns = Prompt("Введите количество столбцов массива: ", "Ошибка! Введены некорректные данные!");

double[,] array = GetArray(rows, columns);

PrintArray(array);

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

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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
