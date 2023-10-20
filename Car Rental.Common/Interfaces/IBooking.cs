using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
	IPerson Person { get; }
	IVehicle Vehicle { get; }
	string RegNo { get; }
	string Customer { get; }
	int KmWhenRented { get; }
	int? KmWhenReturned { get; }
	DateTime DateRented { get; }
	DateTime? DateReturned { get; }
	double? Cost { get; set; }
	BookingStatuses BookingStatus { get; }

	void CalculateCost(IVehicle vehicle); 


}
