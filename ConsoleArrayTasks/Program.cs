Console.WriteLine("--- Задание 1 ---\n");
Console.WriteLine("Первые 11 членов последовательности Фибоначчи:");
FibonacciNum(11);

Console.WriteLine("\n\n\n--- Задание 2 ---\n");
GetDepositSum();

Console.WriteLine("\n\n--- Задание 3 ---\n");
GetEvenArray();

Console.WriteLine("\n\n--- Задание 4 ---\n");
GetArrayWith0();

Console.WriteLine("\n\n--- Задание 5 ---\n");
GetSortNameList();

Console.WriteLine();


static void FibonacciNum(int num)
{
    int res = 0, sum = 1, tmp;

    for (int i = 0; i < num; i++)
    {
        Console.Write(res + " ");
        tmp = res;
        res = sum;
        sum += tmp;
    }
}

static void GetDepositSum()
{
    float depositSum;
    int monthCnt;

    Console.WriteLine("Введите сумму вклада и количество месяцев:");
    depositSum = float.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество месяцев:");
    monthCnt = int.Parse(Console.ReadLine());

    for (int i = 0; i < monthCnt; i++)
    {
        depositSum += depositSum * 7 / 100;
        //Console.WriteLine(depositSum + " " + (i + 1) + " месяц");
    }

    Console.WriteLine(depositSum);
}

static void GetEvenArray()
{
    int arrLength, counter = 0;

    while (true)
    {
        Console.WriteLine("Введите размер массива(возможный размер: от 6 до 10 включительно):");

        arrLength = int.Parse(Console.ReadLine());

        if (arrLength > 5 && arrLength < 11) break;
            
        Console.WriteLine("Некорректное число!");
    }

    int[] arrRandom = new int[arrLength];
    Random rand = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        arrRandom[i] = rand.Next(1, 101);

        Console.Write(arrRandom[i] + " ");

        if (arrRandom[i] % 2 == 0) counter++;
    }

    Console.WriteLine();

    int[] arrEven = new int[counter];

    for (int i = 0, j = 0; i < arrLength; i++)
    {
        if (arrRandom[i] % 2 == 0)
        {
            arrEven[j] = arrRandom[i];

            Console.Write(arrEven[j] + " ");
            
            j++;
        }
    }

    Console.WriteLine();
}

static void GetArrayWith0()
{
    int[] arrRandom = new int[5];
    Random rand = new Random();

    Console.WriteLine("Массив рандомных чисел от 1 до 100:");

    for (int i = 0; i < arrRandom.Length; i++)
    {
        arrRandom[i] = rand.Next(1, 101);

        Console.Write(arrRandom[i] + " ");
    }

    Console.WriteLine("\nМассив рандомных чисел от 1 до 100 с измененым на 0 значением элементов с нечетными индексами:");

    for (int i = 0; i < arrRandom.Length; i++)
    {
        if (i % 2 != 0) 
            arrRandom[i] = 0;

        Console.Write(arrRandom[i] + " ");
    }

    Console.WriteLine();
}

static void GetSortNameList()
{
    string[] arrSort = new string[5] { "Маша", "Максим", "Петя", "Катя", "Аня"};

    Console.WriteLine("Неотсортированный массив имен:");

    foreach (string s in arrSort)
    {
        Console.Write(s + " ");
    }

    Console.WriteLine("\nОтсортированный массив имен:");

    Array.Sort(arrSort);

    foreach (string s in arrSort)
    {
        Console.Write(s + " ");
    }
}