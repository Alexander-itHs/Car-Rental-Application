using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking

{
	//public IVehicle Vehicle { get; }
	public string RegNo { get; }

	public string Customer { get; }

	public int KmWhenRented { get; }

	public int KmWhenReturned { get; }

	public double CostPerKm { get; }

	public string DateRented { get; }

	public string DateReturned { get; }

	public int DaysRented { get; }

	public int CostPerDay { get; }

	public double Cost { get; set; }

	public BookingStatuses BookingStatus { get; }

    public Booking(/*IVehicle vehicle,*/ string regNo, string customer, int kmWhenRented, int kmWhenReturned
		, double costPerKm, string dateRented, string dateReturned, int daysRented
		, int costPerDay, double cost, BookingStatuses bookingStatus)
    {
		//Vehicle = vehicle;
		RegNo = regNo;
		Customer = customer;
		KmWhenRented = kmWhenRented;
		KmWhenReturned = kmWhenReturned;
		CostPerKm = costPerKm;
		DateRented = dateRented;
		DateReturned = dateReturned;
		DaysRented = daysRented;
		CostPerDay = costPerDay;
		Cost = cost;
		BookingStatus = bookingStatus;

    }
	void ReturnVehicle(IVehicle vehicle)
	{
		
		Cost = DaysRented * vehicle.CostPerDay + (KmWhenReturned - KmWhenRented) * vehicle.CostPerKm;
	}
}
