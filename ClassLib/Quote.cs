public static class Quote
{
    /// <summary>
    /// Displays the url that will be scraped and generates a welcome text 
    ///that asks for a "Y / N" answer from the user.
    /// </summary>
    public static void WelcomeText(string url)
    {
        Console.WriteLine("Would you like to create an excel file containing the employees currently listed on: ");
        Console.WriteLine();
        Console.WriteLine($"- {url} - ");
        Console.WriteLine();
        Console.WriteLine(" Y / N ");
        Console.WriteLine();
    }
    /// <summary>
    /// Lets user exit console
    /// <summary>
    public static void PlainExit()
    {
        Console.WriteLine();
        Console.WriteLine("Okey, press any key to exit console.");
        Console.ReadKey();
    }
    /// <summary>
    /// Displays custom output and lets user exit console
    /// <summary>
    public static void CreatedFileExit(string output)
    {
        Console.WriteLine();
        Console.WriteLine(output);
        Console.WriteLine();
        Console.WriteLine("Press any key to exit console.");
        Console.ReadKey();
    }

}