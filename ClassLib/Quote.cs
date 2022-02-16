public static class Quote
{
    public static void PlainExit()
    {
        Console.WriteLine();
        Console.WriteLine("Okey, press any key to exit console.");
        Console.ReadKey();
    }
    public static void CreatedFileExit(string output)
    {
        Console.WriteLine();
        Console.WriteLine(output);
        Console.WriteLine();
        Console.WriteLine("Press any key to exit console.");
        Console.ReadKey();
    }

}