using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System.Runtime.CompilerServices;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
	private readonly IData _dataBase;
	public BookingProcessor(IData dataBase) => _dataBase = dataBase;

	public IEnumerable<IPerson> GetPersons()
	{
		return _dataBase.GetPersons();
	}
	public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
	{
		return _dataBase.GetVehicles(status);	
	}
	public IEnumerable<IBooking> GetBookings()
	{
		return _dataBase.GetBookings();
	}
	
}
