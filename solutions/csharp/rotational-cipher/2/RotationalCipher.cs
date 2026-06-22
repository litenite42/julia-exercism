public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var bits = text.Select(c => Char.IsLetter(c) ? (char)((c - (char.IsUpper(c) ? 'A' : 'a') + shiftKey) % 26 + (char.IsUpper(c) ? 'A' : 'a')) : c).ToArray();

        return new string(bits);
    }
}