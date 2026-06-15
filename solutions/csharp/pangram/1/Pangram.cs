public static class Pangram
{
    public static bool IsPangram(string input) => input.Where(char.IsLetter).Select(s => char.ToLower(s)).Distinct().Count() == 26;
}
