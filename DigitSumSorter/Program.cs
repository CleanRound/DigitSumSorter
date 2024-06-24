class Program
{
    static void Main()
    {
        int[] array = { 121, 75, 81 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", array));

        var sortedArrayDescending = array
            .OrderByDescending(num => num.ToString().Sum(c => c - '0'))
            .ToArray();

        Console.WriteLine("Sorted array in descending order by sum of digits:");
        Console.WriteLine(string.Join(", ", sortedArrayDescending));

        var sortedArrayAscending = array
            .OrderBy(num => num.ToString().Sum(c => c - '0'))
            .ToArray();

        Console.WriteLine("Sorted array in ascending order by sum of digits:");
        Console.WriteLine(string.Join(", ", sortedArrayAscending));
    }
}
