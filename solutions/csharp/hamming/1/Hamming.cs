public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        
        var x = firstStrand.Select((char c, int ndx) => {
            return c == secondStrand.ElementAt(ndx);
        }).Count(c => !c);

        return x;
    }
}