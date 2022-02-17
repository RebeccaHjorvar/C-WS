using HtmlAgilityPack;

public class Scraper 
{
    /// <summary> 
    /// Scrapes data from a specific url and node selection
    /// </summary> 
    /// <param name="url">The url that will be scraped</param>
    /// <param name="nodeSelection">The specific node selection that will be scraped</param>
    public HtmlAgilityPack.HtmlNodeCollection ScrapeData(string url, string nodeSelection)
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        HtmlDocument doc = htmlWeb.Load(url);

        var dataList = doc.DocumentNode.SelectNodes(nodeSelection);

        return dataList;
    }
}