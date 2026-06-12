public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrEmpty(statement) || string.IsNullOrWhiteSpace(statement)) {
            return "Fine. Be that way!";
        }
        
        string response;
        bool hasQuestion = statement.Trim().EndsWith('?');
        bool hasLetters = statement.Any(char.IsLetter);
        bool isYelling = hasLetters && statement.Where(char.IsLetter).All(char.IsUpper);

        if (hasQuestion && isYelling) {
            response = "Calm down, I know what I'm doing!";
        }
        else if (isYelling) {
            response = "Whoa, chill out!";
        }
        else if (hasQuestion) {
            response = "Sure.";
        }
        else {
            response = "Whatever.";
        }

        return response;
    }
}