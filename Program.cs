// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hellooo, World!!!");
Console.WriteLine("21");

int[] numbers = {1, 2, 3, 4, 5};
Console.WriteLine("Average: " + CalculataAverage(numbers));
Console.WriteLine("Max: " + FindMaxValue(numbers));

static double CalculataAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Tablica nie może być pusta.");

    double suma = 0;
    foreach (int num in numbers)
    {
        suma += num;
    }

    return suma / numbers.Length;
}


static double FindMaxValue(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty");

    return numbers.Max();
}