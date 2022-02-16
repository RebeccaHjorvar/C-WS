public class StringHandler
{
    public string NameSubstrings(HtmlAgilityPack.HtmlNode name)
    {
            var firstName = name.InnerText.Split(' ').First();
            var lastNameLetter = name.InnerText.Split(' ').Last().Substring(0,1);
            var simplifiedName = $"{firstName} {lastNameLetter}.";

            return simplifiedName;
    }
            
}