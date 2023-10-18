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
			_persons.Add(new Customer(12345, "John", "Doe"));
			_persons.Add(new Customer(98765, "Jane", "Doe"));

			_vehicles.Add(new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi
				, 200, VehicleStatuses.Available));
			_vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan
				, 100, VehicleStatuses.Available));
			_vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan
				, 100, VehicleStatuses.Booked));
			_vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van
				, 300, VehicleStatuses.Available));
			_vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle
				, 50, VehicleStatuses.Available));

			_bookings.Add(new Booking(/*_vehicles[2],*/ "GHI789", "Doe John (12345)", 1000, 0
				, 3, "9/9/2023", "", 0, 100, 0, BookingStatuses.Open));
			_bookings.Add(new Booking(/*_vehicles[3],*/ "JKL012", "Doe Jane (98765)", 5000, 5000
				, 1.5, "9/9/2023", "9/9/2023", 0, 300, 300, BookingStatuses.Closed));
			 //DateTime

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
