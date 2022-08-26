double[] numbers = new double [10];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
DifferenceМinМax(numbers);

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100);
    }
}

void DifferenceМinМax(double[] number)
{
    double min = number[0];
    double max = number[0];
    for (int i = 0; i < n; i++)
    {
        if (number[i] > max)
        {
            max = number[i];
        }
        if (number[i] < min)
        {
            min = number[i];
        }
    }
    double diff = max - min;
    Console.WriteLine($" -> разница между максимальным элементом {max} " +
                      $"и минимальным элементом {min} массива равна: {diff}");
}

void OutputArrayString(double[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"Массив: {stringArray}");
}