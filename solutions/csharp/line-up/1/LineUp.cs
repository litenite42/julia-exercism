public static class LineUp
{
    public static string Format(string name, int number)
{
    string ordinalEnding;

    if (number % 100 is 11 or 12 or 13)
        ordinalEnding = "th";
    else
        ordinalEnding = (number % 10) switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
        };

    return $"{name}, you are the {number}{ordinalEnding} customer we serve today. Thank you!";
}

}
