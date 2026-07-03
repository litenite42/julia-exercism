class WeighingMachine
{
    private double _weight;
    
    public WeighingMachine(int precision = 1) {
        Precision = precision;
    }
    // TODO: define the 'Precision' property
    public int Precision {get;}
    // TODO: define the 'Weight' property
    public double Weight 
    {
        get => _weight; 
        set {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5.0;
    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight => (Weight - TareAdjustment).ToString($"F{Precision}") +" kg";
}
