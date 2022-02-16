using CsvHelper;
using HtmlAgilityPack;
using System.Globalization;

public class WebScraper 
{
    public string Scraper(string url, string nodeSelection)
    {

        HtmlWeb htmlWeb = new HtmlWeb();
        HtmlDocument doc = htmlWeb.Load(url);

        var HakEmployees = doc.DocumentNode.SelectNodes(nodeSelection);
        var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var excel = new List<Row>();
        var output = "An exel sheet containing the current employees of HAK has now been added to your documents folder";
        
        foreach (var employee in HakEmployees)
        {
            var firstName = employee.InnerText.Split(' ').First();
            var lastNameLetter = employee.InnerText.Split(' ').Last().Substring(0,1);
            var name = $"{firstName} {lastNameLetter}.";

            excel.Add(
                new Row 
                {
                    Name = name
                }
            );
        }

        using (var writer = new StreamWriter(filePath+"\\HakEmployees.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(excel);
        }

        return output;
    }
}
