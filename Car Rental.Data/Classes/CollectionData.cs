using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes
{
	public class CollectionData : IData
	{
		readonly List<IPerson> _persons = new List<IPerson>();
		readonly List<IVehicle> _vehicles = new List<IVehicle>();
		readonly List<IBooking> _bookings = new List<IBooking>();

		public CollectionData() => SeedData();

		void SeedData()
		{
			_persons.Add(new Customer("12345", "John", "Doe"));
			_persons.Add(new Customer("98765", "Jane", "Doe"));

			_vehicles.Add(new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi
				, 200, VehicleStatuses.Available));
			_vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan
				, 100, VehicleStatuses.Available));
			_vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan
				, 100, VehicleStatuses.Booked));
			_vehicles.Add(new Car("JKL012", "Jeep", 5100, 1.5, VehicleTypes.Van
				, 300, VehicleStatuses.Available));
			_vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle
				, 50, VehicleStatuses.Available));

			_bookings.Add(new Booking(_persons[0], _vehicles[2], _vehicles[2].RegNo
				, $"{_persons[0].LastName} {_persons[0].FirstName} ({_persons[0].SSN})", 1000, null
				, DateTime.Today, null, null, BookingStatuses.Open));
			_bookings.Add(new Booking(_persons[0], _vehicles[3], _vehicles[3].RegNo
				, $"{_persons[1].LastName} {_persons[1].FirstName} ({_persons[1].SSN})", 5000, 5100
				, DateTime.Today.AddDays(-2), DateTime.Today, null, BookingStatuses.Closed));
			 
			 
			
		}

		public IEnumerable<IPerson> GetPersons() => _persons;
		public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status) 
		{
			if (status == default) 
				return _vehicles;
			
			return _vehicles.Where(v => v.VehicleStatus.Equals(status)).ToList();
		}

	public IEnumerable<IBooking> GetBookings() => _bookings;
	}
}
