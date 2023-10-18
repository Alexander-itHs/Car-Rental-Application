using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
	public string RegNo { get; }
	public string Make { get; }
	public int Odometer { get; }
	public double CostPerKm { get; }
	public VehicleTypes VehicleType { get; }
	public int CostPerDay { get; }
	public VehicleStatuses VehicleStatus { get; }
    public Car(string regNo, string make, int odometer, double costPerMile, VehicleTypes vehicleType
		, int costPerDay, VehicleStatuses vehicleStatus)
    {
        RegNo = regNo;
		Make = make;
		Odometer = odometer;
		CostPerKm = costPerMile;
		VehicleType = vehicleType;
		CostPerDay = costPerDay;
		VehicleStatus = vehicleStatus;

    }
}
