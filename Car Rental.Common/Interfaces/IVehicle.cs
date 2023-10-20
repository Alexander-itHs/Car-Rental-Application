using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
	string RegNo { get; }
	string Make { get; }
	int Odometer { get; }
	double CostPerKm { get; }
	VehicleTypes VehicleType { get; }
	int CostPerDay { get; }
	VehicleStatuses VehicleStatus { get; }

	
}
