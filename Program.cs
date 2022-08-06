void Task34() //Задача 34
{
    int size = 10;
    int[] arr = new int[size];
    fillArray(arr, 100, 1000);
    PrintArray(arr);
    evenNumbers(arr);  
}

void Task36() //Задача 36
{
    int size = 10;
    int[] arr = new int[size];
    fillArray(arr, 0, 100);
    PrintArray(arr);
    sumOfNegIndex(arr);
}

void Task38() //Задача 38
{
    int size = 10;
    double[] arr = new double[size];
    fillArrRealNum(arr, -20, 20);
    PrintArrayDouble(arr);
    doubleArrSort(arr);
    Console.WriteLine($"Max minus min in array = {Math.Round(arr[size-1] - arr[0], 2)}");
}

void doubleArrSort(double[] arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPos])
            {
                minPos = j;
            } 
        }
        double temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp; 
    }
    PrintArrayDouble(arr);
}

void sumOfNegIndex(int[] arr)
{
    int size = arr.Length;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    Console.WriteLine($"Sum of negative index = {sum}");
}

void evenNumbers(int[] arr)
{
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine($"{count} even nembers in array");
}

void fillArray(int[] collection, int start, int end)
{
    int size = collection.Length;
    Random rand = new Random(); 
    for (int i = 0 ; i < size; i++)
    {
        collection[i] = rand.Next(start, end);
    }
}

void fillArrRealNum(double[] collection, int start, int end)
{
    int size = collection.Length;
    Random rand = new Random(); 
    for (int i = 0 ; i < size; i++)
    {
        collection[i] = rand.Next(start, end) + rand.NextDouble() * 100;
    }
}

void PrintArrayDouble(double[] col)

{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{Math.Round(col[position], 2)}, ");
        position++;
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("\b]");
    Console.WriteLine();
}

//Task34();
//Task36();
Task38();