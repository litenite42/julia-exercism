class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesSoFar) {
        return ExpectedMinutesInOven() - minutesSoFar;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) {
        return 2 * numberOfLayers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesSoFar) {
        return PreparationTimeInMinutes(numberOfLayers) + minutesSoFar;
    }
}
