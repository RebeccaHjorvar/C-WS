public class StringHandler
{
    /// <summary>
    /// Takes a full name and converts it to a firstname and the first letter of the last name.
    /// </summary>
    /// <param name="name">The name that should be handled</param>
    public string NameSubstrings(HtmlAgilityPack.HtmlNode name)
    {
            var firstName = name.InnerText.Split(' ').First();
            var lastNameLetter = name.InnerText.Split(' ').Last().Substring(0,1);
            var simplifiedName = $"{firstName} {lastNameLetter}.";

            return simplifiedName;
    }
            
}