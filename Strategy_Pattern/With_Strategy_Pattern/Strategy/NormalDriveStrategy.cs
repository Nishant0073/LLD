
namespace  With_Strategy_Pattern.Strategy{
    public class NormalDriveStrategy: IDriveStrategy{
        public void Drive(){
            Console.WriteLine("normal drive capability."); 
        }
    }
}