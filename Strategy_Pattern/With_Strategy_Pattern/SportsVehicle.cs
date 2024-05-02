
using With_Strategy_Pattern.Strategy;

namespace With_Strategy_Pattern
{
    public class SportsVehicle : Vehicle
    {
        public SportsVehicle():base(new SportsDriveStrategy()){}
    }
}