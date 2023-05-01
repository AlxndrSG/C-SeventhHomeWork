// Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или 
//же указание, что такого элемента нет.

Console.Clear();

int rows = Prompt("Введите количество строк массива: ", "Ошибка! Введены некорректные данные!");
int columns = Prompt("Введите количество столбцов массива: ", "Ошибка! Введены некорректные данные!");

int[,] array = GetArray(rows, columns);

PrintArray(array);

int rowUser = Prompt("Введите строку элемента: ", "Ошибка! Введены некорректные данные!");
int columnUser = Prompt("Введите столбец элемента: ", "Ошибка! Введены некорректные данные!");

bool element = FindElement(rowUser, columnUser);
if (element)
    Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"Элемент массива: {array[rowUser - 1, columnUser - 1]}");

bool FindElement(int rowUser, int columnUser)
{
    if (rowUser > array.GetLength(0) || columnUser > array.GetLength(1))
        return true;
    else
        return false;
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