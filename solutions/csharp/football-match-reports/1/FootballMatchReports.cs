public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        string result;

        switch (shirtNum) {
            case 1:
                result = "goalie";
                break;
            case 2:
                result = "left back";
                break;
            case 3:
            case 4:
                result = "center back";
                break;
            case 5:
                result = "right back";
                break;
            case 6:
            case 7:
            case 8:
                result = "midfielder";
                break;
            case 9:
                result = "left wing";
                break;
            case 10:
                result = "striker";
                break;
            case 11:
                result = "right wing";
                break;
            default:
                result = "UNKNOWN";
                break;
        }

        return result;
    }

    public static string AnalyzeOffField(object report)
    {
        string result;

        switch (report) {
            case int nbrSupporters:
                result = $"There are {nbrSupporters} supporters at the match.";
                break;
            case string paAnnouncements:
                result = paAnnouncements;
                break;
            case Injury i:
                result = $"Oh no! {i.GetDescription()} Medics are on the field.";
                break;
            case Incident i:
                result = i.GetDescription();
                break;
            case Manager m:
                result = string.IsNullOrEmpty(m.Club) ? m.Name : $"{m.Name} ({m.Club})";
                break;
            default:
                result = string.Empty;
                break;
        }

        return result;
    }
}
