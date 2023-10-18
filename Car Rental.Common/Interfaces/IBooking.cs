using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
	//IVehicle Vehicle { get; }
	string RegNo { get; }
	string Customer { get; }
	int KmWhenRented { get; }
	int KmWhenReturned { get; }
	double CostPerKm { get; }
	string DateRented { get; }
	string DateReturned { get; }
	int DaysRented { get; }
	int CostPerDay { get; }
	double Cost { get; set; }
	//void CalculateCost(); //Beräkna och spara i cost variabeln
	
	BookingStatuses BookingStatus { get; }


}
