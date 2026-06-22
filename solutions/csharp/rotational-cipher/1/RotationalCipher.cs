public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        List<string> bits = text.Split(' ').ToList();

        return string.Join(' ', bits.Select(s => string.Join("", s.ToCharArray().ToList().Select(c => new { value = c, offset = char.IsUpper(c) ? 'A' : 'a'}).Select(c => char.IsLetter(c.value) ? (c.value - c.offset + shiftKey) % 26 + c.offset : c.value).Select(c => (char)c ))));
    }
}