using ConsoleStyler;

// Styles the console
Styler.Colors("Magenta", "White");
Styler.Header("Web Scraper");
Styler.Title("Web Scraper");

var scraper = new Scraper();
var excelGenerator = new ExcelGenerator();

string url = "https://www.nbi-handelsakademin.se/kontakt/";
string nodeSelection = "//h4[(@class='light')]";

// Asks user if they want to create an excel csv
Quote.WelcomeText(url);

string? input = Console.ReadLine();

Console.Clear();

if (input.ToLower() != "y")
{
    Quote.PlainExit();
}

// Scrapes data and generates an excel file
var output = excelGenerator.CreateExcel(scraper.ScrapeData(url, nodeSelection), "mycsvexcelfile");
Quote.CreatedFileExit(output);  



