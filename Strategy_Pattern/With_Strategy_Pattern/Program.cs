// See https://aka.ms/new-console-template for more information
using With_Strategy_Pattern;

Console.WriteLine("WITH STRATEGY PATTERN");
OffRoadVehicle offRoadVehicle = new OffRoadVehicle();
PassengerVehicle passengerVehicle = new PassengerVehicle();
SportsVehicle sportsVehicle = new SportsVehicle();
offRoadVehicle.Drive();
passengerVehicle.Drive();
sportsVehicle.Drive();