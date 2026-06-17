public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string logMessage, string delim) {
        return logMessage.Split(delim).Last();
    }
    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string logMessage, params string[] delims) {
        int index = logMessage.IndexOf(delims[0])+delims[0].Length;
        int lastIndex = logMessage.IndexOf(delims[1]);
        Console.WriteLine($"ndx: {index} lNdx: {lastIndex}");
        
        return logMessage.Substring(index, lastIndex-index).Trim();
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logMessage) {
        return logMessage.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string logMessage) {
            return logMessage.SubstringBetween("[", "]");
        }
}