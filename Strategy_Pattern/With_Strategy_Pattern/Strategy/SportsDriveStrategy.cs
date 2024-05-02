namespace With_Strategy_Pattern.Strategy
{
    public class SportsDriveStrategy:IDriveStrategy{
        public void Drive()
        {
            Console.WriteLine("Special Drive Capability");
        }
    }
}