using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder bldr = new StringBuilder();

        bool isKebab = false;
        
        foreach (char c in identifier) {
            if (c == ' ') {
                bldr.Append('_');
            }
            else if (char.IsControl(c)) {
                bldr.Append("CTRL");
            }
            else if (c == '-') {
                isKebab = true;
            }
            else if (isKebab) {
                bldr.Append(char.ToUpper(c));
                isKebab = false;
            }
            else if (!char.IsLetter(c) || c >= 'α' && c <= 'ω') {
                continue;
            }
            else {
                bldr.Append(c);
            }
        }

        return bldr.ToString();
    }
}
