int[] numbers = new int [4];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
SumStandingElementsOddPositions(numbers);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
}

void OutputArrayString(int[] arrayString)
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

void SumStandingElementsOddPositions(int[] number)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 != 0)
        {
            sum += number[i];
        }
    }
    Console.WriteLine($" -> сумма чисел стоящих на нечётных позициях " +
                      $"в массиве равна: {sum}");
}