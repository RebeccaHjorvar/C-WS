using System.Globalization;
using CsvHelper;

public class CsvRow 
{
    public string? Item { get; set; }
}

public class ExcelGenerator
{
    public string CreateExcel(HtmlAgilityPack.HtmlNodeCollection dataList, string documentName)
    {   var stringHandler = new StringHandler();
        var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var excel = new List<CsvRow>();
        var output = "An exel sheet containing your selected data has now been added to your documents folder";
        
        foreach (var item in dataList)
        {
            var name = stringHandler.NameSubstrings(item);

            excel.Add(
                new CsvRow 
                {
                    Item = name
                }
            );
        }

        using (var writer = new StreamWriter(filePath+ $"\\{documentName}.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(excel);
        }

        return output;
    }


    //TODO create method for first- and lastname items that returns Firstname L.

}


