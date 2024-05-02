
using With_Strategy_Pattern.Strategy;

namespace With_Strategy_Pattern{
public class Vehicle
{
    IDriveStrategy driveStrategy;
    public Vehicle(IDriveStrategy driveStrategy)
    {
        this.driveStrategy = driveStrategy;
    }
    public void Drive()
    {
        driveStrategy.Drive();
    }
}
}