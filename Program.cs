// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hellooo, World!!!");
Console.WriteLine("21");

int[] numbers = {1, 2, 3, 4, 5};
Console.WriteLine("Average: " + CalculataAverage(numbers));

static double CalculataAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Tablica nie może być pusta.");

    double sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }

    return sum / numbers.Length;
}