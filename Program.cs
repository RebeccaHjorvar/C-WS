var scraper = new WebScraper();
var url = "https://www.nbi-handelsakademin.se/kontakt/";
var nodeSelection = "//h4[(@class='light')]";
var output = scraper.Scraper(url, nodeSelection);

Console.WriteLine(output);