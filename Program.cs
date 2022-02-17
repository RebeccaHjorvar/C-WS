using ConsoleStyler;

// Styles the console
Styler.Colors("Magenta", "White");
Styler.Header("Web Scraper");
Styler.Title("Web Scraper");

var scraper = new Scraper();
var excelGenerator = new ExcelGenerator();

string url = "https://www.nbi-handelsakademin.se/kontakt/";
string nodeSelection = "//h4[(@class='light')]";

Console.WriteLine("Would you like to create an excel file containing the employees currently listed on: ");
Console.WriteLine();
Console.WriteLine($"- {url} - ");
Console.WriteLine();
Console.WriteLine(" Y / N ");
Console.WriteLine();

string? input = Console.ReadLine();

Console.Clear();

if (input.ToLower() != "y")
{
    Quote.PlainExit();
}

var output = excelGenerator.CreateExcel(scraper.ScrapeData(url, nodeSelection), "mycsvexcelfile");
Quote.CreatedFileExit(output);  



