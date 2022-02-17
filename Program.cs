var scraper = new Scraper();
var excelGenerator = new ExcelGenerator();
string url = "https://www.nbi-handelsakademin.se/kontakt/";
string nodeSelection = "//h4[(@class='light')]";

/*
Console.WriteLine($"Would you like to create an excel file containing the employees currently listed on - {url} - ?");
Console.WriteLine(" Y / N ");

string? input = Console.ReadLine();
Console.Clear();

Quote.PlainExit();
*/
var output = excelGenerator.CreateExcel(scraper.ScrapeData(url, nodeSelection), "mycsvexcelfile");
Quote.CreatedFileExit(output);  



