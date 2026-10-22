int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

// Bubble sort: swap neighbouring values that are in the wrong order.
for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temporary = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temporary;
        }
    }
}
// addd suibian

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
