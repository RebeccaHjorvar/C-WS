using HtmlAgilityPack;

public class Scraper 
{
    public HtmlAgilityPack.HtmlNodeCollection ScrapeData(string url, string nodeSelection)
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        HtmlDocument doc = htmlWeb.Load(url);

        var dataList = doc.DocumentNode.SelectNodes(nodeSelection);

        return dataList;
    }
}