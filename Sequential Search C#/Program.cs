Search();

static void Search()
{
    Random random = new Random();
    int[] array = Enumerable.Repeat(0, 10).Select(i => random.Next(0, 20)).ToArray();
    int searchElement = random.Next(0, 30);

    Console.WriteLine($"Initial Array:{string.Join(", ", array)}");
    Console.WriteLine($"Element to be searched in the array: {searchElement}");

    bool found = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchElement) { found = true; break; }
    }

    Console.WriteLine($"Element was {(found ? "found" : "not found")} in the array.");
    Console.ReadKey();
}