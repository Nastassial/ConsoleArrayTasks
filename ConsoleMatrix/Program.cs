Console.WriteLine("Введите количество строк матрицы:");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int columnNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите через пробел элементы матрицы:");
string[] matrixElStr = Console.ReadLine().Trim().Split(" ");

int[,] matrix = CreateMatrix(rowNum, columnNum, matrixElStr);

Console.WriteLine("Матрица:");
ShowMatrix(matrix);

int positiveElCnt = 0, negativeElCnt = 0; 

// считаем кол-во положительных и отрицательных элементов матрицы
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] > 0) positiveElCnt++;
        if (matrix[i,j] < 0) negativeElCnt++;
    }
}

Console.WriteLine($"Количество положительных элементов матрицы = {positiveElCnt}\nКоличество отрицательных элементов матрицы = {negativeElCnt}");

static int[,] CreateMatrix(int row, int col, string[] elements)
{
    int[,] matrix = new int[row, col];

    // заполняем матрицу
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(elements[j + i * matrix.GetLength(1)]);
        }
    }

    return matrix;
}

static void ShowMatrix(int[,] matrix)
{
    // выводим матрицу
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
