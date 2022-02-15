using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

Console.WriteLine("Hello, World!");

HtmlWeb htmlWeb = new HtmlWeb();
HtmlDocument doc = htmlWeb.Load("https://www.nbi-handelsakademin.se/kontakt/");

var HakEmployees = doc.DocumentNode.SelectNodes("//h4[(@class='light')]");
string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var names = new List<Row>();

foreach (var employee in HakEmployees)
{
    var firstName = employee.InnerText.Split(' ').First();
    var lastNameLetter = employee.InnerText.Split(' ').Last().Substring(0,1);
    var name = $"{firstName} {lastNameLetter}.";

    names.Add(new Row {
        Name = name
        });
}

using (var writer = new StreamWriter(filePath+"\\HakEmployees.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(names);
}