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
    Console.Write("Result array:");
    PrintArray(arr);
}

void Extra03()
{
    int size = 1000000;
    int[] array = new int[size];
    for (int i = 1; i < size; i++) array[i] = i;
    int count = 0;
    
    for (int i = 0; i < size; i++)
    {
        int[] tempArr = numToArray(array[i]);
        int tempSum = tempArr.Sum();
        int tempMult = multipleArr(tempArr);
        if (tempMult == tempSum * 3) count++;
    }
    Console.WriteLine($"Count of searching numbers = {count}");    
}

void Extra04()
{
    int size = 5;
    int[][] arr = new int[size][];
    fillArrArr(arr, 1, 20);
    PrintArrArr(arr);
    int maxSum = 0;
    int maxIndex = 0;

    for (int i = 0; i < size; i++)
    {
        if (arr[i].Sum() > maxSum)
        {
            maxSum = arr[i].Sum();
            maxIndex = i;
        }
    }
    Console.Write($"Array with max sum = {maxSum}:");
    PrintArray(arr[maxIndex]);
}

int multipleArr(int[] arr)
{
    int size = arr.Length;
    int mult = 1;
    for (int i = 0; i < size; i++)
    {
        mult *= arr[i];
    }
    return mult;
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
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++; 
    }
    return count;
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
void fillArrArr(int[][] collection, int start, int end)
{
    int size = collection.Length;
    Random rand = new Random();
    int sizeArr = rand.Next(1, 6);

    for (int i = 0 ; i < size; i++)
    {
        collection[i] = new int[sizeArr];
        fillArray(collection[i], 1, 21);
    }
}
void PrintArrArr(int[][] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        PrintArray(array[i]);
    }
    Console.WriteLine();
}

// Extra01();
// Extra02();
// Extra03();
Extra04();