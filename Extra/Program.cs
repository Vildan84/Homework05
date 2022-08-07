void Extra01()
{
    int size = 15;
    int[] arr = new int[size];
    fillArray(arr, 0, 9);
    PrintArray(arr);
    int number = randNumber(100, 1000);
    Console.WriteLine(number);
    int first = number / 100;
    int second = (number % 100) / 10;
    int third = number % 10;
    int j = 1;
    int k = 2;
    
    for (int i = 0; i < size - 2; i++)
    {
        if (arr[i] == first && arr[j] == second && arr[k] == third)
        {
            Console.WriteLine($"Number {number} in array");
        }
        j++; k++;
    }
}

void Extra02()
{
    int firstNumber = randNumber(10, 2000);
    int secondNumber = randNumber(10, 2000);
    int[] firstArr = numToArray(firstNumber);
    int[] secondArr = numToArray(secondNumber);
    int count1 = numberLength(firstNumber);
    int count2 = numberLength(secondNumber);
    int size = count1 * count2;
    int[] arr = new int[size];
    int k = 0;

    for (int i = 0; i < count1; i++)
    {
        for (int j = 0; j < count2; j++)
        {
            arr[k] = firstArr[i] * secondArr[j];
            k++;
        }
    }
    Console.WriteLine($"First number = {firstNumber}");
    Console.WriteLine($"Second number = {secondNumber}");
    Console.Write("Resalt array:");
    PrintArray(arr);
}


int[] numToArray(int number)
{
    int count = numberLength(number);
    int[] arr = new int[count];
    for (int i = count-1; i >= 0; i--)
    {
        arr[i] = number % 10;
        number /= 10;
    }
    return arr;
}
int randNumber(int start, int end)
{
    Random rand = new Random();
    int number = rand.Next(start, end);
    return number;
}
int numberLength(int number)
{
    double log = Math.Log10(number);
    double count = Math.Floor(log) + 1;
    return Convert.ToInt32(count);
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
    Console.Write("\b\b]");
    Console.WriteLine();
}

// Extra01();
// Extra02();
