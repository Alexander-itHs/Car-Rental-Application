using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking

{
	public IPerson Person { get; }
	public IVehicle Vehicle { get; }
	public string RegNo { get; }
	public string Customer { get; }
	public int KmWhenRented { get; }
	public int? KmWhenReturned { get; }
	public DateTime DateRented { get; }
	public DateTime? DateReturned { get; }
	

	public double? Cost { get; set; }
	public BookingStatuses BookingStatus { get; }

    public Booking(IPerson person, IVehicle vehicle, string regNo
		, string customer, int kmWhenRented, int? kmWhenReturned
		, DateTime dateRented, DateTime? dateReturned
		, double? cost, BookingStatuses bookingStatus)
	{
		Person = person;
		Vehicle = vehicle;
		RegNo = regNo;
		Customer = customer;
		KmWhenRented = kmWhenRented;
		KmWhenReturned = kmWhenReturned;
		DateRented = dateRented;
		DateReturned = dateReturned;
		CalculateCost(vehicle);
		BookingStatus = bookingStatus;
    }
	public void CalculateCost(IVehicle vehicle)
	{
		int? daysRented = (int?)(DateReturned - DateRented)?.TotalDays;

		Cost = vehicle.CostPerDay * daysRented 
			+ (KmWhenReturned - KmWhenRented) * vehicle.CostPerKm;
	}
	
	
}
