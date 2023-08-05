namespace Mediator._01;

public sealed class CallCenter : ICallCenter
{
    private readonly Dictionary<string, ICab> cabs = new();

    public void Register(ICab cab) {
        if (!cabs.ContainsValue(cab)) cabs.Add(cab.Name, cab);
    }

    public void BookCab(IPassenger passenger) {
        foreach (var cab in cabs.Values.Where(c => c.IsFree)) {
            if (isWithin5Miles(cab.CurrentLocation, passenger.Location)) {
                // Assign passenger to the cab
                cab.Assign(passenger.Name, passenger.Address);
                // Acknowledge the passenger
                passenger.Acknowledge(cab.Name);
                return;
            }
        }
    }

    public bool isWithin5Miles(int cabLoc, int passengerLoc) => Math.Abs(cabLoc - passengerLoc) < 5;

}
