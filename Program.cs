class Program
{
    public static string[] findShortStrings(string[] input)
    {
        int size = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                size++;
            }
        }
        string[] result = new string[size];
        int curr = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[curr] = input[i];
                curr++;
            }
        }
        return result;
    }
	
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()); // количество исходных слов
        string[] input = new string[n];
        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }
        string[] result = findShortStrings(input);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}