using With_Strategy_Pattern.Strategy;

namespace With_Strategy_Pattern
{
    public class OffRoadVehicle:Vehicle
    {
        public OffRoadVehicle():base(new SportsDriveStrategy()){}
    }
}