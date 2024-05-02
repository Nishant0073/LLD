
using With_Strategy_Pattern.Strategy;

namespace With_Strategy_Pattern
{
    public class PassengerVehicle:Vehicle
    {
        public PassengerVehicle():base(new NormalDriveStrategy()){}
        
    }
}
