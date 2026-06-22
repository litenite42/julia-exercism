static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result = string.Empty;

        if (id.HasValue) {
            result += $"[{id.Value}] - ";
        }

        string dept = department ?? "Owner";
        
        return $"{result}{name} - {dept.ToUpper()}";
    }
}
