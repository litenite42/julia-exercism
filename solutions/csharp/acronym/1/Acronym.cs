public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        return string.Join("", phrase.Split(' ', '-').Select(s => s.Where(char.IsLetter).FirstOrDefault()).Where(char.IsLetter)).ToUpper();
    }
}