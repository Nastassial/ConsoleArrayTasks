
int taskNumAll = 6, taskNum = 1;
int[] arr;

while (taskNum <= taskNumAll)
{
    Console.WriteLine($"\n\n--- Задание {taskNum} ---\n");

    switch (taskNum)
    {
        case 1:
            Console.WriteLine("Первые 11 чисел последовательности Фибоначчи:");
            ShowFibonacciNumList(11);

            break;

        case 2:
            float depositSum;
            int monthCnt;

            Console.WriteLine("Введите сумму вклада:");
            depositSum = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            monthCnt = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма вклада с процентами за {monthCnt} месяцев:");
            Console.WriteLine(GetDepositSum(depositSum, monthCnt));

            break;

        case 3:
            int arrLength;

            while (true)
            {
                Console.WriteLine("Введите размер массива(возможный размер: от 6 до 10 включительно):");

                arrLength = int.Parse(Console.ReadLine());

                if (arrLength > 5 && arrLength < 11) break;

                Console.WriteLine("Некорректное число!");
            }

            arr = GetRandomArray(arrLength, 1, 101);
            ShowArray(arr);

            Console.WriteLine("Массив из четных чисел заданного массива:");
            ShowArray(GetEvenArray(arr));

            break;

        case 4:
            Console.WriteLine("Массив рандомных чисел от 1 до 100:");
            arr = GetRandomArray(5, 1, 101);
            ShowArray(arr);

            Console.WriteLine("Массив, в котором четные элементы = 0:");
            ShowArray(GetArrayWith0(arr));

            break;

        case 5:
            string[] arrSort = new string[5] { "Маша", "Максим", "Петя", "Катя", "Аня" };

            Console.WriteLine("Неотсортированный массив имен:");
            ShowStringArray(arrSort);

            Console.WriteLine("Отсортированный массив имен:");
            Array.Sort(arrSort);
            ShowStringArray(arrSort);

            break;

        case 6:
            Console.WriteLine("Массив рандомных чисел от 1 до 100:");
            arr = GetRandomArray(15, 1, 101);
            ShowArray(arr);

            Console.WriteLine("Сортировка пузырьком:");

            BubbleSort(arr);
            ShowArray(arr);

            break;
    }

    taskNum++;
}

Console.WriteLine();


static int[] GetRandomArray(int length, int startNum, int endNum)
{
    int[] array = new int[length];
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(startNum, endNum);
    }

    return array;
}

static void ShowArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

static void ShowStringArray(string[] array)
{
    foreach (string str in array)
    {
        Console.Write(str + " ");
    }

    Console.WriteLine();
}

static void ShowFibonacciNumList(int num)
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

static float GetDepositSum(float sum, int monthCnt)
{
    for (int i = 0; i < monthCnt; i++)
    {
        sum += sum * 0.07f;
        //Console.WriteLine(depositSum + " " + (i + 1) + " месяц");
    }

    return sum;
}

static int[] GetEvenArray(int[] initArray)
{
    int counter = 0;

    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0) counter++;
    }

    int[] evenArray = new int[counter];

    for (int i = 0, j = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0)
        {
            evenArray[j] = initArray[i];
            
            j++;
        }
    }

    return evenArray;
}

static int[] GetArrayWith0(int[] initArray)
{
    int[] tmpArray = new int[initArray.Length];

    for (int i = 0; i < tmpArray.Length; i++)
    {
        if (i % 2 != 0)
            tmpArray[i] = 0;
        else
            tmpArray[i] = initArray[i];
    }

     return tmpArray;
}

static void BubbleSort(int[] initArray)
{
    int tmp;

    for (int j = 1; j < initArray.Length; j++)
    {
        for (int i = 0; i < initArray.Length - j; i++)
        {
            if (initArray[i] > initArray[i + 1])
            {
                tmp = initArray[i];
                initArray[i] = initArray[i + 1];
                initArray[i + 1] = tmp;
            }
        }
    }
}