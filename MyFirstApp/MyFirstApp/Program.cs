// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("New change");
Console.WriteLine("New change2");
Console.WriteLine("New change3");
static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double) sum / numbers.Length;
}

// int[] numbers = { 1, 2, 3, 4 };
// double average = GetAverage(numbers);